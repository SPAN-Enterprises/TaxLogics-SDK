using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClientTool.ViewModels.Form941CoreModel
{
    public class DeleteFormRecords
    {
        public List<FormRecordSuccessStatus> SuccessRecords { get; set; }
        public List<FormRecordErrorStatus> ErrorRecords { get; set; }
    }
    public class FormRecordErrorStatus
    {
        public string Sequence { get; set; }
        public Guid? RecordId { get; set; }
        public List<Error> Errors { get; set; }
        public List<FormClientRecordErrorStatus> ClientErrorRecords { get; set; }
    }
    public class FormRecordSuccessStatus
    {
        public string Sequence { get; set; }
        public Guid? RecordId { get; set; }
        public string RecordStatus { get; set; }
        public string CreatedTs { get; set; }
        public string UpdatedTs { get; set; }
        public List<FormClientRecordSuccessStatus> ClientSuccessRecords { get; set; }
    }
    public class FormClientRecordErrorStatus
    {
        public string CSeqId { get; set; }
        public Guid? CRecordId { get; set; }
        public List<Error> Errors { get; set; }
    }
    public class FormClientRecordSuccessStatus
    {
        public string CSeqId { get; set; }
        public Guid? CRecordId { get; set; }
        public string RecordStatus { get; set; }
        public string CreatedTs { get; set; }
        public string UpdatedTs { get; set; }
    }
}