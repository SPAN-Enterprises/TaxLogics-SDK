using APIClientTool.ViewModels.Form941CoreModel;
namespace APIClientTool.ViewModels.Form941SCHR
{
    public class Form941SchRReturnHeader
    {
        /// <summary>
        /// Gets or sets the Return Type
        /// </summary>
        /// <value>
        /// Return type
        /// </value>
        public object ReturnType { get; set; }
        /// <summary>
        /// Gets or sets the MoreClients
        /// </summary>
        public bool MoreClients { get; set; }
        /// <summary>
        ///  Gets or sets the form 941 tax year 
        /// </summary>
        /// <value>
        /// Form 941SCHR taxyear 
        /// </value>
        public string TaxYr { get; set; }
        /// <summary>
        /// Gets or sets the form 941 quarter
        /// </summary>
        /// <value>
        /// Form 941SCHR Filing Quarter
        /// </value>
        public string Qtr { get; set; }
        /// <summary>
        ///  Business Details
        /// </summary>
        public Business Business { get; set; }
        /// <summary>
        /// Gets or sets the IsThirdPartyDesignee
        /// </summary>
        public bool IsThirdPartyDesignee { get; set; }
        /// <summary>
        /// Third Party Designee informations
        /// </summary>
        public ThirdPartyDesignee ThirdPartyDesignee { get; set; }
        /// <summary>
        /// Signature Details informations
        /// </summary>
        public SignatureDetails SignatureDetails { get; set; }
        /// <summary>
        /// Business Status Details
        /// </summary>
        public BusinessStatusDetails BusinessStatusDetails { get; set; }

    }
}