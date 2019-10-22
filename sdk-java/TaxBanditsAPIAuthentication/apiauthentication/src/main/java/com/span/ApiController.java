package com.span;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

/**
 * Created by SpanTechnologyServices on 11/28/17.
 */

public class ApiController implements Callback<String>
{

    static final String BASE_URL = "YOUR BASE URL";

    //Method
    static final String HELLO_WORLD = "/Business/HelloWorld";

    //Method Type
    static final String POST = "POST";

    static final String GET = "GET";


    public void HelloWorld()
    {
        Gson gson = new GsonBuilder().setLenient().create();

        Retrofit retrofit = new Retrofit.Builder().baseUrl(BASE_URL).addConverterFactory(GsonConverterFactory.create(gson)).build();

        ApiInterface apiInterface = retrofit.create(ApiInterface.class);

        HeaderUtils headerUtils = new HeaderUtils();

        Call<String> call = apiInterface.HelloWorld((headerUtils.getHeaders(HELLO_WORLD, GET)));

        call.enqueue(this);
    }

    @Override
    public void onResponse(Call<String> call, Response<String> response)
    {

        if(response.isSuccessful())
        {
            System.out.println("Response:" + response.body().toString());

        } else
        {
            System.out.println("Response:" + response.code());
        }
    }

    @Override
    public void onFailure(Call<String> call, Throwable t)
    {
        t.printStackTrace();
    }
}