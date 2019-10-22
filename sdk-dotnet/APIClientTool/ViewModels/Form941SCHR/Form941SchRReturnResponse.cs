using System;
using System.Collections.Generic;
namespace APIClientTool.ViewModels.Form941SCHR
{
    public class Form941SchRReturnResponse : FilingStatus
    {
        public Guid SubmissionId { get; set; }
        public FormRecords Form941SchRRecords { get; set; }
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string StatusName { get; set; }
        public List<Error> Errors { get; set; }
    }
}