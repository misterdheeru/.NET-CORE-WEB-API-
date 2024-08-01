using System.Collections.Generic;
/*
   * Author Name            :  Rajesh K  
   * Create Date            :  30 Oct 2023
   * Modified Date          : 
   * Modified Reason        : 
   * Layer                  :  General
   * Modified By            : 
   * Description            :  This class have the Enums and General Related Code.
*/
namespace Revalsys.Common
{
    public class General
    {
        #region ErrorCode
        public enum ErrorCode
        {
            Technical_Error_occured = 8,
            Invalid_FromDate = 1,
            Invalid_Todate = 2,
            FromDate_Should_not_be_greater_than_ToDate = 3,
            Invalid_SearchWord = 4,
            Invalid_PageNumber = 5,
            Invalid_PageSize = 6,
            No_Records_Found = 7,
            Invalid_Sort_Expression = 8,
            Invalid_Sort_Direction = 9,

        }
        #endregion

        #region CommonResponseErrorCodes
        public enum CommonResponseErrorCodes
        {
            //http status codes
            Success = 200,
            RequestTimeOut = 408,
            BadRequest = 400,
            UnAuthorized = 401,
            Forbidden = 403,
            NotAcceptable = 406,
            InvalidRequest = -101,
            No_Records_Found = 22
        }

        public static Dictionary<string, string> dictCommonResponse
        {
            get
            {
                Dictionary<string, string> dictCommonResponse = new Dictionary<string, string>();
                dictCommonResponse.Add(CommonResponseErrorCodes.Success.ToString(), "Success");
                dictCommonResponse.Add(CommonResponseErrorCodes.RequestTimeOut.ToString(), "Request Time Out");
                dictCommonResponse.Add(CommonResponseErrorCodes.BadRequest.ToString(), "Bad Request");
                dictCommonResponse.Add(CommonResponseErrorCodes.UnAuthorized.ToString(), "UnAuthorized");
                dictCommonResponse.Add(CommonResponseErrorCodes.Forbidden.ToString(), "Forbidden");
                dictCommonResponse.Add(CommonResponseErrorCodes.NotAcceptable.ToString(), "Not Acceptable");
                dictCommonResponse.Add(CommonResponseErrorCodes.InvalidRequest.ToString(), "Invalid Request");
                dictCommonResponse.Add(CommonResponseErrorCodes.No_Records_Found.ToString(), "No Records Found");

                return dictCommonResponse;
            }
        }
        #endregion
    }
}
