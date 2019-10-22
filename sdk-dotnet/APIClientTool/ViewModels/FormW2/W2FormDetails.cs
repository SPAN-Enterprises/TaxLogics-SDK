namespace APIClientTool.ViewModels
{
    public class FormW2Details
    {
        #region Form Details
        /// <summary>
        /// Total taxable wages or salary, before any payroll deductions, that was paid to the employee during the year.
        /// </summary>
        
        public decimal Box1 { get; set; }
        /// <summary>
        /// Total federal income tax withheld from the employee's wages for the year. Include the 20% excise tax withheld on excess parachute payments.
        /// </summary>
        
        public decimal Box2 { get; set; }
        /// <summary>
        /// Total wages paid (before payroll deductions) subject to employee social security tax. 
        /// </summary>
        
        public decimal Box3 { get; set; }
        /// <summary>
        /// Total employee social security tax (not your share) withheld, including social security tax on tips.
        /// </summary>
        
        public decimal Box4 { get; set; }
        /// <summary>
        /// Medicare wages and tips reported. The wages and tips subject to Medicare tax are the same as those subject to social security tax except that there is no wage base limit for Medicare tax.
        /// </summary>
        
        public decimal Box5 { get; set; }
        /// <summary>
        /// Total employee Medicare tax (not your share) withheld.
        /// </summary>
        
        public decimal Box6 { get; set; }
        /// <summary>
        /// Tips that the employee reported to you even if you did not have enough employee funds to collect the social security tax for the tips.
        /// </summary>
        
        public decimal Box7 { get; set; }
        /// <summary>
        /// If you are a food or beverage establishment, show the tips allocated to the employee.
        /// </summary>
        
        public decimal Box8 { get; set; }

        /// <summary>
        /// 16 digit verification code given by the IRS to the Payroll Service Providers (PSPs) 
        /// </summary>
        
        public string Box9 { get; set; }
        /// <summary>
        /// Total amount of dependent care benefits that you paid or was incurred by you for your employee.
        /// </summary>
        
        public decimal Box10 { get; set; }
        /// <summary>
        /// Report distributions to an employee from a nonqualified plan
        /// </summary>
        
        public decimal Box11NonQualPlan { get; set; }
        /// <summary>
        /// Report distributions to an employee from a nongovernmental section 457(b) plan
        /// </summary>
        
        public decimal Box11NonSecPlan { get; set; }
        /// <summary>
        /// Box 12a Code
        /// </summary>
        
        public string Box12aCd { get; set; }
        /// <summary>
        /// Box 12a Amount
        /// </summary>
        
        public decimal Box12aAmt { get; set; }
        /// <summary>
        /// Box 12b Code
        /// </summary>
        
        public string Box12bCd { get; set; }
        /// <summary>
        /// Box 12b Amount
        /// </summary>
        
        public decimal Box12bAmt { get; set; }
        /// <summary>
        /// Box 12c Code
        /// </summary>
        
        public string Box12cCd { get; set; }

        /// <summary>
        /// Box 12c Amount
        /// </summary>
        
        public decimal Box12cAmt { get; set; }
        /// <summary>
        /// Box 12d Code
        /// </summary>
        
        public string Box12dCd { get; set; }

        /// <summary>
        /// Box 12d Amount
        /// </summary>
        
        public decimal Box12dAmt { get; set; }
        /// <summary>
        /// Statutory employees whose earnings are subject to social security and Medicare taxes but not subject to federal income tax withholding. Statutory employees are usually salespeople or other employees who work on commission. This will reflect whether the employee is a Statutory employee or not
        /// </summary>
        
        public bool Box13IsStatEmp { get; set; }
        /// <summary>
        /// This will show whether the employee is a member of a retirement plan or not.
        /// </summary>
        
        public bool Box13IsRetPlan { get; set; }
        /// <summary>
        /// This will show whether your business is reporting third-party sick pay or not
        /// </summary>
        
        public bool Box13Is3rdPartySickPay { get; set; }
        /// <summary>
        /// Any additional information of benefits the employer wants the employee to have and cannot be reported in boxes 1-13 can be listed here. Examples would be auto allowance, travel reimbursement, relocation expenses, job uniforms, after-tax employee contributions to an HSA, etc.
        /// </summary>
        
        public string Box14 { get; set; }

        #region State Details

        
        public string Box15State1Cd { get; set; }

        /// <summary>
        /// State 1 - Employer’s state ID number
        /// </summary>
        
        public string Box15State1IdNum { get; set; }

        /// <summary>
        /// State 1 - Wages, tips, etc
        /// </summary>
        
        public decimal Box16State1Wages { get; set; }

        /// <summary>
        /// State 1 - Income Tax
        /// </summary>
        
        public decimal Box17State1Tax { get; set; }

        /// <summary>
        /// State 1 - Local wages, tips, etc
        /// </summary>
        
        public decimal Box18Local1Wages { get; set; }

        /// <summary>
        /// State 1 - Local income tax
        /// </summary>
        
        public decimal Box19Local1Tax { get; set; }

        /// <summary>
        /// State 1 - Locality name
        /// </summary>
        
        public string Box20Locality1Nm { get; set; }

        //State 2
        
        public string Box15State2Cd { get; set; }

        /// <summary>
        /// State 2 - Employer’s state ID number
        /// </summary>
        
        public string Box15State2IdNum { get; set; }

        /// <summary>
        /// State 2 - Wages, tips, etc
        /// </summary>
        
        public decimal Box16State2Wages { get; set; }

        /// <summary>
        /// State 2 - Income Tax
        /// </summary>
        
        public decimal Box17State2Tax { get; set; }

        /// <summary>
        /// State 2 - Local wages, tips, etc
        /// </summary>
        
        public decimal Box18Local2Wages { get; set; }

        /// <summary>
        /// State 2 - Local income tax
        /// </summary>
        
        public decimal Box19Local2Tax { get; set; }

        /// <summary>
        /// State 2 - Locality name
        /// </summary>
        
        public string Box20Locality2Nm { get; set; }

        #endregion

        #endregion
    }
}
