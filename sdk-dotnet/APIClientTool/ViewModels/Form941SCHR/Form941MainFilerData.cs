using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIClientTool.ViewModels.Form941CoreModel;

namespace APIClientTool.ViewModels.Form941SCHR
{
    public class Form941MainFilerData
    {
        /// <summary>
        /// Gets or sets WagesAmt
        /// </summary>
        public decimal WagesAmt { get; set; }
        /// <summary>
        /// Gets or sets FedIncomeTaxWHAmt
        /// </summary>
        public decimal FedIncomeTaxWHAmt { get; set; }
        /// <summary>
        /// Gets or sets TotSSMdcrTaxAmt
        /// </summary>
        public decimal TotSSMdcrTaxAmt { get; set; }
        /// <summary>
        /// Gets or sets Wages Amt
        /// </summary>
        public decimal TaxOnUnreportedTips3121qAmt { get; set; }
        /// <summary>
        /// Gets or sets PayrollTaxCreditAmt
        /// </summary>
        public decimal PayrollTaxCreditAmt { get; set; }
        /// <summary>
        /// TotTaxAmt
        /// </summary>
        public decimal TotTaxAmt { get; set; }
        /// <summary>
        /// Gets or sets IsPayrollTaxCredit
        /// </summary>
        public bool IsPayrollTaxCredit { get; set; }
        /// <summary>
        /// Gets or sets Form8974
        /// </summary>
        public Form8974 Form8974 { get; set; }
        /// <summary>
        /// Gets or sets TotTaxDepositAmt
        /// </summary>
        public decimal TotTaxDepositAmt { get; set; }

        public decimal? Line5e { get; set; }
        /// <summary>
        /// Gets or sets the line 8 amount
        /// </summary>
        /// 
        public decimal? Line11 { get; set; }
        /// <summary>
        /// Gets or sets the line 8 amount
        /// </summary>
        /// 
        public decimal? Line12 { get; set; }
        /// <summary>
        /// Gets or sets the line 8 amount
        /// </summary>
    }
}