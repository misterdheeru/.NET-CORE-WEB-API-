using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using Revalsys.Common.RevalProperties;
using Revalsys.Employee.DAL;
using Revalsys.Employee.RevalProperties;
using Revalsys.Employee.RevalProperties.Models;
using Newtonsoft.Json;
using Revalsys.Common;
/*
   * Author Name            :  Rajesh K  
   * Create Date            :  30 Oct 2023
   * Modified Date          : 
   * Modified Reason        : 
   * Layer                  :  BAL
   * Modified By            : 
   * Description            :  This class have the Employee Module Business Logic Code.
*/
namespace Revalsys.Employee.BAL
{
    public class EmployeeBAL
    {
        #region Constructor
        private ConfigurationSettingsListDTO objConfigurationSettingsListDTO { get; set; }
        public EmployeeBAL(ConfigurationSettingsListDTO _objConfigurationSettingsListDTO)
        {
            if (objConfigurationSettingsListDTO == null)
            {
                objConfigurationSettingsListDTO = _objConfigurationSettingsListDTO;
            }
        }
        #endregion

        #region GetEmployeeBySearch
        //***************************************************************************************************
        // Layer                        :   BAL 
        // Method Name                  :   GetEmployeeBySearch
        // Method Description           :   This method is used to get the Employee Details based on Search parameters.
        // Author                       :   Rajesh K
        // Creation Date                :   30 Oct 2023
        // Input Parameters             :   objEmployeeListDTO
        // Modified Date                : 
        // Modified Reason              :
        // Return Values                :   DataTable
        //----------------------------------------------------------------------------------------------------
        //  Version             Author                      Date                        Remarks       
        // ---------------------------------------------------------------------------------------------------
        //  1.0                 Rajesh K                    30 Oct 2023                 Creation
        //****************************************************************************************************
        /// <summary>
        /// <c>GetEmployeeBySearch</c> This method is used to get the Employee Details based on Search parameters.
        /// <param>objEmployeeListDTO</param>
        /// <returns>DataTable</returns> //It returns the Date Table.
        /// </summary> 
        public Response<object> GetEmployeeBySearch(Request objAPIRequest)
        {
            #region Common Variables
            DateTime startResponseTime = DateTime.Now;
            int ErrorCode = 0;
            string strRespectiveConnectionString = string.Empty;
            string strSiteToken = string.Empty;
            DateTime dtTokenExpiryTime = DateTime.MinValue, dtExpiryTime = DateTime.MinValue;
            string strUserPrivateKey = string.Empty;
            string strResponse = string.Empty;
            #endregion

            #region Specific Variables
            Response<object> objResponse = null;
            EmployeeListDTO objEmployeeListDTO = null;
            EmployeeDAL objEmployeeDAL = null;
            int intPageNumber = 0, intPageSize = 0;
            string strSearchWord = string.Empty,strSortExp = string.Empty,strSortDirection = string.Empty;
            DateTime dtfromdate = DateTime.MinValue, dtTodate = DateTime.MinValue;
            DataTable dtEmployeeDetails = null;
            RegularExpression objRegularExpression = null;
            #endregion

            try
            {
                objRegularExpression = new RegularExpression();

                #region Request data Validations

                #region FromDate
                if (ErrorCode == 0)
                {
                    if (!String.IsNullOrWhiteSpace(objAPIRequest.FromDate))
                    {
                        if (!Regex.IsMatch(objAPIRequest.FromDate.Trim(), objRegularExpression.RegExForDate))
                        {
                            ErrorCode = Convert.ToInt32(General.ErrorCode.Invalid_FromDate);
                        }
                        else
                        {
                            if (DateTime.TryParseExact(objAPIRequest.FromDate.Trim(), objConfigurationSettingsListDTO.DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out dtfromdate))
                            {
                                DateTime.TryParseExact(objAPIRequest.FromDate.Trim(), objConfigurationSettingsListDTO.DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out dtfromdate);
                            }
                            else
                            {
                                try
                                {
                                    dtfromdate = Convert.ToDateTime(objAPIRequest.FromDate.Trim());
                                }
                                catch (Exception Ex)
                                {
                                    dtfromdate = DateTime.MinValue;

                                    ErrorCode = Convert.ToInt32(General.ErrorCode.Technical_Error_occured);
                                }
                            }
                        }
                    }
                }

                #endregion

                #region ToDate
                if (ErrorCode == 0)
                {
                    if (!String.IsNullOrWhiteSpace(objAPIRequest.ToDate))
                    {
                        if (!Regex.IsMatch(objAPIRequest.ToDate.Trim(), objRegularExpression.RegExForDate))
                        {
                            ErrorCode = Convert.ToInt32(General.ErrorCode.Invalid_Todate);
                        }
                        else
                        {
                            if (DateTime.TryParseExact(objAPIRequest.ToDate.Trim(), objConfigurationSettingsListDTO.DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out dtTodate))
                            {
                                DateTime.TryParseExact(objAPIRequest.ToDate.Trim(), objConfigurationSettingsListDTO.DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out dtTodate);
                            }
                            else
                            {
                                try
                                {
                                    dtTodate = Convert.ToDateTime(objAPIRequest.ToDate.Trim());
                                }
                                catch (Exception Ex)
                                {
                                    dtTodate = DateTime.MinValue;

                                    ErrorCode = Convert.ToInt32(General.ErrorCode.Technical_Error_occured);
                                }
                            }
                        }
                    }

                }

                if (objAPIRequest.FromDate != null && objAPIRequest.ToDate != null)
                {
                    if (dtfromdate > dtTodate)
                    {
                        ErrorCode = Convert.ToInt32(General.ErrorCode.FromDate_Should_not_be_greater_than_ToDate);
                    }

                }

                #endregion

                #region Search Text Validation
                if (ErrorCode == 0)
                {
                    if (objAPIRequest.SearchWord != null && !String.IsNullOrWhiteSpace(objAPIRequest.SearchWord))
                    {
                        if (!Regex.IsMatch(objAPIRequest.SearchWord.Trim(), objRegularExpression.RegExSearchWord))
                        {
                            ErrorCode = Convert.ToInt32(General.ErrorCode.Invalid_SearchWord);
                        }
                        else
                        {
                            strSearchWord = objAPIRequest.SearchWord;
                        }
                    }
                }
                #endregion

                #region  PageNumber Validation
                if (ErrorCode == 0)
                {
                    if (objAPIRequest.PageNumber != null && !String.IsNullOrWhiteSpace(objAPIRequest.PageNumber))
                    {
                        if (!Regex.IsMatch(objAPIRequest.PageNumber.Trim(), objRegularExpression.RegExForId))
                        {
                            ErrorCode = Convert.ToInt32(General.ErrorCode.Invalid_PageNumber);
                        }
                        else
                        {
                            intPageNumber = Convert.ToInt32(objAPIRequest.PageNumber);
                        }
                    }
                }
                #endregion

                #region  PageSize Validation
                if (ErrorCode == 0)
                {
                    if (objAPIRequest.PageSize != null && !String.IsNullOrWhiteSpace(objAPIRequest.PageSize))
                    {
                        if (!Regex.IsMatch(objAPIRequest.PageSize.Trim(), objRegularExpression.RegExForId))
                        {
                            ErrorCode = Convert.ToInt32(General.ErrorCode.Invalid_PageSize);
                        }
                        else
                        {
                            intPageSize = Convert.ToInt32(objAPIRequest.PageSize);
                        }
                    }
                }
                #endregion

                #region SortExp Validation
                if (ErrorCode == 0)
                {
                    if (objAPIRequest.SortExp != null && !String.IsNullOrWhiteSpace(objAPIRequest.SortExp))
                    {
                        if (!Regex.IsMatch(objAPIRequest.SortExp.Trim(), objRegularExpression.RegExSort))
                        {
                            ErrorCode = Convert.ToInt32(General.ErrorCode.Invalid_Sort_Expression);
                        }
                        else
                        {
                            strSortExp = objAPIRequest.SortExp;
                        }
                    }
                }
                #endregion

                #region SortDirection Validation
                if (ErrorCode == 0)
                {
                    if (objAPIRequest.SortDirection != null && !String.IsNullOrWhiteSpace(objAPIRequest.SortDirection))
                    {
                        if (!Regex.IsMatch(objAPIRequest.SortDirection.Trim(), objRegularExpression.RegExSort))
                        {
                            ErrorCode = Convert.ToInt32(General.ErrorCode.Invalid_Sort_Direction);
                        }
                        else
                        {
                            strSortDirection = objAPIRequest.SortDirection;
                        }
                    }
                }
                #endregion

                #endregion

                #region Calling DAL
                if (ErrorCode == 0)
                {
                    if (ErrorCode == 0)
                    {
                        if (intPageNumber <= 0 || intPageSize <= 0)
                        {
                            intPageNumber = 1;
                            intPageSize = 999999999;
                        }
                        objEmployeeListDTO = new EmployeeListDTO()
                        {
                            PageSize = intPageSize,
                            PageNumber = intPageNumber,
                            SearchWord = strSearchWord,
                            FromDate = dtfromdate,
                            ToDate = dtTodate,
                            SortExp = strSortExp,
                            SortDirection = strSortDirection

                        };
                    }

                    if (objEmployeeListDTO != null)
                    {
                        try
                        {
                            objEmployeeDAL = new EmployeeDAL(objConfigurationSettingsListDTO);
                            dtEmployeeDetails = objEmployeeDAL.GetEmployeeBySearchDB(objEmployeeListDTO);

                            if (dtEmployeeDetails != null && dtEmployeeDetails.Rows.Count > 0)
                            {
                                strResponse = JsonConvert.SerializeObject(dtEmployeeDetails, Formatting.Indented);
                            }
                            else
                            {
                                ErrorCode = Convert.ToInt32(General.ErrorCode.No_Records_Found);
                            }
                        }
                        catch (Exception Ex)
                        {
                            ErrorCode = Convert.ToInt32(General.ErrorCode.Technical_Error_occured);
                        }
                        finally
                        {
                            objEmployeeListDTO = null;
                        }
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                ErrorCode = Convert.ToInt32(General.ErrorCode.Technical_Error_occured);
            }
            finally
            {
                objEmployeeDAL = null;
                objEmployeeDAL = null;

                try
                {
                    if (ErrorCode > 0)
                    {
                        objResponse = new Response<object>();
                        objResponse.ReturnCode = -1;
                        objResponse.ReturnMessage = Enum.GetName(typeof(General.ErrorCode), ErrorCode).Replace('_', ' ');
                        objResponse.Data = null;
                    }
                    else if (ErrorCode == 0 && dtEmployeeDetails != null && dtEmployeeDetails.Rows.Count > 0)
                    {
                        objResponse = new Response<object>();
                        objResponse.ReturnCode = 0;
                        objResponse.ReturnMessage = "success";
                        objResponse.RecordCount = dtEmployeeDetails.Rows.Count;
                        objResponse.ResponseTime = Math.Round((DateTime.Now - startResponseTime).TotalMilliseconds).ToString();
                        var json = JsonConvert.DeserializeObject<dynamic>(strResponse);
                        objResponse.Data = json;
                    }

                    objResponse.ResponseTime = Math.Round((DateTime.Now - startResponseTime).TotalMilliseconds).ToString();
                }
                catch (Exception ex)
                {
                    //if (objConfigurationSettingsListDTO.LogTypeId > 0)
                    //{
                    //    General.CreateErrorLog(ex, MethodBase.GetCurrentMethod().Name, lstSiteDetails, lstSiteSolrURlListDTO);
                    //}
                }
                finally
                {
                    #region Nullifying Objects
                    objRegularExpression = null;
                    #endregion
                }
            }
            return objResponse;
        }
        #endregion
    }
}
