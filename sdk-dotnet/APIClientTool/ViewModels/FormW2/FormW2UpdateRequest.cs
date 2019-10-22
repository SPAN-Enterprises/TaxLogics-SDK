using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClientTool.ViewModels
{
    /// <summary>
    /// W2Update Return Request
    /// </summary>
   
    public class FormW2UpdateRequest
    {
        /// <summary>
        /// Submission ID
        /// </summary>
      
        public Guid SubmissionId { get; set; }
        /// <summary>
        /// Collection of Form W2 Details
        /// </summary>
        
        public List<FormW2> W2Forms { get; set; }
    }
}