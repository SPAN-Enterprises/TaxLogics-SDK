using System.Collections.Generic;

namespace APIClientTool.ViewModels.Form941CoreModel
{
    public class DepositScheduleType
    {
        /// <summary>
        /// Gets or sets the depositor type
        /// </summary>
        public string DepositorType { get; set; }
        /// <summary>
        /// Monthly depositor informations
        /// </summary>
        public MonthlyDepositor MonthlyDepositor { get; set; }
        /// <summary>
        /// Semiweekly depositor informations
        /// </summary>
        public SemiWeeklyDepositor SemiWeeklyDepositor { get; set; }
        /// <summary>
        /// Gets or sets the total tax liability amount
        /// </summary>
        /// <value>
        /// Total tax liability amount
        /// </value>
        public decimal TaxLiabilityTotalAmt { get; set; }
    }

    public class MonthlyDepositor
    {
        /// <summary>
        /// Gets or sets the Tax Liability amount for first Month
        /// </summary>
        public decimal TaxLiabilityMonth1 { get; set; }
        /// <summary>
        /// Gets or sets the Tax Liability amount for second Month
        /// </summary>
        public decimal TaxLiabilityMonth2 { get; set; }
        /// <summary>
        /// Gets or sets the Tax Liability amount for third Month
        /// </summary>
        public decimal TaxLiabilityMonth3 { get; set; }
    }

    public class SemiWeeklyDepositor
    {
        /// <summary>
        /// Gets or sets the first month amount for scheduleB
        /// </summary>
        public List<Form941ScheduleBMonth> ScheduleBMonth1Amt { get; set; }

        /// <summary>
        /// Gets or sets the second month amount for scheduleB
        /// </summary>
        public List<Form941ScheduleBMonth> ScheduleBMonth2Amt { get; set; }

        /// <summary>
        /// Gets or sets the third month amount for scheduleB
        /// </summary>
        public List<Form941ScheduleBMonth> ScheduleBMonth3Amt { get; set; }
    }

    public class Form941ScheduleBMonth
    {
        /// <summary>
        /// Gets or sets the day value of every month
        /// </summary>
        public DayOfMonth Day { get; set; }
        /// <summary>
        /// Gets or sets the amount for each day in semiweekly deposit
        /// </summary>
        public decimal Amt { get; set; }
    }


}