package com.span;


import org.apache.commons.codec.binary.Base64;

import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.TimeZone;

import javax.crypto.Mac;
import javax.crypto.spec.SecretKeySpec;

public class AuthenticationUtils
{

    public String getDateUTCForamat()
    {
        try
        {
            Date currentTime = new Date();

            SimpleDateFormat simpleDateFormat = new SimpleDateFormat("EEEE, MMM dd, yyyy hh:mm:ss a");

            simpleDateFormat.setTimeZone(TimeZone.getTimeZone("UTC"));

            return simpleDateFormat.format(currentTime);

        }
        catch (Exception e)
        {
            e.printStackTrace();
        }

        return null;
    }

    private String getAuthKey(String message, String secret)
    {
        try
        {
            Mac sha256_HMAC = Mac.getInstance("HmacSHA256");

            SecretKeySpec secret_key = new SecretKeySpec(secret.getBytes(), "HmacSHA256");

            sha256_HMAC.init(secret_key);

            return Base64.encodeBase64String(sha256_HMAC.doFinal(message.getBytes()));

        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
        return null;
    }

    public String getAuth(String methodType, String timeStamp, String ipAddress, String userToken, String methodName)
    {
        String authCode = methodType + "\n" + timeStamp + "\n" + ipAddress + "\n" + userToken + "\n" + ((methodName).toLowerCase());

        return getAuthKey(authCode, HeaderUtils.PRIVATE_KEY);
    }


}