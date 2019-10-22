using APIClientTool.ViewModels.Form941CoreModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClientTool.ViewModels.Form941SCHR
{
    public class Form941ClientData
    {
        /// <summary>
        ///Client Sequence Identifier
        /// </summary>
        public string CSeqId { get; set; }
        /// <summary>
        /// ClientName
        /// </summary>
        public string ClientName { get; set; }
        /// <summary>
        /// Schedule R Column a - Client’s Employer identification number (EIN)
        /// </summary>
        public string ClientEIN { get; set; }
        /// <summary>
        /// Schedule R Column b -  of wages,tips, and other compensation (CPEO Use Only)
        /// </summary>
        public string WagesTypeCd { get; set; }
        /// <summary>
        /// Schedule R Column c - Wages, tips, and other compensatio
        /// </summary>
        public decimal WagesAmt { get; set; }
        /// <summary>
        /// Schedule R Column d - Federal income tax withheld from wages, tips, and other compensation
        /// </summary>
        public decimal FedIncomeTaxWHAmt { get; set; }
        /// <summary>
        /// WagesNotSubjToSSMedcrTaxInd
        /// </summary>
        public bool? WagesNotSubjToSSMedcrTaxInd { get; set; }
        /// <summary>
        /// Schedule R Column e - Total social security and Medicare taxes
        /// </summary>
        [JsonProperty(PropertyName = "TotSSMdcrTaxAmt")]
        public decimal Line5e { get; set; }
        /// <summary>
        /// Schedule R Column f - Section 3121(q) Notice and Demand-Tax due on unreported tips
        /// </summary>
        public decimal TaxOnUnreportedTips3121qAmt { get; set; }
        /// <summary>
        /// IsAdjustmentsForFractionOfCents
        /// </summary>
        [JsonIgnore]
        public bool IsAdjustmentsForFractionOfCents { get; set; }
        /// <summary>
        /// Schedule R Column g - Qualified small business payroll tax credit for increasing research
        /// </summary>
        [JsonProperty(PropertyName = "PayrollTaxCreditAmt")]
        public decimal Line11 { get; set; }
        /// <summary>
        /// Schedule R Column h - Total taxes after adjustments and credits
        /// </summary>
        [JsonProperty(PropertyName = "TotTaxAmt")]
        public decimal Line12 { get; set; }
        /// <summary>
        /// Schedule R Column g - Qualified small business payroll tax credit for increasing research
        /// </summary>
        public bool IsPayrollTaxCredit { get; set; }
        /// <summary>
        /// Schedule R Column g - Qualified small business payroll tax credit for increasing research
        /// </summary>
        public Form8974 Form8974 { get; set; }
        /// <summary>
        /// Schedule R Column i - Total deposits
        /// </summary>
        public decimal TotTaxDepositAmt { get; set; }
        /// <summary>
        /// Auto genrated and for further reference
        /// </summary>
        public Guid? CRecordId { get; set; }
        /// <summary>
        /// CreatedTS
        /// </summary>
        [JsonIgnore]
        public DateTime CreatedTS { get; set; }
        /// <summary>
        /// UpdatedTs
        /// </summary>
        [JsonIgnore]
        public DateTime UpdatedTs { get; set; }
    }
}
