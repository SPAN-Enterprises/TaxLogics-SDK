using System;
using System.ComponentModel.DataAnnotations;

namespace APIClientTool.ViewModels
{
    public enum StatusCode
    {
        Continue = 100,
        Success = 200,
        MultipleChoices = 300,
        BadRequest = 400,
        Unauthorized = 401,
        NotSufficient = 402,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowsed = 405,
        RequestLimitExceeded = 429,
        InternalServerError = 500,
        NotAvailable = 503
    }

    public class EntityBase
    {
        public DateTime CreatedTimeStamp { get; set; }
        public DateTime UpdatedTimeStamp { get; set; }
        public bool IsDeleted { get; set; }
    }

    #region Form 941
    public enum DayOfMonth
    {
        Day1 = 1,
        Day2 = 2,
        Day3 = 3,
        Day4 = 4,
        Day5 = 5,
        Day6 = 6,
        Day7 = 7,
        Day8 = 8,
        Day9 = 9,
        Day10 = 10,
        Day11 = 11,
        Day12 = 12,
        Day13 = 13,
        Day14 = 14,
        Day15 = 15,
        Day16 = 16,
        Day17 = 17,
        Day18 = 18,
        Day19 = 19,
        Day20 = 20,
        Day21 = 21,
        Day22 = 22,
        Day23 = 23,
        Day24 = 24,
        Day25 = 25,
        Day26 = 26,
        Day27 = 27,
        Day28 = 28,
        Day29 = 29,
        Day30 = 30,
        Day31 = 31
    }

    public enum ResponseStatusCode
    {
        [Display(Name = "Successful API call")]
        Ok = 200,
        [Display(Name = "Multiple statuses are available for the request.")]
        MultiStatus = 300,
        [Display(Name = "A validation error has occurred.")]
        BadRequest = 400,
        [Display(Name = "Invalid authorization credentials.")]
        Unauthorized = 401,
        [Display(Name = "The Credit in your account is not sufficient to transmit all requested records")]
        CreditsNotSufficient = 402,
        [Display(Name = "The request method (POST or GET) is not allowed on the requested resource")]
        MethodNotAllowed = 405,
        [Display(Name = "The resource you have specified cannot be found")]
        NotFound = 404,
        [Display(Name = "The API rate limit for your organisation/application has been exceeded")]
        RequestLimitExceeded = 426,
        [Display(Name = "Some error occurred with this API call. Please contact system administrator")]
        InternalServerError = 500,
        [Display(Name = "API is currently unavailable – typically due to a scheduled outage – try again soon.")]
        NotAvailable = 503
    }

    public enum TaxLogicsEfileStatus
    {
        [Display(Name = "Blank")]
        BLANK,
        [Display(Name = "Created")]
        CREATED,
        [Display(Name = "Transmitted")]
        TRANSMITTED,
        [Display(Name = "Under Process")]
        UNDERPROCESS,
        [Display(Name = "Sent To Agency")]
        SENTTOAGENCY,
        [Display(Name = "Accepted")]
        ACCEPTED,
        [Display(Name = "Rejected")]
        REJECTED,
        [Display(Name = "Partially Transmitted")]
        PARTIALLYTRANSMITTED,
        [Display(Name = "Partially e-Filed")]
        PARTIALLYEFILED,
        [Display(Name = "Completed")]
        COMPLETED,
        [Display(Name = "State Filing Order Recieved")]
        STATEEFILESTATUSRECIEVED,
        [Display(Name = "State Filing Completed")]
        STATEEFILESTATUSCOMPLETED,
        INIT,
        [Display(Name = "Cancelled")]
        CANCELLED
    }

    public enum DepositorType
    {
        [Display(Name = "Monthly Depositor")]
        MONTHLY,
        [Display(Name = "Semiweekly Depositor")]
        SEMIWEEKLY,
        [Display(Name = "Tax Liability less than $2,500.00")]
        MINTAXLIABILITY
    }

    public enum BusinessChangeType
    {
        [Display(Name = "Closed or Stopped")]
        CLOSEDORSTOPED,
        [Display(Name = "Sold or Transferred")]
        SOLDORTRANSFERRED,
        [Display(Name = "No")]
        NO
    }

    public enum Form941BusinessTransfer
    {
        SALE,
        TRANSFERRED
    }

    public enum BusinessType
    {
        [Display(Name = "Estate")]
        ESTE = 1,
        [Display(Name = "Partnership")]
        PART = 2,
        [Display(Name = "Corporation")]
        CORP = 3,
        [Display(Name = "Exempt Organization")]
        EORG = 4,
        [Display(Name = "Sole Proprietorship")]
        SPRO = 5
    }

    public enum EstateBusinessMembers
    {
        [Display(Name = "Administrator")]
        ADMINISTRATOR = 1,
        [Display(Name = "Executor")]
        EXECUTOR = 2,
        [Display(Name = "Trustee")]
        TRUSTEE = 3,
        [Display(Name = "Fiduciary")]
        FIDUCIARY = 4
    }

    public enum PartnershipBusinessMembers
    {
        [Display(Name = "Partner")]
        PARTNER = 5,
        [Display(Name = "General Partner")]
        GENERALPARTNER = 6,
        [Display(Name = "Limited Partner")]
        LIMITEDPARTNER = 7,
        [Display(Name = "LLC Member")]
        LLCMEMBER = 8,
        [Display(Name = "Manager")]
        MANAGINGMEMBER = 9,
        [Display(Name = "Member")]
        MEMBER = 10,
        [Display(Name = "Managing Member")]
        MANAGER = 11,
        [Display(Name = "President")]
        PRESIDENT = 12,
        [Display(Name = "Owner")]
        OWNER = 13,
        [Display(Name = "Tax Matter Partner")]
        TAXMATTERPARTNER = 14,
    }

    public enum CorporationBusinessMembers
    {
        [Display(Name = "President")]
        PRESIDENT = 15,
        [Display(Name = "Vice President")]
        VICEPRESIDENT = 16,
        [Display(Name = "Treasurer")]
        TREASURER = 17,
        [Display(Name = "Assistant Treasurer")]
        ASSISTANTTREASURER = 18,
        [Display(Name = "Chief Accounting Officer")]
        CHIEFACCOUNTINGOFFICER = 19,
        [Display(Name = "Tax Officer")]
        TAXOFFICER = 20,
        [Display(Name = "Chief Operating Officer")]
        CHIEFOPERATINGOFFICER = 21,
        [Display(Name = "Corporate Secretary")]
        CORPORATESECRETARY = 22,
        [Display(Name = "Secretary")]
        SECRETARY = 23,
        [Display(Name = "Secretary Treasurer")]
        SECRETARYTREASURER = 24,
        [Display(Name = "Corporate Officer")]
        CORPORATEOFFICER = 25,
        [Display(Name = "Member")]
        MEMBER = 26
    }

    public enum ExemptOrganizationBusinessMembers
    {
        [Display(Name = "President")]
        PRESIDENT = 26,
        [Display(Name = "Vice President")]
        VICEPRESIDENT = 27,
        [Display(Name = "Corporate Treasurer")]
        CORPORATETREASURER = 28,
        [Display(Name = "Treasurer")]
        TREASURER = 29,
        [Display(Name = "Assistant Treasurer")]
        ASSISTANTTREASURER = 30,
        [Display(Name = "Chief accounting Officer")]
        CHIEFACCOUNTINGOFFICER = 31,
        [Display(Name = "Chief executive Officer")]
        CHIEFEXECUTIVEOFFICER = 32,
        [Display(Name = "Chief financial Officer")]
        CHIEFFINANCIALOFFICER = 33,
        [Display(Name = "Tax Officer")]
        TAXOFFICER = 34,
        [Display(Name = "Chief Operating Officer")]
        CHIEFOPERATINGOFFICER = 35,
        [Display(Name = "Corporate Officer")]
        CORPORATEOFFICER = 36,
        [Display(Name = "Executive Director")]
        EXECUTIVEDIRECTOR = 37,
        [Display(Name = "Director")]
        DIRECTOR = 38,
        [Display(Name = "Chairman")]
        CHAIRMAN = 39,
        [Display(Name = "Executive Administrator")]
        EXECUTIVEADMINISTRATOR = 40,
        [Display(Name = "Administrator")]
        ADMINISTRATOR = 41,
        [Display(Name = "Receiver")]
        RECEIVER = 42,
        [Display(Name = "Trustee")]
        TRUSTEE = 43,
        [Display(Name = "Pastor")]
        PASTOR = 44,
        [Display(Name = "Assistant to Religious Leader")]
        ASSISTANTTORELIGIOUSLEADER = 45,
        [Display(Name = "Reverend")]
        REVEREND = 46,
        [Display(Name = "Priest")]
        PRIEST = 47,
        [Display(Name = "Minister")]
        MINISTER = 48,
        [Display(Name = "Rabbi")]
        RABBI = 49,
        [Display(Name = "Leader of Religious Organization")]
        LEADEROFRELIGIOUSORGANIZATION = 50,
        [Display(Name = "Secretary")]
        SECRETARY = 51,
        [Display(Name = "Director of Taxation")]
        DIRECTOROFTAXATION = 52,
        [Display(Name = "Director of Personnel")]
        DIRECTOROFPERSONNEL = 53
    }

    public enum SoleProprietorshipBusinessMembers
    {
        [Display(Name = "Owner")]
        OWNER = 54,
        [Display(Name = "Sole Poprietor")]
        SOLEPROPRIETOR = 55,
        [Display(Name = "Member")]
        MEMBER = 56,
        [Display(Name = "Sole Member")]
        SOLEMEMBER = 57
    }

    public enum FormType
    {
        [Display(Name = "Form W-2")]
        FormW2 = 4,
        [Display(Name = "Form 941")]
        Form941 = 14,
        [Display(Name = "Form 941-SCHR")]
        Form941SCHR = 21,
    }

    public enum SignatureType
    {
        [Display(Name = "Online Signature PIN")]
        ONLINE_SIGN_PIN,
        [Display(Name = "Reporting Agent PIN")]
        REPORTING_AGENT,
        [Display(Name = "Form 8453")]
        FORM_8453_EMP
      
    }

    public enum FilerType
    {
        [Display(Name = "SECTION 3504 AGENT")]
        SECTION3504AGENT,
        [Display(Name = "CPEO")]
        CPEO
    }

    public enum Form8974PayerIndicatorType
    {
        
        THIRDPARTYSICKPAYIND,
        SECTION3121QIND
    }

    public enum DepositorScheduleType
    {
        MINTAXLIABILITY,
        MONTHLY,
        SEMIWEEKLY
    }

    #endregion

}
