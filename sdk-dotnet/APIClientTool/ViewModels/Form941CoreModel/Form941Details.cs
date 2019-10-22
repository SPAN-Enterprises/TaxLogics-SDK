using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClientTool.ViewModels.Form941CoreModel
{
    public class Form941Details
    { 
        /// <summary>
        ///  Gets or sets the employee count
        /// </summary>
        /// <value>
        /// Employee Count
        /// </value>
        public int EmployeeCnt { get; set; }
        /// <summary>
        /// Gets or sets the Wages Amount
        /// </summary>
        /// <value>
        /// Wages Amount
        /// </value>
        public decimal WagesAmt { get; set; }
        /// <summary>
        /// Gets or sets the Federal Income Tax Withheld Amount
        /// </summary>
        /// <value>
        /// Federal Income Tax Withheld Amount
        /// </value>
        public decimal FedIncomeTaxWHAmt { get; set; }
        /// <summary>
        /// Gets or sets the wages is subjected to social security and medicare tax or not
        /// </summary>
        /// <value>
        /// Wages subjected to social security and medicare tax
        /// </value>
        public bool? WagesNotSubjToSSMedcrTaxInd { get; set; }
        /// <summary>
        /// Gets or sets the Line5a Initial Amount
        /// </summary>
        /// <value>
        /// Line5a Initial Amount
        /// </value>
        [JsonProperty(PropertyName = "SocialSecurityTaxCashWagesAmt_Col1")]
        public decimal Line5aInitialAmt { get; set; }
        /// <summary>
        /// Gets or sets the Line5b Initial Amount
        /// </summary>
        /// <value>
        /// Line5b Initial Amount
        /// </value>
        [JsonProperty(PropertyName = "TaxableSocSecTipsAmt_Col1")]
        public decimal Line5bInitialAmt { get; set; }
        /// <summary>
        /// Gets or sets the Line5c Initial Amount
        /// </summary>
        /// <value>
        /// Line5c Initial Amount
        /// </value>
        [JsonProperty(PropertyName = "TaxableMedicareWagesTipsAmt_Col1")]
        public decimal Line5cInitialAmt { get; set; }
        /// <summary>
        /// Gets or sets the Line5d Initial Amount
        /// </summary>
        /// <value>
        /// Line5d Initial Amount
        /// </value>
        [JsonProperty(PropertyName = "TxblWageTipsSubjAddnlMedcrAmt_Col1")]
        public decimal Line5dInitialAmt { get; set; }
        /// <summary>
        /// Gets or sets the Line5a calculated Amount
        /// </summary>
        /// <value>
        /// Line5a calculated Amount
        /// </value>
        [JsonProperty(PropertyName = "SocialSecurityTaxAmt_Col2")]
        public decimal Line5a { get; set; }
        /// <summary>
        /// Gets or sets the Line5b calculated Amount
        /// </summary>
        /// <value>
        /// Line5b calculated Amount
        /// </value>
        [JsonProperty(PropertyName = "TaxOnSocialSecurityTipsAmt_Col2")]
        public decimal Line5b { get; set; }
        /// <summary>
        /// Gets or sets the Line5c calculated Amount
        /// </summary>
        /// <value>
        /// Line5c calculated Amount
        /// </value>
        [JsonProperty(PropertyName = "TaxOnMedicareWagesTipsAmt_Col2")]
        public decimal Line5c { get; set; }
        /// <summary>
        /// Gets or sets the Line5d calculated Amount
        /// </summary>
        /// <value>
        /// Line5d calculated Amount
        /// </value>
        [JsonProperty(PropertyName = "TaxOnWageTipsSubjAddnlMedcrAmt_Col2")]
        public decimal Line5d { get; set; }
        /// <summary>
        /// Gets or sets the Line5e calculated Amount
        /// </summary>
        /// <value>
        /// Line5e calculated Amount
        /// </value>
        [JsonProperty(PropertyName = "TotSSMdcrTaxAmt")]
        public decimal Line5e { get; set; }
        /// <summary>
        /// Gets or sets the tax on unreported tips 3121qAmt
        /// </summary>
        /// <value>
        /// Tax on unreported Tips 3121qAmt
        /// </value>
        public decimal TaxOnUnreportedTips3121qAmt { get; set; }
        /// <summary>
        /// Gets or sets total tax before adjustments value
        /// </summary>
        /// <value>
        /// Total tax before adjustments value
        /// </value>
        [JsonProperty(PropertyName = "TotalTaxBeforeAdjustmentAmt")]
        public decimal Line6 { get; set; }
        /// <summary>
        /// Gets or sets the current quarter fraction of cents amount
        /// </summary>
        /// <value>
        /// Current quarter fraction of cents amount
        /// </value>
        public decimal CurrentQtrFractionsCentsAmt { get; set; }
        /// <summary>
        /// Gets or sets the current quarter sick payment amount
        /// </summary>
        ///   /// <value>
        /// Current quarter sick payment amount
        /// </value>
        public decimal CurrentQuarterSickPaymentAmt { get; set; }
        /// <summary>
        /// Gets or sets the current quarter group term life insurance amount
        /// </summary>
        ///   /// <value>
        /// Current quarter group term life insurance amount
        /// </value>
        public decimal CurrQtrTipGrpTermLifeInsAdjAmt { get; set; }
        /// <summary>
        /// Gets or sets the line 10 amount
        /// </summary>
        [JsonProperty(PropertyName = "TotalTaxAfterAdjustmentAmt")]
        public decimal Line10 { get; set; }
        /// <summary>
        /// Gets or sets the line 11 amount
        /// </summary>
        /// <value>
        /// Line 11 amount
        /// </value>
        [JsonProperty(PropertyName = "PayrollTaxCreditAmt")]
        public decimal Line11 { get; set; }
        /// <summary>
        /// Gets or sets the line 12 amount
        /// </summary>
        /// <value>
        /// Line 12 amount
        /// </value>
        [JsonProperty(PropertyName = "TotTaxAmt")]
        public decimal Line12 { get; set; }
        /// <summary>
        /// Gets or sets is Payroll Tax Credit applied or not
        /// </summary>
        public bool IsPayrollTaxCredit { get; set; }
        /// <summary>
        /// Form 8974 informations
        /// </summary>
        public Form8974 Form8974 { get; set; }
        /// <summary>
        /// Gets or sets the Total Tax Deposit Amount
        /// </summary>
        /// <value>
        /// Total tax deposit amount
        /// </value>
        public decimal TotTaxDepositAmt { get; set; }
        /// <summary>
        /// Gets or sets balance due amount
        /// </summary>
        /// <value>
        /// Balance due amount
        /// </value>
        [JsonProperty(PropertyName = "BalanceDueAmt")]
        public decimal Line14 { get; set; }
        /// <summary>
        /// Gets or sets over payment amount
        /// </summary>
        /// <value>
        /// Over payment mount
        /// </value>
        [JsonProperty(PropertyName = "OverpaidAmt")]
        public decimal Line15 { get; set; }
        /// <summary>
        /// Gets or sets over payment recovery type
        /// </summary>
        /// <value>
        /// Over payment recovery type
        /// </value>
        public string OverPaymentRecoveryType { get; set; }
        /// <summary>
        /// Gets or sets over Filer Type
        /// </summary>
        /// <value>
        /// Filer Type
        /// </value>
        public string FilerType { get; set; }

    }
}