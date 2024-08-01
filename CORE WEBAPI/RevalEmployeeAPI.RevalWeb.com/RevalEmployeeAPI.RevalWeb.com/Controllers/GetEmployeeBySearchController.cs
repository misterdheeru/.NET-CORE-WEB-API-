using Revalsys.Common;
using Revalsys.Common.RevalProperties;
using Revalsys.Employee.BAL;
using Revalsys.Employee.RevalProperties.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

/*
   * Author Name            :  Rajesh K  
   * Create Date            :  30 Oct 2023
   * Modified Date          : 
   * Modified Reason        : 
   * Layer                  :  ListDTO
   * Modified By            : 
   * Description            :  This class have the GetEmployeeBySearch Controller.
*/
namespace RevalEmployee.Controllers
{
    [Route("api/GetEmployee")]
    [ApiController]
    public class GetEmployeeBySearchController : ControllerBase
    {
        private ConfigurationSettingsListDTO _ConfigurationSettingsListDTO = null;

        public GetEmployeeBySearchController(IOptions<ConfigurationSettingsListDTO> options)
        {
            _ConfigurationSettingsListDTO = options.Value;
        }

        #region GetEmployeeBySearch
        //***************************************************************************************************
        // Layer                        :   Controller 
        // Method Name                  :   GetEmployeeBySearch
        // Method Description           :   This method is used to get the Employee Details based on Search parameters.
        // Author                       :   Rajesh K
        // Creation Date                :   30 Oct 2023
        // Input Parameters             :   objAPIRequest
        // Modified Date                : 
        // Modified Reason              :
        // Return Values                :   objContentResult
        //----------------------------------------------------------------------------------------------------
        //  Version             Author                      Date                        Remarks       
        // ---------------------------------------------------------------------------------------------------
        //  1.0                 Rajesh K                    30 Oct 2023                 Creation
        //****************************************************************************************************
        /// <summary>
        /// <c>GetEmployeeBySearch</c> This method is used to get the Employee Details based on Search parameters.
        /// <param>objAPIRequest</param>
        /// <returns>objContentResult</returns> //It returns the Date Table.
        /// </summary>
        /// 
        [HttpPost]
        public async Task<ContentResult> GetEmployeeBySearch(Request objAPIRequest)
        {
            var HeaderType = Request.ContentType;
            EmployeeBAL objEmployeeBAL = null;
            ContentResult objContentResult = null;
            Response<object> objEmployeeBySearch = null;
            object objResult = null;
            Response<object> objResponse = new Response<object>
            {
                ReturnCode = Convert.ToInt32(((int)General.CommonResponseErrorCodes.InvalidRequest)),
                ReturnMessage = Enum.GetName(typeof(General.CommonResponseErrorCodes), General.CommonResponseErrorCodes.InvalidRequest)
            };
            Int32 StatusCode = 0;
            var strClaimsToken = HttpContext.User.Claims;
            var IPAddress = HttpContext.Connection.RemoteIpAddress;

            #region After validating request
            try
            {

                if (_ConfigurationSettingsListDTO != null)
                {
                    var strTokenDetails = strClaimsToken.ToList();
                    objAPIRequest.IPAddress = IPAddress.ToString();

                    Task<Response<object>> tskResponse = Task<Response<object>>.Run(() =>
                    {
                        objEmployeeBAL = new EmployeeBAL(_ConfigurationSettingsListDTO);
                        objEmployeeBySearch = objEmployeeBAL.GetEmployeeBySearch(objAPIRequest);
                        return objEmployeeBySearch;
                    });
                    objEmployeeBySearch = await tskResponse;

                    if (objEmployeeBySearch != null)
                    {
                        objResult = objEmployeeBySearch;
                    }
                    else
                    {
                        objResult = objResponse;
                    }
                }
                else
                {
                    objResult = objResponse;
                }
                StatusCode = (int)General.CommonResponseErrorCodes.Success;
            }
            catch (Exception ex)
            {
                //if (_ConfigurationSettingsListDTO != null && _ConfigurationSettingsListDTO.LogTypeId > 0)
                //{
                //    objConfigurationSettingsListDTO = _ConfigurationSettingsListDTO;
                //    General.CreateErrorLog(ex, MethodBase.GetCurrentMethod().Name);
                //}
                StatusCode = (int)General.CommonResponseErrorCodes.InvalidRequest;
            }
            finally
            {
                #region Nullifying Objects
                objResponse = null;
                #endregion
            }
            #endregion

            #region output converting xml or json
            if (HeaderType != null)
            {
                if (HeaderType.ToString().ToLower().Contains("application/xml")) //converting the xml
                {
                    //objContentResult = new ContentResult() { Content = clsSecurity.ConvertObjectToXml(objResult), ContentType = "application/xml", StatusCode = StatusCode };
                }
                else if (HeaderType.ToString().ToLower().Contains("application/json"))
                {
                    objContentResult = new ContentResult() { Content = JsonConvert.SerializeObject(objResult), ContentType = "application/json", StatusCode = StatusCode };
                }
                else
                {
                    objContentResult = new ContentResult() { Content = JsonConvert.SerializeObject(objResult), ContentType = "application/json", StatusCode = StatusCode };
                }
            }
            else
            {
                objContentResult = new ContentResult() { Content = JsonConvert.SerializeObject(objResult), ContentType = "application/json", StatusCode = StatusCode };
            }
            return objContentResult;
            #endregion
        }
        #endregion
    }
}
