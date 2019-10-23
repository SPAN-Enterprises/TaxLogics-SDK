package com.span;


import java.util.HashMap;

/**
 * Created by sts-184 on 11/20/17.
 */

public class HeaderUtils
{
    static final String USER_TOKEN = "YOUR USER TOKEN";

    static final String IP_ADDRESS = "YOUR IP ADDRESS";

    static final String PUBLIC_KEY = "YOUR PUBLIC KEY";

    static final String PRIVATE_KEY = "YOUR PRIVATE KEY";

    public HashMap<String, String> getHeaders(String methodName, String methodType)
    {

        HashMap<String, String> headerMap = new HashMap<String, String>();

        AuthenticationUtils authenticationUtils = new AuthenticationUtils();

        String timestamp = authenticationUtils.getDateUTCForamat();

        headerMap.put("Timestamp", timestamp);

        String authenticationKey = PUBLIC_KEY + ":" + authenticationUtils.getAuth(methodType, timestamp, IP_ADDRESS, USER_TOKEN, methodName);

        headerMap.put("Authentication", authenticationKey.trim());

        headerMap.put("UserToken", USER_TOKEN);

        headerMap.put("IpAddress", IP_ADDRESS);

        return headerMap;


    }


}
