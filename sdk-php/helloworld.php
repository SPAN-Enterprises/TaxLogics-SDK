<?php

    include ("config.php");

    $get_message = "GET" . "\n". $utc_time_stamp . "\n" . $ip_address . "\n" . $user_token. "\n" . strtolower('/' . $url_helloworld);

	$get_sha_auth_msg = hash_hmac("sha256", $get_message, $private_key, true);

    $get_hmc_auth_key = base64_encode($get_sha_auth_msg);


	$GET_headers = array('http'=>array(
								'method'=>"GET",
								'header'=>array(
										'Timestamp:' . $utc_time_stamp,
										'IpAddress:' . $ip_address,
										'UserToken:' . $user_token,
										'Authentication:' . $public_key . ':' . $get_hmc_auth_key
										))
							);


	// Create a stream
	$opts = array(
			'http'=>array(
			    'method'=>"GET",
			    'header'=>array(
					'Timestamp:' . $utc_time_stamp,
					'IpAddress:' . $ip_address,
					'UserToken:' . $user_token,
					'Authentication:' . $public_key . ':' . $get_hmc_auth_key )));
	
	$context = stream_context_create($opts);
	
	// Open the file using the HTTP headers set above
	$file = file_get_contents($baseUrl . $url_helloworld, false, $context);
	
	echo $file;

 ?>