using APIClientTool.ViewModels.Form941CoreModel;
using System.Collections.Generic;
namespace APIClientTool.ViewModels
{
    public class FormW2DeleteReturnResponse
    {
        public DeleteFormRecords FormW2Records { get; set; }
        public List<Error> Errors { get; set; }
        public int StatusCode { get; set; }
        public string StatusName { get; set; }
        public string StatusMessage { get; set; }
    }
}