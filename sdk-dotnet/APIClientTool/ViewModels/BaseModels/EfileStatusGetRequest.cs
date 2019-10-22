using System;
using System.Collections.Generic;

namespace APIClientTool.ViewModels
{
    public class EfileStatusGetRequest
    {
        public Guid SubmissionId { get; set; }
        public List<Guid> RecordIds { get; set; }
    }
}