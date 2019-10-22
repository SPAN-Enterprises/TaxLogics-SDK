using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClientTool.ViewModels
{
    public class BaseResponseStatus
    {
        /// <summary>
        /// It will return the status codes like 200, 300, etc., Refer Status Codes.
        /// </summary>
        public int StatusCode { get; set; }
        /// <summary>
        /// It will return the name of status code.
        /// </summary>
        public string StatusName { get; set; }

        /// <summary>
        /// It will return the detailed message of status code.
        /// </summary>
        public string StatusMessage { get; set; }
    }
}