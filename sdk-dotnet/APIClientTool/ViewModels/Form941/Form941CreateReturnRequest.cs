using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClientTool.ViewModels.Form941
{
    public class Form941CreateReturnRequest
    {
        public Guid SubmissionId { get; set; }
        /// <summary>
        /// This action will look for the Form 941 Form details to create the return
        /// </summary>
        public List<Form941Data> Form941Records { get; set; }
    }
}