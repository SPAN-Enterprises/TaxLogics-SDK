using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIClientTool.ViewModels.Form941CoreModel
{
    public class Form8974
    {
        /// <summary>
        /// Form8974 IncomeTax Details
        /// </summary>
        public List<Form8974IncomeTaxDetails> Form8974IncomeTaxDetails { get; set; }
        /// <summary>
        /// Gets or sets the line 7 amount
        /// </summary>
        public decimal? Line7 { get; set; }
        /// <summary>
        /// Gets or sets the line 8 amount
        /// </summary>
        public decimal? Line8 { get; set; }
        /// <summary>
        /// Gets or sets the line 9 amount
        /// </summary>
        public decimal? Line9 { get; set; }
        /// <summary>
        /// Gets or sets the line 10 amount
        /// </summary>
        public decimal? Line10 { get; set; }
        /// <summary>
        /// Gets or sets the line 11 amount
        /// </summary>
        public decimal? Line11 { get; set; }
        /// <summary>
        /// Gets or sets the payer indicator type
        /// </summary>
        public string PayerIndicatorType { get; set; }
        /// <summary>
        /// Gets or sets the line 12 amount
        /// </summary>
        public decimal? Line12 { get; set; }
    }

    public class Form8974IncomeTaxDetails
    {
        ///<summary>
        /// Gets or sets the income tax period end date
        ///</summary>
        public string IncomeTaxPeriodEndDate { get; set; }
        ///<summary>
        /// Gets or sets the income tax return filed form
        ///</summary>
        public string IncomeTaxReturnFiledForm { get; set; }
        ///<summary>
        /// Gets or sets the income tax return filed date
        ///</summary>
        public string IncomeTaxReturnFiledDate { get; set; }
        ///<summary>
        /// Gets or sets the form 6765 EIN
        ///</summary>
        public string Form6765EIN { get; set; }
        ///<summary>
        /// Gets or sets the form 6765 line44 amount
        ///</summary>
        public decimal Form6765Line44Amt { get; set; }
        ///<summary>
        /// Gets or sets the previous period remaing credit amount
        ///</summary>
        public decimal PreviousPeriodRemaingCreditAmt { get; set; }
        ///<summary>
        /// Gets or sets the remaining credit
        ///</summary>
        public decimal RemainingCredit { get; set; }
    }

}