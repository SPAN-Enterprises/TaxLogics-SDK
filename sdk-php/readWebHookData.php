<?php

$headers = apache_request_headers();

$header_timestamp = "";
$header_signature = "";
$header_Connection = "";

foreach ($headers as $header => $value) {
	
	if(strcmp($header, 'Timestamp') == 0)
	{
		$header_timestamp = $value;
	}
	
	if(strcmp($header, 'Signature') == 0)
	{
		$header_signature = $value;
	}
}

print($header_Connection);
print($header_timestamp);
print($header_signature);

$public_key  = '<YOUR PUBLIC KEY>';
$private_key = '<YOUR PRIVATE KEY>';

$post_message = $public_key . "\n" . $header_timestamp;

$post_sha_auth_msg = hash_hmac("sha256", $post_message, $private_key, true);

$post_hmc_auth_key = base64_encode($post_sha_auth_msg);

if(strcmp($post_hmc_auth_key, $header_signature) == 0)
{
	print("Signature is verified");
	print("TODO YOUR STUFF");
}
else
{
	print("Signature verification failed!");
}

?>