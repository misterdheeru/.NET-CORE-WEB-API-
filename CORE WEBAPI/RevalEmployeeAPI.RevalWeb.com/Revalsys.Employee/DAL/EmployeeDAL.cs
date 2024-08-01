using Revalsys.Common.RevalProperties;
using System;
using System.Data;
using System.Data.SqlClient;
using Revalsys.Employee.RevalProperties;

/*
   * Author Name            :  Rajesh K  
   * Create Date            :  30 Oct 2023
   * Modified Date          : 
   * Modified Reason        : 
   * Layer                  :  DAL
   * Modified By            : 
   * Description            :  This class have the Employee Module Data Access Related Code.
*/
namespace Revalsys.Employee.DAL
{
    public class EmployeeDAL
    {
        #region ConnectionString

        public string strConnectionString = string.Empty;

        private Int32 CommandTimeOut = 0;

        public EmployeeDAL(ConfigurationSettingsListDTO _objConfigurationSettingsListDTO)
        {
            strConnectionString = _objConfigurationSettingsListDTO.ConnectionString;
        }

        #endregion

        #region GetEmployeeBySearchDB
        //***************************************************************************************************
        // Layer                        :   DAL 
        // Method Name                  :   GetEmployeeBySearchDB
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
        /// <c>GetEmployeeBySearchDB</c> This method is used to get the Employee Details based on Search parameters.
        /// <param>objEmployeeListDTO</param>
        /// <returns>DataTable</returns> //It returns the Date Table.
        /// </summary>

        public DataTable GetEmployeeBySearchDB(EmployeeListDTO objEmployeeListDTO)
        {
            using (SqlConnection sqlConnection = new SqlConnection(strConnectionString))
            {

                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = sqlConnection;
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.CommandText = @"uspGetRevalEmployeeBySearch";
                    sqlCmd.CommandTimeout = CommandTimeOut;
                    sqlCmd.Parameters.Add("PageSize", SqlDbType.Int).Value = objEmployeeListDTO.PageSize;
                    sqlCmd.Parameters.Add("PageNumber", SqlDbType.Int).Value = objEmployeeListDTO.PageNumber;
                    sqlCmd.Parameters.Add("SearchWord", SqlDbType.NVarChar).Value = objEmployeeListDTO.SearchWord;
                    
                    if (objEmployeeListDTO.FromDate > DateTime.MinValue)
                    {
                        sqlCmd.Parameters.Add("FromDate", SqlDbType.DateTime2).Value = objEmployeeListDTO.FromDate;
                    }

                    if (objEmployeeListDTO.FromDate > DateTime.MinValue)
                    {
                        sqlCmd.Parameters.Add("ToDate", SqlDbType.DateTime2).Value = objEmployeeListDTO.ToDate;
                    }
                    
                    if (!String.IsNullOrWhiteSpace(objEmployeeListDTO.SortExp))
                    {
                        sqlCmd.Parameters.Add("SortExp", SqlDbType.NVarChar).Value = objEmployeeListDTO.SortExp;
                    }

                    if (!String.IsNullOrWhiteSpace(objEmployeeListDTO.SortDirection))
                    {
                        sqlCmd.Parameters.Add("SortDirection", SqlDbType.NVarChar).Value = objEmployeeListDTO.SortDirection;
                    }


                    SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                    DataTable dtResult = new DataTable();
                    da.Fill(dtResult);
                    return dtResult;
                }

            }
        }
        #endregion End of GetProductBySearch  
    }
}
