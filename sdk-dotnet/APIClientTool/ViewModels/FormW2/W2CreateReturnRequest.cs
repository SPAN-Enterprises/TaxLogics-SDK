using System.Collections.Generic;

namespace APIClientTool.ViewModels
{
    public class W2CreateReturnRequest
    {
        /// <summary>
        /// This action will look for the Form W-2 Form details to create the return
        /// </summary>
        public List<FormW2> W2Forms { get; set; }
    }

}