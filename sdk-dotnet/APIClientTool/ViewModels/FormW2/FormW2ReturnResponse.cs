using System;
using System.Collections.Generic;

namespace APIClientTool.ViewModels
{
    public class FormW2ReturnResponse : FilingStatus
    {
        public Guid SubmissionId { get; set; }
        public FormRecords FormW2Records { get; set; }
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string StatusName { get; set; }
        public List<Error> Errors { get; set; }
    }
    public class FormRecords
    {
        public List<FormRecordSuccessStatus> SuccessRecords { get; set; }
        public List<FormRecordErrorStatus> ErrorRecords { get; set; }
    }
    public class FormRecordErrorStatus
    {
        public string Sequence { get; set; }
        public List<Error> Errors { get; set; }
    }
    public class FormRecordSuccessStatus
    {
        public string Sequence { get; set; }
        public Guid? RecordId { get; set; }
        public string RecordStatus { get; set; }
        public string CreatedTs { get; set; }
        public string UpdatedTs { get; set; }
    }

    public class Error
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
    }
    public class FilingStatus
    {
        public bool IsReturnTransmitted { get; set; }
    }
}