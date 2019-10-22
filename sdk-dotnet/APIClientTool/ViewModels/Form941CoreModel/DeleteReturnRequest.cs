using System;
using System.Collections.Generic;
namespace APIClientTool.ViewModels
{
    public class DeleteReturnRequest 
    {
        public Guid SubmissionId { get; set; }
        public List<Guid> RecordIds { get; set; }
    }
}