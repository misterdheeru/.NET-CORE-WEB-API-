using System;
/*
   * Author Name            :  Rajesh K  
   * Create Date            :  30 Oct 2023
   * Modified Date          : 
   * Modified Reason        : 
   * Layer                  :  ListDTO
   * Modified By            : 
   * Description            :  This class have the Employee Module Properties.
*/
namespace Revalsys.Employee.RevalProperties
{
    public class EmployeeListDTO
    {
        #region PageSize
        /// <summary>
        /// Gets the PageSize.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        public int PageSize { get; set; }
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
        public int PageNumber { get; set; }
        #endregion

        #region SearchWord
        /// <summary>
        /// Gets the SearchWord.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        public string SearchWord { get; set; }
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
        public DateTime FromDate { get; set; }
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
        public DateTime ToDate { get; set; }
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
        public string SortDirection { get; set; }
        #endregion

        #region Constructor
        public EmployeeListDTO()
        {
            PageSize = 0;
            PageNumber = 0;
            SearchWord = string.Empty;
            FromDate = DateTime.MinValue;
            ToDate = DateTime.MinValue;
            SortExp = string.Empty;
            SortDirection = string.Empty;
        }
        #endregion
    }
}
