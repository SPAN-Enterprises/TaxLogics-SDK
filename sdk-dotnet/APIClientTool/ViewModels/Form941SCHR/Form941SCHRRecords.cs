using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClientTool.ViewModels.Form941SCHR
{
    public class Form941SchRRecords
    {
        /// <summary>
        /// This identifies the sequence on the record sent in the pay load. When errors occur we will send the errors attached to particular sequence. Leave it blank for Update API.
        /// </summary>
        /// <value>
        /// Sequence number of the record
        /// </value>
        public string Sequence { get; set; }
        /// <summary>
        /// Form 941SCHR Return Header
        /// </summary>
        public Form941SchRReturnHeader ReturnHeader { get; set; }
        /// <summary>
        /// Form 941SCHR Return Data
        /// </summary>
        public Form941SchRReturnData ReturnData { get; set; }
        /// <summary>
        /// Gets or sets the Record Id
        /// </summary>
        /// <value>
        /// Record Identifier
        /// </value>
        public Guid? RecordId { get; set; }
    }
}