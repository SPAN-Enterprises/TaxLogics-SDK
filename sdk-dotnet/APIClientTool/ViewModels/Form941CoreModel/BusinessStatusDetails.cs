using System;

namespace APIClientTool.ViewModels.Form941CoreModel
{
    public class BusinessStatusDetails
    {
        /// <summary>
        /// Gets or sets the IsBusinessClosed
        /// </summary>
        public bool IsBusinessClosed { get; set; }
        /// <summary>
        /// Business Closed Details
        /// </summary>
        public BusinessClosedDetails BusinessClosedDetails { get; set; }
        /// <summary>
        /// Gets or sets the IsBusinessTransferred
        /// </summary>
        public bool IsBusinessTransferred { get; set; }
        /// <summary>
        /// Business Transferred Details
        /// </summary>
        public BusinessTransferredDetails BusinessTransferredDetails { get; set; }
        /// <summary>
        /// Gets or sets the IsSeasonalEmployer
        /// </summary>
        public bool IsSeasonalEmployer { get; set; }

       

    }

    #region BusinessClosed
    /// <summary>
    /// Business Closed Details
    /// </summary>
    public class BusinessClosedDetails
    {
        /// <summary>
        /// Name of the business
        /// </summary>
        
        public string Name { get; set; }

        /// <summary>
        /// Final Date Wages Paid
        /// </summary>
        
        public DateTime? FinalDateWagesPaid { get; set; }

        /// <summary>
        /// IsForeign
        /// </summary>
        
        public bool IsForeign { get; set; }

        /// <summary>
        /// US Address informations
        /// </summary>
        
        public USAddress USAddress { get; set; }

        /// <summary>
        /// Foreign Address informations
        /// </summary>
        
        public ForeignAddress ForeignAddress { get; set; }


    }
    #endregion

    #region BusinessTransferred
    /// <summary>
    /// Business Transferred Details
    /// </summary>
    public class BusinessTransferredDetails
    {
        /// <summary>
        /// Name of the business
        /// </summary>
        
        public string Name { get; set; }

        /// <summary>
        /// Business changed type
        /// </summary>
        
        public string BusinessChangeType { get; set; }

        /// <summary>
        /// Date Of business Changed
        /// </summary>
        
        public DateTime? DateOfChange { get; set; }

        /// <summary>
        /// New business type 
        /// </summary>
        
        public string NewBusinessType { get; set; }

        /// <summary>
        /// Name of the new business
        /// </summary>
        
        public string NewBusinessName { get; set; }

        /// <summary>
        /// Gets or sets the IsForeign
        /// </summary>
        
        public bool IsForeign { get; set; }

        /// <summary>
        /// US Address informations
        /// </summary>
        
        public USAddress USAddress { get; set; }

        /// <summary>
        /// Foreign Address informations
        /// </summary>
        
        public ForeignAddress ForeignAddress { get; set; }

        public bool IsSale { get; set; }
        /// <summary>
        /// Gets or sets the IsSale
        /// </summary>
    }
    #endregion

}