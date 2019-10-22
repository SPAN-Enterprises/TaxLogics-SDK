using System.Collections.Generic;
namespace APIClientTool.ViewModels.Form941CoreModel
{
    public class DeleteReturnResponse
    {
        public DeleteFormRecords Form941Records { get; set; }
        public List<Error> Errors { get; set; }
        public int StatusCode { get; set; }
        public string StatusName { get; set; }
        public string StatusMessage { get; set; }
    }
}