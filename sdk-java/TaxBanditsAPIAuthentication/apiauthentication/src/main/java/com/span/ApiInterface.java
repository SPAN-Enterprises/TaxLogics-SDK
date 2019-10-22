package com.span;


import java.util.Map;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.HeaderMap;

/**
 * Created by sts-184 on 11/20/17.
 */

public interface ApiInterface
{

    @GET("/Business/HelloWorld")
    Call<String> HelloWorld(@HeaderMap Map<String, String> headerMap);


}
