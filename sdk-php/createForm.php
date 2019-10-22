<?php

require ("model/Business.php");
require ("model/SigningAuthority.php");
require ("model/Employee.php");
require ("model/FormDetails.php");
require ("model/W2Forms.php");
include ("config.php");


/* Get Business / Employer's Details */
$Business = new Business();
 
$Business->Address1 		= $_POST["Address1"];
$Business->Address2 		= $_POST["Address2"];

$Business->BusinessNm 		= $_POST["BusinessNm"];
$Business->BusinessType 	= $_POST["BusinessType"];
$Business->City 			= $_POST["City"];
$Business->ContactNm 		= $_POST["ContactNm"];
$Business->Country 			= $_POST["Country"];
$Business->EIN 				= $_POST["EIN"];
$Business->Email 			= $_POST["Email"];
$Business->EmploymentCd 	= $_POST["EmploymentCd"];
$Business->Fax	 			= $_POST["Fax"];
$Business->KindOfEmployer 	= $_POST["KindOfEmployer"];
$Business->Phone 			= $_POST["Phone"];
$Business->PhoneExtn 		= $_POST["PhoneExtn"];
$Business->USState 			= $_POST["USState"];
$Business->USZip 			= $_POST["USZip"];


/* Get Employee's Details */
$Employee = new Employee();

$Employee->SSN      = $_POST["SSN"];
$Employee->FirstNm  = $_POST["FirstNm"];
$Employee->LastNm   = $_POST["LastNm"];
$Employee->Address1 = $_POST["Address1"];
$Employee->Address2 = $_POST["Address2"];
$Employee->City     = $_POST["City"];
$Employee->State    = $_POST["State"];
$Employee->Zip      = $_POST["Zip"];
$Employee->Country  = $_POST["Country"];
$Employee->Email    = $_POST["Email"];
$Employee->Phone    = $_POST["Phone"];


/* Get FormDetails Details */
$FormDetails = new FormDetails();

$FormDetails->Box1  				= $_POST["Box1"];
$FormDetails->Box2  				= $_POST["Box2"];
$FormDetails->Box3  				= $_POST["Box3"];
$FormDetails->Box4  				= $_POST["Box4"];
$FormDetails->Box5  				= $_POST["Box5"];
$FormDetails->Box6  				= $_POST["Box6"];
$FormDetails->Box7  				= $_POST["Box7"];
$FormDetails->Box8  				= $_POST["Box8"];
$FormDetails->Box9  				= $_POST["Box9"];
$FormDetails->Box10  				= $_POST["Box10"];
$FormDetails->Box11NonQualPlan 		= $_POST["Box11NonqualifiedPlan"];
$FormDetails->Box12aCd 				= $_POST["Box12aCd"];
$FormDetails->Box12aAmt 			= $_POST["Box12aAmt"];
$FormDetails->Box12bCd 				= $_POST["Box12bCd"];
$FormDetails->Box12bAmt  			= $_POST["Box12bAmt"];
$FormDetails->Box12cCd  			= $_POST["Box12cCd"];
$FormDetails->Box12cAmt  			= $_POST["Box12cAmt"];
$FormDetails->Box12dCd  			= $_POST["Box12dCd"];
$FormDetails->Box12dAmt  			= $_POST["Box12dAmt"];
$FormDetails->Box13IsStatEmp  		= $_POST["Box13IsStatutoryEmployee"];
$FormDetails->Box13IsRetPlan  		= $_POST["Box13IsRetirementPlan"];
$FormDetails->Box13Is3rdPartySickPay= $_POST["Box13IsThirdPartySickpay"];
$FormDetails->Box14  				= $_POST["Box14"];

/* State 1 Details */
$FormDetails->Box15State1Cd			= $_POST["Box15State1"];
$FormDetails->Box15State1IdNum		= $_POST["Box15State1IDNumber"];
$FormDetails->Box16State1Wages		= $_POST["Box16State1Wages"];
$FormDetails->Box17State1Tax		= $_POST["Box17State1Tax"];
$FormDetails->Box18Local1Wages		= $_POST["Box18Local1Wages"];
$FormDetails->Box19Local1Tax		= $_POST["Box19Local1Tax"];
$FormDetails->Box20Locality1Nm		= $_POST["Box20Locality1Name"];

/* State 2 Details */
$FormDetails->Box15State2Cd			= $_POST["Box15State2"];
$FormDetails->Box15State2IdNum		= $_POST["Box15State2IdNumber"];
$FormDetails->Box16State2Wages		= $_POST["Box16State2Wages"];
$FormDetails->Box17State2Tax		= $_POST["Box17State2Tax"];
$FormDetails->Box18Local2Wages		= $_POST["Box18Local2Wages"];
$FormDetails->Box19Local2Tax		= $_POST["Box19Local2Tax"];
$FormDetails->Box20Locality2Nm		= $_POST["Box20Locality2Name"];


/* Generate Json Objects */
$W2Forms = new W2Forms();

$W2Forms->Business = $Business;
$W2Forms->Employee = $Employee;
$W2Forms->FormDetails = $FormDetails;
$W2Forms->TaxYear = "2017";
$W2Forms->Sequence = "Record1";

$jsonRequest = array("W2Forms" => array($W2Forms));

$jsonRequest = json_encode($jsonRequest);



$ch = curl_init();

$postUrl = $baseUrl . $url_w2create;
$post_message = "POST" . "\n". $utc_time_stamp . "\n" . $ip_address . "\n" . $user_token. "\n" . strtolower('/'.$url_w2create);
$post_sha_auth_msg = hash_hmac("sha256", $post_message, $private_key, true);
$post_hmc_auth_key = base64_encode($post_sha_auth_msg);	


curl_setopt($ch, CURLOPT_URL, $postUrl);
curl_setopt($ch, CURLOPT_HEADER, true);
curl_setopt($ch, CURLOPT_HTTPHEADER, array(
      'Content-Type: application/json',
            'Timestamp:' . $utc_time_stamp,
            'IpAddress:' . $ip_address,
            'UserToken:' . $user_token,
            'Authentication:' . $public_key . ':' . $post_hmc_auth_key
            ));
curl_setopt($ch, CURLOPT_POSTFIELDS, $jsonRequest);

$response = curl_exec($ch);

print_r($response); die();

curl_close($ch);

//if(	$responseCode == "200")
//{
//	header('Location: w2list.php');
//}
//else
//{
//	echo json_decode($response);
//}

?>