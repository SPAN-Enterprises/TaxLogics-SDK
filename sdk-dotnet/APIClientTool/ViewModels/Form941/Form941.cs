using System;
using System.Collections.Generic;

namespace APIClientTool.ViewModels.Form941
{
    public class Form941
    {
        public Guid SubmissionId { get; set; }
        /// <summary>
        /// Form 941 Records
        /// </summary>
        public Form941Data Form941Records { get; set; }
    }

}