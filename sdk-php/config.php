<?php

// config details

	$baseUrl     = '<YOUR BASE URL>';

    $url_helloworld = "Business/HelloWorld";
	$url_w2create = "FormW2/Create";
	$url_w2validate = "FormW2/Validate";
	$url_w2get = "FormW2/Get";
	$url_w2transmit = "FormW2/Transmit";
	
	$public_key  = '<YOUR PUBLIC KEY>';
	$private_key = '<YOUR PRIVATE KEY>';
	$user_token  = '<YOUR USER TOKEN>';
	
	
	// Step 1: Add Current Date Time in UTC format eg: 'Tuesday, Nov 28, 2017 11:51:37 AM'
	$timestamp      = time()+date("Z");
    $utc_time_stamp = gmdate("l, M d, Y h:i:s A",$timestamp);
	

    // Step 2: Add Your System Ip Address
    $ip_address =  '<YOUR IP ADDRESS>';


?>