using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClientTool.ViewModels
{
    public class FormW2ListRequest
    {
        /// <summary>
        /// Business Identifier
        /// </summary>
        public Guid BusinessId { get; set; }

        /// <summary>
        /// EIN
        /// </summary>
        public string Ein { get; set; }

        /// <summary>
        /// Page number  
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Range: 10, 25, 50, 100
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// It will show the E-filing status like Created, Transmitted, Processing, Accepted, Rejected
        /// </summary>
        public string EfileStatus { get; set; }

        /// <summary>
        /// W-2 return created from date
        /// </summary>
        public DateTime? CreatedDateFrom { get; set; }

        /// <summary>
        /// W-2 return created to date
        /// </summary>
        public DateTime? CreatedDateTo { get; set; }
    }
}