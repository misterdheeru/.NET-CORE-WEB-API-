/*
   * Author Name            :  Rajesh K  
   * Create Date            :  30 Oct 2023
   * Modified Date          : 
   * Modified Reason        : 
   * Layer                  :  ListDTO
   * Modified By            : 
   * Description            :  This class have the Regular Expression Properties.
*/
namespace Revalsys.Common.RevalProperties
{
    public class RegularExpression
    {
        #region RegExForDate
        /// <summary>
        /// Gets the RegExForDate.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          14 Oct 2021       Creation 
        //=======================================================
        public string RegExForDate
        {
            get;
            set;
        }
        #endregion

        #region RegExSearchWord
        /// <summary>
        /// Gets the RegExSearchWord.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          14 Oct 2021       Creation 
        //=======================================================
        public string RegExSearchWord
        {
            get;
            set;
        }
        #endregion

        #region RegExForId
        /// <summary>
        /// Gets the RegExForId.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          14 Oct 2021       Creation 
        //=======================================================
        public string RegExForId
        {
            get;
            set;
        }
        #endregion

        #region RegExSort
        /// <summary>
        /// Gets the RegExSort.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          14 Oct 2021       Creation 
        //=======================================================
        public string RegExSort
        {
            get;
            set;
        }
        #endregion

        #region Contructor
        public RegularExpression()
        {
            RegExForDate = "^([0-2][0-9]|(3)[0-1])(\\/)(((0)[0-9])|((1)[0-2]))(\\/)\\d{4}$";
            RegExSearchWord = "^[^<>]*$";
            RegExForId = "^[0-9]*$";
            RegExSort = "^[a-zA-Z]*$";
        }
        #endregion
    }
}
