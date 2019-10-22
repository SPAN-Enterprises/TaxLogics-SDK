using System.Collections.Generic;
using APIClientTool.ViewModels.Form941CoreModel;
namespace APIClientTool.ViewModels.Form941SCHR
{
    public class Form941SchRReturnData
    {
        /// <summary>
        /// Form 941 Main Filer Data
        /// </summary>
        public Form941MainFilerData Form941MainFilerData { get; set; }
        /// <summary>
        ///  Gets or sets Form 941 Details
        /// </summary>
        /// <value>
        /// Aggregate Form 941 Data
        /// </value>
        public Form941Details AggregateForm941Data { get; set; }
        /// <summary>
        /// IRS payment type
        /// </summary>
        public object IRSPaymentType { get; set; }
        /// <summary>
        /// IRS payment informations
        /// </summary>
        public IRSPayment IRSPayment { get; set; }
        /// <summary>
        /// Deposit schedule type informations
        /// </summary>
        public DepositScheduleType DepositScheduleType { get; set; }
        /// <summary>
        /// Form 941 Details of each client. (For Schedule R)
        /// </summary>
        //Required Only For SCHR
        public List<Form941ClientData> Form941ClientDetails { get; set; }
    }
}