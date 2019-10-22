using System;

namespace APIClientTool.ViewModels
{
    public class Business
    {
        /// <summary>
        /// Gets or sets the business identifier.
        /// </summary>
        /// <value>
        /// Unique business identifier.
        /// </value>
        public Guid? BusinessId { get; set; }
        /// <summary>
        /// Gets or sets the name of the business.
        /// </summary>
        /// <value>
        /// The business name
        /// </value>
        public string BusinessNm { get; set; }
        /// <summary>
        /// Gets or sets the trade name (DBA) of the business.
        /// </summary>
        /// <value>
        /// The trade name (DBA) of the business.
        /// </value>
        public string TradeNm { get; set; }
        /// <summary>
        /// Gets or sets the IsEIN
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is ein; otherwise, <c>false</c>.
        /// </value>
        public bool IsEIN { get; set; }
        /// <summary>
        /// Gets or sets the Employer Identification Number or Social Security Number
        /// </summary>
        /// <value>
        /// Employer Identification Number or Social Security Number
        /// </value>
        public string EINorSSN { get; set; }
        /// <summary>
        /// Gets or sets the Employer's email address.
        /// </summary>
        /// <value>
        /// Employer's email address.
        /// </value>

        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the name of the person who could be contacted by the IRS if needed.
        /// </summary>
        /// <value>
        /// The contact name
        /// </value>
        public string ContactNm { get; set; }
        /// <summary>
        /// Gets or sets the Employer's phone number, including the area code.
        /// </summary>
        /// <value>
        /// Employer's phone number, including the area code.
        /// </value>
        public string Phone { get; set; }
        /// <summary>
        /// Gets or sets the Phone extension number.
        /// </summary>
        /// <value>
        /// Phone extension number.
        /// </value>
        public string PhoneExtn { get; set; }
        /// <summary>
        /// Gets or sets the emmployer's fax number.
        /// </summary>
        /// <value>
        /// Employer's Fax number.
        /// </value>
        public string Fax { get; set; }
        /// <summary>
        /// Get or sets the Type of business entity.
        /// </summary>
        /// <value>
        /// Type of business entity. The value must be ESTE, PART, CORP, EORG, SPRO.
        /// </value>
        public string BusinessType { get; set; }
        /// <summary>
        /// The information of person authorized to sign the return.
        /// </summary>
        /// <value>
        /// The signing authority.
        /// </value>
        public SigningAuthority SigningAuthority { get; set; }
        /// <summary>
        /// Gets or sets Employer Type.
        /// </summary>
        /// <value>
        /// Employer Type. The value must be FEDERALGOVT, STATEORLOCAL501C, NONGOVT501C, STATEORLOCALNON501C, NONEAPPLY.
        /// </value>
        public string KindOfEmployer { get; set; }
        /// <summary>
        /// Gets or sets the Kind Of Payer based on the Employer's Federal Tax Return.
        /// </summary>
        /// <value>
        /// Kind Of Payer. The value must be REGULAR941, REGULAR944, AGRICULTURAL943, HOUSEHOLD, MILITARY, MEDICAREQUALGOVEM, RAILROADFORMCT1.
        /// </value>
        public string KindOfPayer { get; set; }
        /// <summary>
        /// This Field is only for W2 Form
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is business terminated; otherwise, <c>false</c>.
        /// </value>
        public bool IsBusinessTerminated { get; set; }
        /// <summary>
        /// Gets or sets the IsForeign
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is foreign; otherwise, <c>false</c>.
        /// </value>
        public bool IsForeign { get; set; }
        /// <summary>
        /// US address informations
        /// </summary>
        /// <value>
        /// The us address.
        /// </value>
        public USAddress USAddress { get; set; }
        /// <summary>
        /// Foreign address informations
        /// </summary>
        /// <value>
        /// The foreign address.
        /// </value>
        public ForeignAddress ForeignAddress { get; set; }

    }

    public class USAddress
    {
        /// <summary>
        /// Employer/Payer address (street address or post office box for the employer/payer).
        /// </summary>
        public string Address1 { get; set; }
        /// <summary>
        /// The suite, apartment, number of the employer/payer, if applicable. This is optional.
        /// </summary>
        public string Address2 { get; set; }
        /// <summary>
        /// Employer/Payer city.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// State code of the employer/payer. Refer Static values.
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Employer/Payer ZIP Code.
        /// </summary>
        public string ZipCd { get; set; }
    }

    public class ForeignAddress
    {
        /// <summary>
        /// Employer/Payer address (street address or post office box for the employer/payer).
        /// </summary>

        public string Address1 { get; set; }

        /// <summary>
        /// The suite, apartment, number of the employer/payer, if applicable. This is optional.
        /// </summary>

        public string Address2 { get; set; }

        /// <summary>
        /// Employer/Payer city.
        /// </summary>

        public string City { get; set; }

        /// <summary>
        /// Employer/Payer province or state Name
        /// </summary>

        public string ProvinceOrStateNm { get; set; }

        /// <summary>
        /// Employer/Payer country code
        /// </summary>

        public string Country { get; set; }

        /// <summary>
        /// Employer/Payer Postal code
        /// </summary>

        public string PostalCd { get; set; }
    }

}
