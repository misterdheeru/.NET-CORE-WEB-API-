/*
   * Author Name            :  Rajesh K  
   * Create Date            :  30 Oct 2023
   * Modified Date          : 
   * Modified Reason        : 
   * Layer                  :  ListDTO
   * Modified By            : 
   * Description            :  This class have the API Request Properties.
*/
namespace Revalsys.Employee.RevalProperties.Models
{
    public class Request
    {
        #region SearchWord
        /// <summary>
        /// Gets the SearchWord.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        [Newtonsoft.Json.JsonProperty("SearchWord", Required = Newtonsoft.Json.Required.Default)]
        public string SearchWord { get; set; }
        #endregion

        #region PageNumber
        /// <summary>
        /// Gets the PageNumber.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        [Newtonsoft.Json.JsonProperty("PageNumber", Required = Newtonsoft.Json.Required.Default)]
        public string PageNumber { get; set; }
        #endregion

        #region PageSize
        /// <summary>
        /// Gets the PageSize.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        [Newtonsoft.Json.JsonProperty("PageSize", Required = Newtonsoft.Json.Required.Default)]
        public string PageSize { get; set; }
        #endregion

        #region FromDate
        /// <summary>
        /// Gets the FromDate.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        [Newtonsoft.Json.JsonProperty("FromDate", Required = Newtonsoft.Json.Required.Default)]
        public string FromDate { get; set; }
        #endregion

        #region ToDate
        /// <summary>
        /// Gets the ToDate.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        [Newtonsoft.Json.JsonProperty("ToDate", Required = Newtonsoft.Json.Required.Default)]
        public string ToDate { get; set; }
        #endregion

        #region SiteId
        /// <summary>
        /// Gets the SiteId.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        [Newtonsoft.Json.JsonProperty("SiteId", Required = Newtonsoft.Json.Required.Default)]
        public string SiteId { get; set; }
        #endregion

        #region CompanyId
        /// <summary>
        /// Gets the CompanyId.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        [Newtonsoft.Json.JsonProperty("CompanyId", Required = Newtonsoft.Json.Required.Default)]
        public string CompanyId { get; set; }
        #endregion

        #region DepartmentId
        /// <summary>
        /// Gets the DepartmentId.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        [Newtonsoft.Json.JsonProperty("DepartmentId", Required = Newtonsoft.Json.Required.Default)]
        public string DepartmentId { get; set; }
        #endregion

        #region IPAddress
        /// <summary>
        /// Gets the IPAddress.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        [Newtonsoft.Json.JsonProperty("IPAddress", Required = Newtonsoft.Json.Required.Default)]
        public string IPAddress { get; set; }
        #endregion

        #region SortExp
        /// <summary>
        /// Gets the SortExp.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        [Newtonsoft.Json.JsonProperty("SortExp", Required = Newtonsoft.Json.Required.Default)]
        public string SortExp { get; set; }
        #endregion

        #region SortDirection
        /// <summary>
        /// Gets the SortDirection.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        [Newtonsoft.Json.JsonProperty("SortDirection", Required = Newtonsoft.Json.Required.Default)]
        public string SortDirection { get; set; }
        #endregion
    }
}
