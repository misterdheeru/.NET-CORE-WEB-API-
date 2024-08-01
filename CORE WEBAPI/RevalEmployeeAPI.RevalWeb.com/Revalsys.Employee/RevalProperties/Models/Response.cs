using System.Runtime.Serialization;

/*
   * Author Name            :  Rajesh K  
   * Create Date            :  30 Oct 2023
   * Modified Date          : 
   * Modified Reason        : 
   * Layer                  :  ListDTO
   * Modified By            : 
   * Description            :  This class have the API Response Properties.
*/
namespace Revalsys.Employee.RevalProperties.Models
{
    public class Response<T>
    {
        #region ReturnCode
        /// <summary>
        /// Gets the ReturnCode.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        private int _ReturnCode;
        [DataMember]
        public int ReturnCode
        {
            get
            { return _ReturnCode; }
            set
            { _ReturnCode = value; }
        }
        #endregion

        #region ReturnMessage
        /// <summary>
        /// Gets the ReturnMessage.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        private string _ReturnMessage;
        [DataMember]
        public string ReturnMessage
        {
            get
            { return _ReturnMessage; }
            set
            { _ReturnMessage = value; }
        }
        #endregion

        #region ResponseTime
        /// <summary>
        /// Gets the ResponseTime.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        private string _ResponseTime;
        [DataMember]
        public string ResponseTime
        {
            get
            { return _ResponseTime; }
            set
            { _ResponseTime = value; }
        }
        #endregion

        #region RecordCount
        /// <summary>
        /// Gets the RecordCount.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        private long _RecordCount;
        [DataMember]
        public long RecordCount
        {
            get { return _RecordCount; }
            set { _RecordCount = value; }
        }
        #endregion

        #region Headers
        /// <summary>
        /// Gets the Headers.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        private T _Headers;
        [DataMember]
        public T Headers
        {
            get
            { return _Headers; }
            set
            { _Headers = value; }
        }
        #endregion

        #region Data
        /// <summary>
        /// Gets the Data.
        /// </summary>
        //=======================================================
        //Version       Author          Date               Remark
        //=======================================================
        //1.0         Rajesh K          30 Oct 2023       Creation 
        //=======================================================
        private T _Data;
        [DataMember]
        public T Data
        {
            get
            { return _Data; }
            set
            { _Data = value; }
        }
        #endregion

        #region Constructor
        public Response()
        {
            _ReturnCode = -1;
            _ReturnMessage = string.Empty;
            _ResponseTime = string.Empty;
            _RecordCount = 0;
            _Data = default(T);
            _Headers = default(T);
        }
        #endregion
    }
}
