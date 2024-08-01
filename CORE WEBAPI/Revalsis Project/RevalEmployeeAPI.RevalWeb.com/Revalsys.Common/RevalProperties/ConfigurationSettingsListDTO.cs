/*
   * Author Name            :  Rajesh K  
   * Create Date            :  30 Oct 2023
   * Modified Date          : 
   * Modified Reason        : 
   * Layer                  :  ListDTO
   * Modified By            : 
   * Description            :  This class have the ConfigurationSettingsListDTO Properties.
*/
namespace Revalsys.Common.RevalProperties
{
    public class ConfigurationSettingsListDTO
    {
        #region ConnectionString
        /// <summary>
        /// Gets the ConnectionString.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        public string ConnectionString { get; set; }
        #endregion

        #region DateFormat
        /// <summary>
        /// Gets the DateFormat.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        public string DateFormat { get; set; }
        #endregion

        #region EncryptionKey
        /// <summary>
        /// Gets the EncryptionKey.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        public string EncryptionKey { get; set; }
        #endregion
    }

}
