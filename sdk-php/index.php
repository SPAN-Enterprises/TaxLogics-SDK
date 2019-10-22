<!DOCTYPE html>
<html>

<meta http-equiv="content-type" content="text/html;charset=utf-8"/>
<head>

    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>FormW2 Return</title>

    <script src="http://apiclient.taxvari.com/bundles/jquery?v=MRjVrMuK9DXe6nW0tFmw9cj1pT5oo4Jf-eJQmGfwEF01"></script>

    <script src="http://apiclient.taxvari.com/bundles/bootstrap?v=-g7cxTWQV6ve_iRyKtg7LoBytQltgj_w8zTNeaLaBc41"></script>

    <link href="http://apiclient.taxvari.com/Content/css?v=LUJ4d8snobbjVqJ-k1JMBOZdx-2KR1NmgrIYGvdx8YA1"
          rel="stylesheet"/>

    <script src="http://apiclient.taxvari.com/bundles/modernizr?v=w9fZKPSiHtN4N4FRqV7jn-3kGoQY5hHpkwFv5TfMrus1"></script>

    <link href="Content/Site.css" rel="stylesheet"/>
    <link href="Content/font-awesome.css" rel="stylesheet"/>
    <link href="Content/toastr.html" rel="stylesheet"/>
    <script src="Scripts/toastr.js"></script>

    <link rel="icon" href="http://apiclient.taxvari.com/Content/Images/favicon.ico" type="image/x-icon">
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600,600italic,700,800italic,800,700italic'
          rel='stylesheet' type='text/css'>

</head>
<body>
<header class="navbar navbar-fixed-top">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
        </div>
        <div class="navbar-collapse collapse">
            <div class="row">
                <div class="col-md-4">
                    <img src="Content/Images/logoHead.png"/>
                </div>
                <div class="col-md-8 floatR">
                    <a href="tel:7046844751" class="linkText floatR">
                        <img src="Content/Images/phone_icon.png" alt="" title=""/>
                        704.684.4751
                    </a>
                    <ul class="nav navbar-nav nav_menu floatR">
                        <li class="active"><a href="index.php">Create Return</a></li>
                        <li><a href="w2validate.php">Validate & Transmit Return </a></li>

                    </ul>
                    <div class="clearfix"></div>
                </div>
            </div>
            <div class="clearfix"></div>
        </div>
    </div>
</header>
<div class="clearfix"></div>
<div class="clearfix"></div>
<div class="body-content container">

    <div class="col-md-12 col-lg-12">
        <form action="createForm.php" method="post">
            <h1 class="pageTitle">Form W-2</h1>
            <div class="panel-group" id="accordion">
                <div class="panel panel-default">
                    <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapse1">
                        <h4 class="panel-title">
                            Employer Details
                        </h4>
                    </div>
                    <div id="collapse1" class="panel-collapse collapse in">
                        <div class="panel-body">
                            <table class="responsive">
                                <tr>
                                    <td class="labelName"><label class="control-label">Employer Name:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Business_BusinessNm"
                                                                 name="BusinessNm" type="text"
                                                                 value="API Client Tool Team"/></td>
                                    <td class="labelName"><label class="control-label">Employer Type:</label></td>
                                    <td>
                                        <select class="form-control" id="BusinessType" name="BusinessType">
                                            <option value="">Select Employer Type</option>
                                            <option selected="selected" value="ESTE">Estate</option>
                                            <option value="PART">Partnership</option>
                                            <option value="CORP">Corporation</option>
                                            <option value="EORG">Exempt Organization</option>
                                            <option value="SPRO">Sole Proprietorship</option>
                                        </select>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">EIN:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Business_EIN" name="EIN"
                                                                 type="text" value="985407436"/></td>
                                    <td class="labelName"><label class="control-label">Address Line1:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Business_Address1"
                                                                 name="Address1" type="text"
                                                                 value="109 Pangbourne Way"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>

                                <tr>
                                    <td class="labelName"><label class="control-label">Address Line2:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Business_Address2"
                                                                 name="Address2" type="text" value=""/></td>
                                    <td class="labelName"><label class="control-label">City:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Business_City" name="City"
                                                                 type="text" value="Hanover"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">State:</label></td>
                                    <td>
                                        <select class="form-control" id="USState" name="USState">
                                            <option value="">Select State</option>
                                            <option value="AL">Alabama (AL)</option>
                                            <option value="AK">Alaska (AK)</option>
                                            <option value="AZ">Arizona (AZ)</option>
                                            <option value="AR">Arkansas (AR)</option>
                                            <option value="CA">California (CA)</option>
                                            <option value="CO">Colorado (CO)</option>
                                            <option value="CT">Connecticut (CT)</option>
                                            <option value="DE">Delaware (DE)</option>
                                            <option value="DC">District of Columbia (DC)</option>
                                            <option value="FL">Florida (FL)</option>
                                            <option value="GA">Georgia (GA)</option>
                                            <option value="HI">Hawaii (HI)</option>
                                            <option value="ID">Idaho (ID)</option>
                                            <option value="IL">Illinois (IL)</option>
                                            <option value="IN">Indiana (IN)</option>
                                            <option value="IA">Iowa (IA)</option>
                                            <option value="KS">Kansas (KS)</option>
                                            <option value="KY">Kentucky (KY)</option>
                                            <option value="LA">Louisiana (LA)</option>
                                            <option value="ME">Maine (ME)</option>
                                            <option selected="selected" value="MD">Maryland (MD)</option>
                                            <option value="MA">Massachusetts (MA)</option>
                                            <option value="MI">Michigan (MI)</option>
                                            <option value="MN">Minnesota (MN)</option>
                                            <option value="MS">Mississippi (MS)</option>
                                            <option value="MO">Missouri (MO)</option>
                                            <option value="MT">Montana (MT)</option>
                                            <option value="NE">Nebraska (NE)</option>
                                            <option value="NV">Nevada (NV)</option>
                                            <option value="NH">New Hampshire (NH)</option>
                                            <option value="NJ">New Jersey (NJ)</option>
                                            <option value="NM">New Mexico (NM)</option>
                                            <option value="NY">New York (NY)</option>
                                            <option value="NC">North Carolina (NC)</option>
                                            <option value="ND">North Dakota (ND)</option>
                                            <option value="OH">Ohio (OH)</option>
                                            <option value="OK">Oklahoma (OK)</option>
                                            <option value="OR">Oregon (OR)</option>
                                            <option value="PA">Pennsylvania (PA)</option>
                                            <option value="RI">Rhode Island (RI)</option>
                                            <option value="SC">South Carolina (SC)</option>
                                            <option value="SD">South Dakota (SD)</option>
                                            <option value="TN">Tennessee (TN)</option>
                                            <option value="TX">Texas (TX)</option>
                                            <option value="UT">Utah (UT)</option>
                                            <option value="VT">Vermont (VT)</option>
                                            <option value="VA">Virginia (VA)</option>
                                            <option value="WA">Washington (WA)</option>
                                            <option value="WV">West Virginia (WV)</option>
                                            <option value="WI">Wisconsin (WI)</option>
                                            <option value="WY">Wyoming (WY)</option>
                                            <option value="AS">American Samoa (AS)</option>
                                            <option value="FM">Federated States of Micronesia (FM)</option>
                                            <option value="GU">Guam (GU)</option>
                                            <option value="MH">Marshall Islands (MH)</option>
                                            <option value="MP">Northern Mariana Islands (MP)</option>
                                            <option value="PW">Palau (PW)</option>
                                            <option value="PR">Puerto Rico (PR)</option>
                                            <option value="VI">Virgin Islands (VI)</option>
                                            <option value="AA">Armed Forces Americas (AA)</option>
                                            <option value="AE">Armed Forces Europe (AE)</option>
                                            <option value="AP">Armed Forces Pacific (AP)</option>
                                        </select>
                                    </td>
                                    <td class="labelName"><label class="control-label">Zip Code:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Business_USZip" name="USZip"
                                                                 type="text" value="21076"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>

                                <tr>
                                    <td class="labelName"><label class="control-label">Country:</label></td>
                                    <td>
                                        <select class="form-control" id="Country" name="Country">
                                            <option value="">Select Country</option>
                                            <option value="AF">Afghanistan</option>
                                            <option value="AX">Akrotiri</option>
                                            <option value="XI">Aland Island</option>
                                            <option value="AL">Albania</option>
                                            <option value="AG">Algeria</option>
                                            <option value="AQ">American Samoa</option>
                                            <option value="AN">Andorra</option>
                                            <option value="AO">Angola</option>
                                            <option value="AV">Anguilla</option>
                                            <option value="AY">Antarctica</option>
                                            <option value="AC">Antigua and Barbuda</option>
                                            <option value="AR">Argentina</option>
                                            <option value="AM">Armenia</option>
                                            <option value="AA">Aruba</option>
                                            <option value="XA">Ascension</option>
                                            <option value="AT">Ashmore and Cartier Islands</option>
                                            <option value="AS">Australia</option>
                                            <option value="AU">Austria</option>
                                            <option value="AJ">Azerbaijan</option>
                                            <option value="XZ">Azores</option>
                                            <option value="BF">Bahamas</option>
                                            <option value="BA">Bahrain</option>
                                            <option value="FQ">Baker Islands</option>
                                            <option value="BG">Bangladesh</option>
                                            <option value="BB">Barbados</option>
                                            <option value="BS">Bassas da India</option>
                                            <option value="BO">Belarus</option>
                                            <option value="BE">Belgium</option>
                                            <option value="BH">Belize</option>
                                            <option value="BN">Benin</option>
                                            <option value="BD">Bermuda</option>
                                            <option value="BT">Bhutan</option>
                                            <option value="BL">Bolivia</option>
                                            <option value="BK">Bosnia - Herzegovina</option>
                                            <option value="BC">Botswana</option>
                                            <option value="BV">Bouvet Island</option>
                                            <option value="BR">Brazil</option>
                                            <option value="IO">British Indian OceanTerritory</option>
                                            <option value="VI">British Virgin Islands</option>
                                            <option value="BX">Brunei</option>
                                            <option value="BU">Bulgaria</option>
                                            <option value="UV">Burkina Faso</option>
                                            <option value="BM">Burma</option>
                                            <option value="BY">Burundi</option>
                                            <option value="CB">Cambodia</option>
                                            <option value="CM">Cameroon</option>
                                            <option value="CA">Canada</option>
                                            <option value="XY">Canary Islands</option>
                                            <option value="CV">Cape Verde</option>
                                            <option value="CJ">Cayman Islands</option>
                                            <option value="CT">Central African Republic</option>
                                            <option value="CD">Chad</option>
                                            <option value="XC">Channel Islands</option>
                                            <option value="CI">Chile</option>
                                            <option value="CH">China</option>
                                            <option value="KT">Christmas Island</option>
                                            <option value="IP">Clipperton Island</option>
                                            <option value="CK">Cocos(Keeling) Islands</option>
                                            <option value="CO">Colombia</option>
                                            <option value="CN">Comoros</option>
                                            <option value="CF">Congo(Brazzaville)</option>
                                            <option value="CG">Congo(Kinshasa)</option>
                                            <option value="CW">Cook Islands</option>
                                            <option value="CR">Coral Sea Islands</option>
                                            <option value="VP">Corsica</option>
                                            <option value="CS">Costa Rica</option>
                                            <option value="IV">Cote D&#39;Ivoire (IvoryCoast)</option>
                                            <option value="HR">Croatia</option>
                                            <option value="CU">Cuba</option>
                                            <option value="CY">Cyprus</option>
                                            <option value="EZ">Czech Republic</option>
                                            <option value="DA">Denmark</option>
                                            <option value="DX">Dhekelia</option>
                                            <option value="DJ">Djibouti</option>
                                            <option value="DO">Dominica</option>
                                            <option value="DR">Dominican Republic</option>
                                            <option value="TT">East Timor</option>
                                            <option value="EC">Ecuador</option>
                                            <option value="EG">Egypt</option>
                                            <option value="ES">El Salvador</option>
                                            <option value="UK">England</option>
                                            <option value="EK">Equatorial Guinea</option>
                                            <option value="ER">Eritrea</option>
                                            <option value="EN">Estonia</option>
                                            <option value="ET">Ethiopia</option>
                                            <option value="EU">Europa Island</option>
                                            <option value="FK">Falkland Islands(Islas Malvinas)</option>
                                            <option value="FO">Faroe Islands</option>
                                            <option value="FM">Federated States of Micronesia</option>
                                            <option value="FJ">Fiji</option>
                                            <option value="FI">Finland</option>
                                            <option value="FR">France</option>
                                            <option value="FG">French Guiana</option>
                                            <option value="FP">French Polynesia</option>
                                            <option value="FS">French Southern and Antarctic Lands</option>
                                            <option value="GB">Gabon</option>
                                            <option value="GA">The Gambia</option>
                                            <option value="GZ">Gaza Strip</option>
                                            <option value="GG">Georgia</option>
                                            <option value="GM">Germany</option>
                                            <option value="GH">Ghana</option>
                                            <option value="GI">Gibraltar</option>
                                            <option value="GO">Glorioso Islands</option>
                                            <option value="GR">Greece</option>
                                            <option value="GL">Greenland</option>
                                            <option value="GJ">Grenada</option>
                                            <option value="VC">Grenadines</option>
                                            <option value="GP">Guadeloupe</option>
                                            <option value="GQ">Guam</option>
                                            <option value="GT">Guatemala</option>
                                            <option value="GK">Guernsey</option>
                                            <option value="GV">Guinea</option>
                                            <option value="PU">Guinea - Bissau</option>
                                            <option value="GY">Guyana</option>
                                            <option value="HA">Haiti</option>
                                            <option value="HM">Heard Island and McDonald Islands</option>
                                            <option value="HO">Honduras</option>
                                            <option value="HK">Hong Kong</option>
                                            <option value="HQ">Howland Island</option>
                                            <option value="HU">Hungary</option>
                                            <option value="IC">Iceland</option>
                                            <option value="IN">India</option>
                                            <option value="ID">Indonesia</option>
                                            <option value="IR">Iran</option>
                                            <option value="IZ">Iraq</option>
                                            <option value="EI">Ireland</option>
                                            <option value="IS">Israel</option>
                                            <option value="IT">Italy</option>
                                            <option value="JM">Jamaica</option>
                                            <option value="JN">Jan Mayen</option>
                                            <option value="JA">Japan</option>
                                            <option value="DQ">Jarvis Island</option>
                                            <option value="JE">Jersey</option>
                                            <option value="JQ">Johnston Atoll</option>
                                            <option value="JO">Jordan</option>
                                            <option value="JU">Juan de Nova Island</option>
                                            <option value="KZ">Kazakhstan</option>
                                            <option value="KE">Kenya</option>
                                            <option value="KQ">Kingman Reef</option>
                                            <option value="KR">Kiribati</option>
                                            <option value="KN">Korea, Democratic People&#39;s Republic of (North)
                                            </option>
                                            <option value="KS">Korea, Republic of (South)</option>
                                            <option value="KU">Kuwait</option>
                                            <option value="KG">Kyrgyzstan</option>
                                            <option value="LA">Laos</option>
                                            <option value="LG">Latvia</option>
                                            <option value="LE">Lebanon</option>
                                            <option value="LT">Lesotho</option>
                                            <option value="LI">Liberia</option>
                                            <option value="LY">Libya</option>
                                            <option value="LS">Liechtenstein</option>
                                            <option value="LH">Lithuania</option>
                                            <option value="LU">Luxembourg</option>
                                            <option value="MC">Macau</option>
                                            <option value="MK">Macedonia</option>
                                            <option value="MA">Madagascar</option>
                                            <option value="MI">Malawi</option>
                                            <option value="MY">Malaysia</option>
                                            <option value="MV">Maldives</option>
                                            <option value="ML">Mali</option>
                                            <option value="MT">Malta</option>
                                            <option value="IM">Man, Isle of</option>
                                            <option value="RM">Marshall Islands</option>
                                            <option value="MB">Martinique</option>
                                            <option value="MR">Mauritania</option>
                                            <option value="MP">Mauritius</option>
                                            <option value="MF">Mayotte</option>
                                            <option value="MX">Mexico</option>
                                            <option value="MQ">Midway Islands</option>
                                            <option value="MD">Moldova</option>
                                            <option value="MN">Monaco</option>
                                            <option value="MG">Mongolia</option>
                                            <option value="MJ">Montenegro</option>
                                            <option value="MH">Montserrat</option>
                                            <option value="MO">Morocco</option>
                                            <option value="MZ">Mozambique</option>
                                            <option value="XM">Myanmar</option>
                                            <option value="WA">Namibia</option>
                                            <option value="NR">Nauru</option>
                                            <option value="BQ">Navassa Island</option>
                                            <option value="NP">Nepal</option>
                                            <option value="NL">Netherlands</option>
                                            <option value="NT">Netherlands Antilles</option>
                                            <option value="NC">New Caledonia</option>
                                            <option value="NZ">New Zealand</option>
                                            <option value="NU">Nicaragua</option>
                                            <option value="NG">Niger</option>
                                            <option value="NI">Nigeria</option>
                                            <option value="NE">Niue</option>
                                            <option value="NF">Norfolk Island</option>
                                            <option value="XN">Northern Ireland</option>
                                            <option value="CQ">Northern Mariana Islands</option>
                                            <option value="NO">Norway</option>
                                            <option value="MU">Oman</option>
                                            <option value="OC">Other Country (country not identified elsewhere)</option>
                                            <option value="PK">Pakistan</option>
                                            <option value="LQ">Palmyra Atoll</option>
                                            <option value="PS">Palau</option>
                                            <option value="PM">Panama</option>
                                            <option value="PP">Papua - New Guinea</option>
                                            <option value="PF">Paracel Islands</option>
                                            <option value="PA">Paraguay</option>
                                            <option value="PE">Peru</option>
                                            <option value="RP">Philippines</option>
                                            <option value="PC">Pitcairn Islands</option>
                                            <option value="PL">Poland</option>
                                            <option value="PO">Portugal</option>
                                            <option value="RQ">Puerto Rico</option>
                                            <option value="QA">Qatar</option>
                                            <option value="RE">Reunion</option>
                                            <option value="RO">Romania</option>
                                            <option value="RS">Russia</option>
                                            <option value="RW">Rwanda</option>
                                            <option value="WS">Samoa and Western Samoa</option>
                                            <option value="SM">San Marino</option>
                                            <option value="TP">Sao Tome and Principe</option>
                                            <option value="SA">Saudi Arabia</option>
                                            <option value="XS">Scotland</option>
                                            <option value="SG">Senegal</option>
                                            <option value="RI">Serbia</option>
                                            <option value="SE">Seychelles</option>
                                            <option value="SL">Sierra Leone</option>
                                            <option value="SN">Singapore</option>
                                            <option value="XR">Slovak Republic</option>
                                            <option value="LO">Slovakia</option>
                                            <option value="SI">Slovenia</option>
                                            <option value="BP">Solomon Islands</option>
                                            <option value="SO">Somalia</option>
                                            <option value="SF">South Africa</option>
                                            <option value="SX">South Georgia and the South Sandwich Islands</option>
                                            <option value="SP">Spain</option>
                                            <option value="PG">Spratly Islands</option>
                                            <option value="CE">Sri Lanka</option>
                                            <option value="SH">St.Helena</option>
                                            <option value="SC">St.Kitts and Nevis</option>
                                            <option value="ST">St.Lucia Island</option>
                                            <option value="SB">St.Pierre and Miquelon</option>
                                            <option value="VC">St.Vincent and the Grenadines</option>
                                            <option value="SU">Sudan</option>
                                            <option value="NS">Suriname</option>
                                            <option value="SV">Svalbard</option>
                                            <option value="WZ">Swaziland</option>
                                            <option value="SW">Sweden</option>
                                            <option value="SZ">Switzerland</option>
                                            <option value="SY">Syria</option>
                                            <option value="TW">Taiwan</option>
                                            <option value="TI">Tajikistin</option>
                                            <option value="TZ">Tanzania</option>
                                            <option value="TH">Thailand</option>
                                            <option value="TO">Togo</option>
                                            <option value="TL">Tokelau</option>
                                            <option value="TN">Tonga</option>
                                            <option value="TD">Trinidad and Tobago</option>
                                            <option value="XT">Tristan Da Cunha</option>
                                            <option value="TE">Tromelin Island</option>
                                            <option value="TS">Tunisia</option>
                                            <option value="TU">Turkey</option>
                                            <option value="TX">Turkmenistan</option>
                                            <option value="TK">Turks and Caicos Islands</option>
                                            <option value="TV">Tuvalu</option>
                                            <option value="UG">Uganda</option>
                                            <option value="UP">Ukraine</option>
                                            <option value="AE">United Arab Emirates</option>
                                            <option value="UY">Uruguay</option>
                                            <option value="UZ">Uzbekistan</option>
                                            <option value="NH">Vanuatu</option>
                                            <option value="VT">Vatican City</option>
                                            <option value="VE">Venezuela</option>
                                            <option value="VM">Vietnam</option>
                                            <option value="VQ">Virgin Islands</option>
                                            <option value="WQ">Wake Island</option>
                                            <option value="XW">Wales</option>
                                            <option value="WF">Wallis and Futuna</option>
                                            <option value="WE">West Bank</option>
                                            <option value="WI">Western Sahara</option>
                                            <option value="YM">Yemen(Aden)</option>
                                            <option value="YI">Yugoslavia</option>
                                            <option value="ZA">Zambia</option>
                                            <option value="ZI">Zimbabwe</option>
                                            <option value="UC">Curacao</option>
                                            <option value="VT">Holy See</option>
                                            <option value="KV">Kosovo</option>
                                            <option value="PS">Palau</option>
                                            <option value="TB">Saint Barthelemy</option>
                                            <option value="RN">Saint Martin</option>
                                            <option value="NN">Sint Maarten</option>
                                            <option value="OD">South Sudan</option>
                                            <option value="UK">United Kingdom</option>
                                            <option selected="selected" value="US">USA</option>
                                        </select>
                                    </td>
                                    <td class="labelName"><label class="control-labeld">Contact Name:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Business_ContactNm"
                                                                 name="ContactNm" type="text" value="Express Team"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Email Address:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Business_Email" name="Email"
                                                                 type="text" value="e990dev@expressexcise.com"/></td>
                                    <td class="labelName"><label class="control-label">Phone Number:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Business_Phone" name="Phone"
                                                                 type="text" value="9841381515"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Phone Extn:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Business_PhoneExtn"
                                                                 name="PhoneExtn" type="text" value=""/></td>
                                    <td class="labelName"><label class="control-label">Fax Number:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Business_Fax" name="Fax"
                                                                 type="text" value="4785963214"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName">
                                        <label class="control-label">Kind Of Employer:</label>
                                    </td>
                                    <td class="fieldName">
                                        <select class="form-control" id="KindOfEmployer" name="KindOfEmployer">
                                            <option value="">Select Employer Type</option>
                                            <option selected="selected" value="FEDERALGOVT">FederalGovt</option>
                                            <option value="STATEORLOCAL501C">StateOrLocal501c</option>
                                            <option value="NONGOVT501C">501cnongovt</option>
                                            <option value="STATEORLOCALNON501C">StateOrLocalnon501c</option>
                                            <option value="NONEAPPLY">Noneapply</option>
                                        </select>
                                    </td>
                                    <td class="labelName">
                                        <label class="control-label">Employment Code:</label>
                                    </td>
                                    <td class="fieldName">
                                        <select class="form-control" id="EmploymentCd" name="EmploymentCd">
                                            <option value="">Select Employer Type</option>
                                            <option selected="selected" value="REGULAR941">Regular(941)</option>
                                            <option value="REGULAR944">Regular(944)</option>
                                            <option value="AGRICULTURAL943">Agricultural(943)</option>
                                            <option value="HOUSEHOLD">Household</option>
                                            <option value="MILITARY">Military</option>
                                            <option value="MEDICAREQUALGOVEM">MedicareQualGovEm</option>
                                            <option value="RAILROADFORMCT1">Railroad(CT-1)</option>
                                        </select>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
                <div class="panel panel-default">
                    <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapse2">
                        <h4 class="panel-title">
                            Employee Details
                        </h4>
                    </div>
                    <div id="collapse2" class="panel-collapse collapse">
                        <div class="panel-body">
                            <table class="responsive">
                                <tr>
                                    <td class="labelName"><label class="control-label">SSN:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Employee_SSN" name="SSN"
                                                                 type="text" value="543276235"/></td>
                                    <td class="labelName"><label class="control-label">First Name:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Employee_FirstNm"
                                                                 name="FirstNm" type="text" value="Peter"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Last Name:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Employee_LastNm" name="LastNm"
                                                                 type="text" value="Yengaran"/></td>
                                    <td class="labelName"><label class="control-label">Suffix:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Employee_Suffix" name="Suffix"
                                                                 type="text" value=""/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Address Line1:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Employee_Address1"
                                                                 name="Address1" type="text" value="First Street"/></td>
                                    <td class="labelName"><label class="control-label">Address Line2:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Employee_Address2"
                                                                 name="Address2" type="text" value=""/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">City:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Employee_City" name="City"
                                                                 type="text" value="Rockhill"/></td>
                                    <td class="labelName"><label class="control-label">State:</label></td>
                                    <td>
                                        <select class="form-control floatL" id="State" name="State">
                                            <option value="">Select State</option>
                                            <option value="AL">Alabama (AL)</option>
                                            <option value="AK">Alaska (AK)</option>
                                            <option value="AZ">Arizona (AZ)</option>
                                            <option value="AR">Arkansas (AR)</option>
                                            <option value="CA">California (CA)</option>
                                            <option value="CO">Colorado (CO)</option>
                                            <option value="CT">Connecticut (CT)</option>
                                            <option value="DE">Delaware (DE)</option>
                                            <option value="DC">District of Columbia (DC)</option>
                                            <option value="FL">Florida (FL)</option>
                                            <option value="GA">Georgia (GA)</option>
                                            <option value="HI">Hawaii (HI)</option>
                                            <option value="ID">Idaho (ID)</option>
                                            <option value="IL">Illinois (IL)</option>
                                            <option value="IN">Indiana (IN)</option>
                                            <option value="IA">Iowa (IA)</option>
                                            <option value="KS">Kansas (KS)</option>
                                            <option value="KY">Kentucky (KY)</option>
                                            <option value="LA">Louisiana (LA)</option>
                                            <option value="ME">Maine (ME)</option>
                                            <option value="MD">Maryland (MD)</option>
                                            <option value="MA">Massachusetts (MA)</option>
                                            <option value="MI">Michigan (MI)</option>
                                            <option value="MN">Minnesota (MN)</option>
                                            <option value="MS">Mississippi (MS)</option>
                                            <option value="MO">Missouri (MO)</option>
                                            <option value="MT">Montana (MT)</option>
                                            <option value="NE">Nebraska (NE)</option>
                                            <option value="NV">Nevada (NV)</option>
                                            <option value="NH">New Hampshire (NH)</option>
                                            <option value="NJ">New Jersey (NJ)</option>
                                            <option value="NM">New Mexico (NM)</option>
                                            <option value="NY">New York (NY)</option>
                                            <option value="NC">North Carolina (NC)</option>
                                            <option value="ND">North Dakota (ND)</option>
                                            <option value="OH">Ohio (OH)</option>
                                            <option value="OK">Oklahoma (OK)</option>
                                            <option value="OR">Oregon (OR)</option>
                                            <option value="PA">Pennsylvania (PA)</option>
                                            <option value="RI">Rhode Island (RI)</option>
                                            <option selected="selected" value="SC">South Carolina (SC)</option>
                                            <option value="SD">South Dakota (SD)</option>
                                            <option value="TN">Tennessee (TN)</option>
                                            <option value="TX">Texas (TX)</option>
                                            <option value="UT">Utah (UT)</option>
                                            <option value="VT">Vermont (VT)</option>
                                            <option value="VA">Virginia (VA)</option>
                                            <option value="WA">Washington (WA)</option>
                                            <option value="WV">West Virginia (WV)</option>
                                            <option value="WI">Wisconsin (WI)</option>
                                            <option value="WY">Wyoming (WY)</option>
                                            <option value="AS">American Samoa (AS)</option>
                                            <option value="FM">Federated States of Micronesia (FM)</option>
                                            <option value="GU">Guam (GU)</option>
                                            <option value="MH">Marshall Islands (MH)</option>
                                            <option value="MP">Northern Mariana Islands (MP)</option>
                                            <option value="PW">Palau (PW)</option>
                                            <option value="PR">Puerto Rico (PR)</option>
                                            <option value="VI">Virgin Islands (VI)</option>
                                            <option value="AA">Armed Forces Americas (AA)</option>
                                            <option value="AE">Armed Forces Europe (AE)</option>
                                            <option value="AP">Armed Forces Pacific (AP)</option>
                                        </select>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Zip Code:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Employee_Zip" name="Zip"
                                                                 type="text" value="29727"/></td>
                                    <td class="labelName"><label class="control-label">Country:</label></td>
                                    <td class="fieldName">
                                        <select class="form-control" id="Country" name="Country">
                                            <option value="">Select Country</option>
                                            <option value="AF">Afghanistan</option>
                                            <option value="AX">Akrotiri</option>
                                            <option value="XI">Aland Island</option>
                                            <option value="AL">Albania</option>
                                            <option value="AG">Algeria</option>
                                            <option value="AQ">American Samoa</option>
                                            <option value="AN">Andorra</option>
                                            <option value="AO">Angola</option>
                                            <option value="AV">Anguilla</option>
                                            <option value="AY">Antarctica</option>
                                            <option value="AC">Antigua and Barbuda</option>
                                            <option value="AR">Argentina</option>
                                            <option value="AM">Armenia</option>
                                            <option value="AA">Aruba</option>
                                            <option value="XA">Ascension</option>
                                            <option value="AT">Ashmore and Cartier Islands</option>
                                            <option value="AS">Australia</option>
                                            <option value="AU">Austria</option>
                                            <option value="AJ">Azerbaijan</option>
                                            <option value="XZ">Azores</option>
                                            <option value="BF">Bahamas</option>
                                            <option value="BA">Bahrain</option>
                                            <option value="FQ">Baker Islands</option>
                                            <option value="BG">Bangladesh</option>
                                            <option value="BB">Barbados</option>
                                            <option value="BS">Bassas da India</option>
                                            <option value="BO">Belarus</option>
                                            <option value="BE">Belgium</option>
                                            <option value="BH">Belize</option>
                                            <option value="BN">Benin</option>
                                            <option value="BD">Bermuda</option>
                                            <option value="BT">Bhutan</option>
                                            <option value="BL">Bolivia</option>
                                            <option value="BK">Bosnia - Herzegovina</option>
                                            <option value="BC">Botswana</option>
                                            <option value="BV">Bouvet Island</option>
                                            <option value="BR">Brazil</option>
                                            <option value="IO">British Indian OceanTerritory</option>
                                            <option value="VI">British Virgin Islands</option>
                                            <option value="BX">Brunei</option>
                                            <option value="BU">Bulgaria</option>
                                            <option value="UV">Burkina Faso</option>
                                            <option value="BM">Burma</option>
                                            <option value="BY">Burundi</option>
                                            <option value="CB">Cambodia</option>
                                            <option value="CM">Cameroon</option>
                                            <option value="CA">Canada</option>
                                            <option value="XY">Canary Islands</option>
                                            <option value="CV">Cape Verde</option>
                                            <option value="CJ">Cayman Islands</option>
                                            <option value="CT">Central African Republic</option>
                                            <option value="CD">Chad</option>
                                            <option value="XC">Channel Islands</option>
                                            <option value="CI">Chile</option>
                                            <option value="CH">China</option>
                                            <option value="KT">Christmas Island</option>
                                            <option value="IP">Clipperton Island</option>
                                            <option value="CK">Cocos(Keeling) Islands</option>
                                            <option value="CO">Colombia</option>
                                            <option value="CN">Comoros</option>
                                            <option value="CF">Congo(Brazzaville)</option>
                                            <option value="CG">Congo(Kinshasa)</option>
                                            <option value="CW">Cook Islands</option>
                                            <option value="CR">Coral Sea Islands</option>
                                            <option value="VP">Corsica</option>
                                            <option value="CS">Costa Rica</option>
                                            <option value="IV">Cote D&#39;Ivoire (IvoryCoast)</option>
                                            <option value="HR">Croatia</option>
                                            <option value="CU">Cuba</option>
                                            <option value="CY">Cyprus</option>
                                            <option value="EZ">Czech Republic</option>
                                            <option value="DA">Denmark</option>
                                            <option value="DX">Dhekelia</option>
                                            <option value="DJ">Djibouti</option>
                                            <option value="DO">Dominica</option>
                                            <option value="DR">Dominican Republic</option>
                                            <option value="TT">East Timor</option>
                                            <option value="EC">Ecuador</option>
                                            <option value="EG">Egypt</option>
                                            <option value="ES">El Salvador</option>
                                            <option value="UK">England</option>
                                            <option value="EK">Equatorial Guinea</option>
                                            <option value="ER">Eritrea</option>
                                            <option value="EN">Estonia</option>
                                            <option value="ET">Ethiopia</option>
                                            <option value="EU">Europa Island</option>
                                            <option value="FK">Falkland Islands(Islas Malvinas)</option>
                                            <option value="FO">Faroe Islands</option>
                                            <option value="FM">Federated States of Micronesia</option>
                                            <option value="FJ">Fiji</option>
                                            <option value="FI">Finland</option>
                                            <option value="FR">France</option>
                                            <option value="FG">French Guiana</option>
                                            <option value="FP">French Polynesia</option>
                                            <option value="FS">French Southern and Antarctic Lands</option>
                                            <option value="GB">Gabon</option>
                                            <option value="GA">The Gambia</option>
                                            <option value="GZ">Gaza Strip</option>
                                            <option value="GG">Georgia</option>
                                            <option value="GM">Germany</option>
                                            <option value="GH">Ghana</option>
                                            <option value="GI">Gibraltar</option>
                                            <option value="GO">Glorioso Islands</option>
                                            <option value="GR">Greece</option>
                                            <option value="GL">Greenland</option>
                                            <option value="GJ">Grenada</option>
                                            <option value="VC">Grenadines</option>
                                            <option value="GP">Guadeloupe</option>
                                            <option value="GQ">Guam</option>
                                            <option value="GT">Guatemala</option>
                                            <option value="GK">Guernsey</option>
                                            <option value="GV">Guinea</option>
                                            <option value="PU">Guinea - Bissau</option>
                                            <option value="GY">Guyana</option>
                                            <option value="HA">Haiti</option>
                                            <option value="HM">Heard Island and McDonald Islands</option>
                                            <option value="HO">Honduras</option>
                                            <option value="HK">Hong Kong</option>
                                            <option value="HQ">Howland Island</option>
                                            <option value="HU">Hungary</option>
                                            <option value="IC">Iceland</option>
                                            <option value="IN">India</option>
                                            <option value="ID">Indonesia</option>
                                            <option value="IR">Iran</option>
                                            <option value="IZ">Iraq</option>
                                            <option value="EI">Ireland</option>
                                            <option value="IS">Israel</option>
                                            <option value="IT">Italy</option>
                                            <option value="JM">Jamaica</option>
                                            <option value="JN">Jan Mayen</option>
                                            <option value="JA">Japan</option>
                                            <option value="DQ">Jarvis Island</option>
                                            <option value="JE">Jersey</option>
                                            <option value="JQ">Johnston Atoll</option>
                                            <option value="JO">Jordan</option>
                                            <option value="JU">Juan de Nova Island</option>
                                            <option value="KZ">Kazakhstan</option>
                                            <option value="KE">Kenya</option>
                                            <option value="KQ">Kingman Reef</option>
                                            <option value="KR">Kiribati</option>
                                            <option value="KN">Korea, Democratic People&#39;s Republic of (North)
                                            </option>
                                            <option value="KS">Korea, Republic of (South)</option>
                                            <option value="KU">Kuwait</option>
                                            <option value="KG">Kyrgyzstan</option>
                                            <option value="LA">Laos</option>
                                            <option value="LG">Latvia</option>
                                            <option value="LE">Lebanon</option>
                                            <option value="LT">Lesotho</option>
                                            <option value="LI">Liberia</option>
                                            <option value="LY">Libya</option>
                                            <option value="LS">Liechtenstein</option>
                                            <option value="LH">Lithuania</option>
                                            <option value="LU">Luxembourg</option>
                                            <option value="MC">Macau</option>
                                            <option value="MK">Macedonia</option>
                                            <option value="MA">Madagascar</option>
                                            <option value="MI">Malawi</option>
                                            <option value="MY">Malaysia</option>
                                            <option value="MV">Maldives</option>
                                            <option value="ML">Mali</option>
                                            <option value="MT">Malta</option>
                                            <option value="IM">Man, Isle of</option>
                                            <option value="RM">Marshall Islands</option>
                                            <option value="MB">Martinique</option>
                                            <option value="MR">Mauritania</option>
                                            <option value="MP">Mauritius</option>
                                            <option value="MF">Mayotte</option>
                                            <option value="MX">Mexico</option>
                                            <option value="MQ">Midway Islands</option>
                                            <option value="MD">Moldova</option>
                                            <option value="MN">Monaco</option>
                                            <option value="MG">Mongolia</option>
                                            <option value="MJ">Montenegro</option>
                                            <option value="MH">Montserrat</option>
                                            <option value="MO">Morocco</option>
                                            <option value="MZ">Mozambique</option>
                                            <option value="XM">Myanmar</option>
                                            <option value="WA">Namibia</option>
                                            <option value="NR">Nauru</option>
                                            <option value="BQ">Navassa Island</option>
                                            <option value="NP">Nepal</option>
                                            <option value="NL">Netherlands</option>
                                            <option value="NT">Netherlands Antilles</option>
                                            <option value="NC">New Caledonia</option>
                                            <option value="NZ">New Zealand</option>
                                            <option value="NU">Nicaragua</option>
                                            <option value="NG">Niger</option>
                                            <option value="NI">Nigeria</option>
                                            <option value="NE">Niue</option>
                                            <option value="NF">Norfolk Island</option>
                                            <option value="XN">Northern Ireland</option>
                                            <option value="CQ">Northern Mariana Islands</option>
                                            <option value="NO">Norway</option>
                                            <option value="MU">Oman</option>
                                            <option value="OC">Other Country (country not identified elsewhere)</option>
                                            <option value="PK">Pakistan</option>
                                            <option value="LQ">Palmyra Atoll</option>
                                            <option value="PS">Palau</option>
                                            <option value="PM">Panama</option>
                                            <option value="PP">Papua - New Guinea</option>
                                            <option value="PF">Paracel Islands</option>
                                            <option value="PA">Paraguay</option>
                                            <option value="PE">Peru</option>
                                            <option value="RP">Philippines</option>
                                            <option value="PC">Pitcairn Islands</option>
                                            <option value="PL">Poland</option>
                                            <option value="PO">Portugal</option>
                                            <option value="RQ">Puerto Rico</option>
                                            <option value="QA">Qatar</option>
                                            <option value="RE">Reunion</option>
                                            <option value="RO">Romania</option>
                                            <option value="RS">Russia</option>
                                            <option value="RW">Rwanda</option>
                                            <option value="WS">Samoa and Western Samoa</option>
                                            <option value="SM">San Marino</option>
                                            <option value="TP">Sao Tome and Principe</option>
                                            <option value="SA">Saudi Arabia</option>
                                            <option value="XS">Scotland</option>
                                            <option value="SG">Senegal</option>
                                            <option value="RI">Serbia</option>
                                            <option value="SE">Seychelles</option>
                                            <option value="SL">Sierra Leone</option>
                                            <option value="SN">Singapore</option>
                                            <option value="XR">Slovak Republic</option>
                                            <option value="LO">Slovakia</option>
                                            <option value="SI">Slovenia</option>
                                            <option value="BP">Solomon Islands</option>
                                            <option value="SO">Somalia</option>
                                            <option value="SF">South Africa</option>
                                            <option value="SX">South Georgia and the South Sandwich Islands</option>
                                            <option value="SP">Spain</option>
                                            <option value="PG">Spratly Islands</option>
                                            <option value="CE">Sri Lanka</option>
                                            <option value="SH">St.Helena</option>
                                            <option value="SC">St.Kitts and Nevis</option>
                                            <option value="ST">St.Lucia Island</option>
                                            <option value="SB">St.Pierre and Miquelon</option>
                                            <option value="VC">St.Vincent and the Grenadines</option>
                                            <option value="SU">Sudan</option>
                                            <option value="NS">Suriname</option>
                                            <option value="SV">Svalbard</option>
                                            <option value="WZ">Swaziland</option>
                                            <option value="SW">Sweden</option>
                                            <option value="SZ">Switzerland</option>
                                            <option value="SY">Syria</option>
                                            <option value="TW">Taiwan</option>
                                            <option value="TI">Tajikistin</option>
                                            <option value="TZ">Tanzania</option>
                                            <option value="TH">Thailand</option>
                                            <option value="TO">Togo</option>
                                            <option value="TL">Tokelau</option>
                                            <option value="TN">Tonga</option>
                                            <option value="TD">Trinidad and Tobago</option>
                                            <option value="XT">Tristan Da Cunha</option>
                                            <option value="TE">Tromelin Island</option>
                                            <option value="TS">Tunisia</option>
                                            <option value="TU">Turkey</option>
                                            <option value="TX">Turkmenistan</option>
                                            <option value="TK">Turks and Caicos Islands</option>
                                            <option value="TV">Tuvalu</option>
                                            <option value="UG">Uganda</option>
                                            <option value="UP">Ukraine</option>
                                            <option value="AE">United Arab Emirates</option>
                                            <option value="UY">Uruguay</option>
                                            <option value="UZ">Uzbekistan</option>
                                            <option value="NH">Vanuatu</option>
                                            <option value="VT">Vatican City</option>
                                            <option value="VE">Venezuela</option>
                                            <option value="VM">Vietnam</option>
                                            <option value="VQ">Virgin Islands</option>
                                            <option value="WQ">Wake Island</option>
                                            <option value="XW">Wales</option>
                                            <option value="WF">Wallis and Futuna</option>
                                            <option value="WE">West Bank</option>
                                            <option value="WI">Western Sahara</option>
                                            <option value="YM">Yemen(Aden)</option>
                                            <option value="YI">Yugoslavia</option>
                                            <option value="ZA">Zambia</option>
                                            <option value="ZI">Zimbabwe</option>
                                            <option value="UC">Curacao</option>
                                            <option value="VT">Holy See</option>
                                            <option value="KV">Kosovo</option>
                                            <option value="PS">Palau</option>
                                            <option value="TB">Saint Barthelemy</option>
                                            <option value="RN">Saint Martin</option>
                                            <option value="NN">Sint Maarten</option>
                                            <option value="OD">South Sudan</option>
                                            <option value="UK">United Kingdom</option>
                                            <option selected="selected" value="US">USA</option>
                                        </select>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Email:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Employee_Email" name="Email"
                                                                 type="text" value="peter@spanenterprises.com"/></td>
                                    <td class="labelName"><label class="control-label">Phone:</label></td>
                                    <td class="fieldName"><input class="form-control" id="Employee_Phone" name="Phone"
                                                                 type="text" value="9884523450"/></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
                <div class="panel panel-default">
                    <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapse3">
                        <h4 class="panel-title">
                            FormW2 Details
                        </h4>
                    </div>
                    <div id="collapse3" class="panel-collapse collapse">
                        <div class="panel-body">

                            <table class="responsive">
                                <tr>
                                    <td class="labelName"><label class="control-label">Wages and tips:</label></td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box1 must be a number."
                                                                 data-val-required="The Box1 field is required."
                                                                 id="FormDetails_Box1" name="Box1" type="text"
                                                                 value="10000.00"/></td>
                                    <td class="labelName"><label class="control-label">Federal income tax
                                        withheld:</label></td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box2 must be a number."
                                                                 data-val-required="The Box2 field is required."
                                                                 id="FormDetails_Box2" name="Box2" type="text"
                                                                 value="0"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Social security wages:</label>
                                    </td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box3 must be a number."
                                                                 data-val-required="The Box3 field is required."
                                                                 id="FormDetails_Box3" name="Box3" type="text"
                                                                 value="0"/></td>
                                    <td class="labelName"><label class="control-label">Social security tax
                                        withheld:</label></td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box4 must be a number."
                                                                 data-val-required="The Box4 field is required."
                                                                 id="FormDetails_Box4" name="Box4" type="text"
                                                                 value="0"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Medicare wages and tips:</label>
                                    </td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box5 must be a number."
                                                                 data-val-required="The Box5 field is required."
                                                                 id="FormDetails_Box5" name="Box5" type="text"
                                                                 value="0"/></td>
                                    <td class="labelName"><label class="control-label">Medicare tax withheld:</label>
                                    </td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box6 must be a number."
                                                                 data-val-required="The Box6 field is required."
                                                                 id="FormDetails_Box6" name="Box6" type="text"
                                                                 value="0"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Social security tips:</label>
                                    </td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box7 must be a number."
                                                                 data-val-required="The Box7 field is required."
                                                                 id="FormDetails_Box7" name="Box7" type="text"
                                                                 value="0"/></td>
                                    <td class="labelName"><label class="control-label">Allocated tips:</label></td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box8 must be a number."
                                                                 data-val-required="The Box8 field is required."
                                                                 id="FormDetails_Box8" name="Box8" type="text"
                                                                 value="0"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Verification code:</label></td>
                                    <td class="fieldName"><input class="form-control" id="FormDetails_Box9" name="Box9"
                                                                 type="text" value=""/></td>
                                    <td class="labelName"><label class="control-label">Dependent care benefits:</label>
                                    </td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box10 must be a number."
                                                                 data-val-required="The Box10 field is required."
                                                                 id="FormDetails_Box10" name="Box10" type="text"
                                                                 value="0"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Nonqualified plans:</label></td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box11NonqualifiedPlan must be a number."
                                                                 data-val-required="The Box11NonqualifiedPlan field is required."
                                                                 id="FormDetails_Box11NonqualifiedPlan"
                                                                 name="Box11NonqualifiedPlan" type="text" value="0"/>
                                    </td>
                                    <td class="labelName"><label class="control-label">12a See instructions for box
                                        12:</label></td>
                                    <td>
                                        <select class="form-control floatL" id="Box12aCd" name="Box12aCd"
                                                style="Width:60px">
                                            <option value="">Select Code</option>
                                            <option value="A">A</option>
                                            <option value="B">B</option>
                                            <option value="C">C</option>
                                            <option value="D">D</option>
                                            <option value="E">E</option>
                                            <option value="F">F</option>
                                            <option value="G">G</option>
                                            <option value="H">H</option>
                                            <option value="J">J</option>
                                            <option value="K">K</option>
                                            <option value="L">L</option>
                                            <option value="M">M</option>
                                            <option value="N">N</option>
                                            <option value="P">P</option>
                                            <option value="Q">Q</option>
                                            <option value="R">R</option>
                                            <option value="S">S</option>
                                            <option value="T">T</option>
                                            <option value="V">V</option>
                                            <option value="W">W</option>
                                            <option value="Y">Y</option>
                                            <option value="Z">Z</option>
                                            <option value="AA">AA</option>
                                            <option value="BB">BB</option>
                                            <option value="CC">CC</option>
                                            <option value="DD">DD</option>
                                            <option value="EE">EE</option>
                                            <option value="FF">FF</option>
                                        </select>
                                        <input class="form-control" data-val="true"
                                               data-val-number="The field Box12aAmt must be a number."
                                               data-val-required="The Box12aAmt field is required."
                                               id="FormDetails_Box12aAmt" name="Box12aAmt"
                                               style="Width:185px;margin-left: 5px;" type="text" value="0"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">12b See instructions for box
                                        12:</label></td>
                                    <td>
                                        <select class="form-control floatL" id="Box12bCd" name="Box12bCd"
                                                style="Width:60px">
                                            <option value="">Select Code</option>
                                            <option value="A">A</option>
                                            <option value="B">B</option>
                                            <option value="C">C</option>
                                            <option value="D">D</option>
                                            <option value="E">E</option>
                                            <option value="F">F</option>
                                            <option value="G">G</option>
                                            <option value="H">H</option>
                                            <option value="J">J</option>
                                            <option value="K">K</option>
                                            <option value="L">L</option>
                                            <option value="M">M</option>
                                            <option value="N">N</option>
                                            <option value="P">P</option>
                                            <option value="Q">Q</option>
                                            <option value="R">R</option>
                                            <option value="S">S</option>
                                            <option value="T">T</option>
                                            <option value="V">V</option>
                                            <option value="W">W</option>
                                            <option value="Y">Y</option>
                                            <option value="Z">Z</option>
                                            <option value="AA">AA</option>
                                            <option value="BB">BB</option>
                                            <option value="CC">CC</option>
                                            <option value="DD">DD</option>
                                            <option value="EE">EE</option>
                                            <option value="FF">FF</option>
                                        </select>
                                        <input class="form-control" data-val="true"
                                               data-val-number="The field Box12bAmt must be a number."
                                               data-val-required="The Box12bAmt field is required."
                                               id="FormDetails_Box12bAmt" name="Box12bAmt"
                                               style="Width:185px;margin-left: 5px;" type="text" value="0"/>
                                    </td>
                                    <td class="labelName"><label class="control-label">12c See instructions for box
                                        12:</label></td>
                                    <td>
                                        <select class="form-control floatL" id="Box12cCd" name="Box12cCd"
                                                style="Width:60px">
                                            <option value="">Select Code</option>
                                            <option value="A">A</option>
                                            <option value="B">B</option>
                                            <option value="C">C</option>
                                            <option value="D">D</option>
                                            <option value="E">E</option>
                                            <option value="F">F</option>
                                            <option value="G">G</option>
                                            <option value="H">H</option>
                                            <option value="J">J</option>
                                            <option value="K">K</option>
                                            <option value="L">L</option>
                                            <option value="M">M</option>
                                            <option value="N">N</option>
                                            <option value="P">P</option>
                                            <option value="Q">Q</option>
                                            <option value="R">R</option>
                                            <option value="S">S</option>
                                            <option value="T">T</option>
                                            <option value="V">V</option>
                                            <option value="W">W</option>
                                            <option value="Y">Y</option>
                                            <option value="Z">Z</option>
                                            <option value="AA">AA</option>
                                            <option value="BB">BB</option>
                                            <option value="CC">CC</option>
                                            <option value="DD">DD</option>
                                            <option value="EE">EE</option>
                                            <option value="FF">FF</option>
                                        </select>
                                        <input class="form-control" data-val="true"
                                               data-val-number="The field Box12cAmt must be a number."
                                               data-val-required="The Box12cAmt field is required."
                                               id="FormDetails_Box12cAmt" name="Box12cAmt"
                                               style="Width:185px;margin-left: 5px;" type="text" value="0"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">12d See instructions for box
                                        12:</label></td>
                                    <td>
                                        <select class="form-control floatL" id="Box12dCd" name="Box12dCd"
                                                style="Width:60px">
                                            <option value="">Select Code</option>
                                            <option value="A">A</option>
                                            <option value="B">B</option>
                                            <option value="C">C</option>
                                            <option value="D">D</option>
                                            <option value="E">E</option>
                                            <option value="F">F</option>
                                            <option value="G">G</option>
                                            <option value="H">H</option>
                                            <option value="J">J</option>
                                            <option value="K">K</option>
                                            <option value="L">L</option>
                                            <option value="M">M</option>
                                            <option value="N">N</option>
                                            <option value="P">P</option>
                                            <option value="Q">Q</option>
                                            <option value="R">R</option>
                                            <option value="S">S</option>
                                            <option value="T">T</option>
                                            <option value="V">V</option>
                                            <option value="W">W</option>
                                            <option value="Y">Y</option>
                                            <option value="Z">Z</option>
                                            <option value="AA">AA</option>
                                            <option value="BB">BB</option>
                                            <option value="CC">CC</option>
                                            <option value="DD">DD</option>
                                            <option value="EE">EE</option>
                                            <option value="FF">FF</option>
                                        </select>
                                        <input class="form-control" data-val="true"
                                               data-val-number="The field Box12dAmt must be a number."
                                               data-val-required="The Box12dAmt field is required."
                                               id="FormDetails_Box12dAmt" name="Box12dAmt"
                                               style="Width:185px;margin-left: 5px;" type="text" value="0"/>
                                    </td>
                                    <td class="labelName"><label class="control-label">Statutory Employee:</label></td>
                                    <td>
                                        <input class="form-control" data-val="true"
                                               data-val-required="The Box13IsStatutoryEmployee field is required."
                                               id="FormDetails_Box13IsStatutoryEmployee" name="Box13IsStatutoryEmployee"
                                               type="text" value="False"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Retirement plan:</label></td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-required="The Box13IsRetirementPlan field is required."
                                                                 id="FormDetails_Box13IsRetirementPlan"
                                                                 name="Box13IsRetirementPlan" type="text"
                                                                 value="False"/></td>
                                    <td class="labelName"><label class="control-label">Third-party sick pay:</label>
                                    </td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-required="The Box13IsThirdPartySickpay field is required."
                                                                 id="FormDetails_Box13IsThirdPartySickpay"
                                                                 name="Box13IsThirdPartySickpay" type="text"
                                                                 value="False"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Other</label></td>
                                    <td class="fieldName"><input class="form-control" id="FormDetails_Box14"
                                                                 name="Box14" type="text" value=""/></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>

                <div class="panel panel-default">
                    <div class="panel-heading" data-toggle="collapse" data-parent="#accordion" href="#collapse4">
                        <h4 class="panel-title">
                            State Details
                        </h4>
                    </div>
                    <div id="collapse4" class="panel-collapse collapse">
                        <div class="panel-body">

                            <table class="responsive">
                                <tr>

                                    <td class="labelName"></td>
                                    <td class="fieldText font15">State 1 Detail</td>
                                    <td class="labelName"></td>
                                    <td class="fieldText font15">State 2 Detail</td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">State Code:</label></td>
                                    <td class="fieldName"><input class="form-control" id="FormDetails_Box15State1"
                                                                 name="Box15State1" type="text" value=""/></td>
                                    <td class="labelName"><label class="control-label">State Code:</label></td>
                                    <td class="fieldName"><input class="form-control" id="FormDetails_Box15State2"
                                                                 name="Box15State2" type="text" value=""/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Employer’s state ID
                                        number:</label></td>
                                    <td class="fieldName"><input class="form-control"
                                                                 id="FormDetails_Box15State1IDNumber"
                                                                 name="Box15State1IDNumber" type="text" value=""/></td>
                                    <td class="labelName"><label class="control-label">Employer’s state ID
                                        number:</label></td>
                                    <td class="fieldName"><input class="form-control"
                                                                 id="FormDetails_Box15State2IdNumber"
                                                                 name="Box15State2IdNumber" type="text" value=""/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">State wages, tips, etc.:</label>
                                    </td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box16State1Wages must be a number."
                                                                 data-val-required="The Box16State1Wages field is required."
                                                                 id="FormDetails_Box16State1Wages"
                                                                 name="Box16State1Wages" type="text" value="0"/></td>
                                    <td class="labelName"><label class="control-label">State wages, tips, etc.:</label>
                                    </td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box16State2Wages must be a number."
                                                                 data-val-required="The Box16State2Wages field is required."
                                                                 id="FormDetails_Box16State2Wages"
                                                                 name="Box16State2Wages" type="text" value="0"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">State income tax:</label></td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box17State1Tax must be a number."
                                                                 data-val-required="The Box17State1Tax field is required."
                                                                 id="FormDetails_Box17State1Tax" name="Box17State1Tax"
                                                                 type="text" value="0"/></td>
                                    <td class="labelName"><label class="control-label">State income tax:</label></td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box17State2Tax must be a number."
                                                                 data-val-required="The Box17State2Tax field is required."
                                                                 id="FormDetails_Box17State2Tax" name="Box17State2Tax"
                                                                 type="text" value="0"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Local wages, tips, etc.:</label>
                                    </td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box18Local1Wages must be a number."
                                                                 data-val-required="The Box18Local1Wages field is required."
                                                                 id="FormDetails_Box18Local1Wages"
                                                                 name="Box18Local1Wages" type="text" value="0"/></td>
                                    <td class="labelName"><label class="control-label">Local wages, tips, etc.:</label>
                                    </td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box18Local2Wages must be a number."
                                                                 data-val-required="The Box18Local2Wages field is required."
                                                                 id="FormDetails_Box18Local2Wages"
                                                                 name="Box18Local2Wages" type="text" value="0"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Local income tax:</label></td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box19Local1Tax must be a number."
                                                                 data-val-required="The Box19Local1Tax field is required."
                                                                 id="FormDetails_Box19Local1Tax" name="Box19Local1Tax"
                                                                 type="text" value="0"/></td>
                                    <td class="labelName"><label class="control-label">Local income tax:</label></td>
                                    <td class="fieldName"><input class="form-control" data-val="true"
                                                                 data-val-number="The field Box19Local2Tax must be a number."
                                                                 data-val-required="The Box19Local2Tax field is required."
                                                                 id="FormDetails_Box19Local2Tax" name="Box19Local2Tax"
                                                                 type="text" value="0"/></td>
                                </tr>
                                <tr>
                                    <td class="spacer10"></td>
                                </tr>
                                <tr>
                                    <td class="labelName"><label class="control-label">Locality name:</label></td>
                                    <td class="fieldName"><input class="form-control"
                                                                 id="FormDetails_Box20Locality1Name"
                                                                 name="Box20Locality1Name" type="text" value=""/></td>
                                    <td class="labelName"><label class="control-label">Locality name:</label></td>
                                    <td class="fieldName"><input class="form-control"
                                                                 id="FormDetails_Box20Locality2Name"
                                                                 name="Box20Locality2Name" type="text" value=""/></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <div class="spacer10"></div>
            <div class="taC">
                <input type="submit" value="Create Return" class="btn btn_lg btn_primary"/>
            </div>
        </form>
    </div>

</div>
<footer></footer>

<div class="modal" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
    <div class="modal-dialog" style="width:1000px">
        <div class="modal-content" id="ModelBody">
        </div>
    </div>
</div>
</body>
</html>
