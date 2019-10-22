<?php

include ("config.php");
require ("model/validate.php");

$validate = new validate();

$validate->SubmissionId =  $_POST["SubmissionId"];

$jsonRequest = json_encode($validate);


$ch = curl_init();

$postUrl = $baseUrl . $url_w2validate;
$post_message = "POST" . "\n". $utc_time_stamp . "\n" . $ip_address . "\n" . $user_token. "\n" . strtolower('/'.$url_w2validate);
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

?>