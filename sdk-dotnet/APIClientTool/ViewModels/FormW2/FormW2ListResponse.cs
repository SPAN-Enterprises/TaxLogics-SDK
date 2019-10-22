using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClientTool.ViewModels
{
    public class FormW2ListResponse
    {
        public Guid? SubmissionId { get; set; }
        public Guid? BusinessId { get; set; }
        public string BusinessNm { get; set; }
        public string EINorSSN { get; set; }
        public string Name { get; set; }
        public Guid? RecordId { get; set; }
        public string TaxYr { get; set; }
        public bool IsPostal { get; set; }
        public string EFileStatus { get; set; }

    }
}