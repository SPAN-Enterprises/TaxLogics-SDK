using APIClientTool.ViewModels.Form941CoreModel;
using System;

namespace APIClientTool.ViewModels.Form941
{
    public class Form941Data
    {
        /// <summary>
        /// Gets or sets the Record Id
        /// </summary>
        /// <value>
        /// Record Identifier
        /// </value>
        public Guid? RecordId { get; set; }
        /// <summary>
        /// This identifies the sequence on the record sent in the pay load. When errors occur we will send the errors attached to particular sequence. Leave it blank for Update API.
        /// </summary>
        /// <value>
        /// Sequence number of the record
        /// </value>
        public string Sequence { get; set; }
        /// <summary>
        /// Form 941 Return Header
        /// </summary>
        public Form941ReturnHeader ReturnHeader { get; set; }
        /// <summary>
        /// Form 941 Return Data
        /// </summary>
        public Form941ReturnData ReturnData { get; set; }
        /// <summary>
        /// Return Number from IRS
        /// </summary>
        public string ReturnNumber { get; set; }
    }

    public class Form941ReturnHeader
    {
        /// <summary>
        /// Gets or sets the Return Type
        /// </summary>
        /// <value>
        /// Return type
        /// </value>
        public string ReturnType { get; set; }
        /// <summary>
        ///  Gets or sets the form 941 tax year 
        /// </summary>
        /// <value>
        /// Form 941 taxyear 
        /// </value>
        public string TaxYr { get; set; }
        /// <summary>
        /// Gets or sets the form 941 quarter
        /// </summary>
        /// <value>
        /// Form 941 Filing Quarter
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
    
    public class Form941ReturnData
    {
        /// <summary>
        /// Form 941 
        /// </summary>
        public Form941Details Form941 { get; set; }
        /// <summary>
        /// IRS payment type
        /// </summary>
        public string IRSPaymentType { get; set; }
        /// <summary>
        /// IRS payment informations
        /// </summary>
        public IRSPayment IRSPayment { get; set; }
        /// <summary>
        /// Deposit schedule type informations
        /// </summary>
        public DepositScheduleType DepositScheduleType { get; set; }
    }

}