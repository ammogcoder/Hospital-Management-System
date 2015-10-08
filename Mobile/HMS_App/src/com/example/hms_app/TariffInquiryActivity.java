package com.example.hms_app;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;
import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

import android.app.ActionBar;
import android.app.Activity;
import android.app.ProgressDialog;
import android.os.AsyncTask;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;

/**
 * Copyright (c) 2011, 2012 Sentaca Communications Ltd.
 */

import android.view.View;
import android.app.Activity;
import android.content.Context;
import android.graphics.Color;
import android.graphics.Typeface;
import android.graphics.drawable.ColorDrawable;
import android.os.Bundle;
import android.util.Log;
import android.util.TypedValue;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.LinearLayout.LayoutParams;

import com.sentaca.android.accordion.utils.FontUtils;

public class TariffInquiryActivity extends Activity
{
	private static final String TAG = "AccordionWidgetDemoActivity";
	
	private LinearLayout linearLayout1;
	private LinearLayout linearLayout2;
	private LinearLayout linearLayout3;
	
	private ProgressDialog progressDialog1;
	private ProgressDialog progressDialog2;
	private ProgressDialog progressDialog3;

	private static final String URL = "http://10.0.3.2:9000/WebService.asmx";     
	private static final String URL1 = "http://192.168.55.1:9000/WebService.asmx";
	private static final String NAMESPACE = "http://tempuri.org/";
	private static final String SOAP_ACTION_1 = "http://tempuri.org/GetConsultationTariff";
	private static final String SOAP_ACTION_2 = "http://tempuri.org/GetRoomTariff";
	private static final String SOAP_ACTION_3 = "http://tempuri.org/GetMiscTariff";
	private static final String METHOD_NAME_1 = "GetConsultationTariff";
	private static final String METHOD_NAME_2 = "GetRoomTariff";
	private static final String METHOD_NAME_3 = "GetMiscTariff";

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.main1);
		setUpLayout();
		
		(new GetConsultationTariffAsyncTask()).executeOnExecutor(AsyncTask.THREAD_POOL_EXECUTOR);

		(new GetRoomTariffAsyncTask()).executeOnExecutor(AsyncTask.THREAD_POOL_EXECUTOR);

		(new GetMiscTariffAsyncTask()).executeOnExecutor(AsyncTask.THREAD_POOL_EXECUTOR);
	}

	private void setUpLayout()
	{
		ActionBar actionBar=getActionBar();
		actionBar.setBackgroundDrawable(new ColorDrawable(Color.parseColor("#00BFFF")));
		actionBar.setDisplayShowCustomEnabled(true);
		actionBar.setDisplayShowTitleEnabled(false);
		actionBar.setIcon(R.drawable.moneybag);
		LayoutInflater inflater=(LayoutInflater)getSystemService(Context.LAYOUT_INFLATER_SERVICE);
		View view=inflater.inflate(R.layout.action_bar_style, null);
		TextView action_bar_title=(TextView)view.findViewById(R.id.action_bar_title);
		Typeface typeface=Typeface.createFromAsset(getAssets(), "fonts/cooper.ttf");
		action_bar_title.setTypeface(typeface);
		action_bar_title.setText("Tariff Inquiry");
		actionBar.setCustomView(view); 
		linearLayout1=(LinearLayout)findViewById(R.id.linearLayout1);
		linearLayout2=(LinearLayout)findViewById(R.id.linearLayout2);
		linearLayout3=(LinearLayout)findViewById(R.id.linearLayout3);
	}
	
	private class GetConsultationTariffAsyncTask extends AsyncTask<Void, Void, String>
	{
		@Override
		protected void onPreExecute()
		{
			progressDialog1=ProgressDialog.show(TariffInquiryActivity.this, "Loading", "Retrieving Consultation Tariff...");
		}
		@Override
		protected String doInBackground(Void... params)
		{
			SoapObject request = new SoapObject(NAMESPACE, METHOD_NAME_1);

			SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
			envelope.dotNet = true;
			envelope.setOutputSoapObject(request);
			HttpTransportSE transport = new HttpTransportSE(URL);
			try
			{
				transport.call(SOAP_ACTION_1, envelope);
				String response = envelope.getResponse().toString();
				return response;
			}
			catch (Exception e)
			{
				Log.d("TAG_FILTER", e.toString());
				return e.toString();
			}
		}
		
		@Override
		protected void onPostExecute(String result)
		{
			progressDialog1.dismiss();
			if (result.equals("org.ksoap2.SoapFault"))
				Toast.makeText(getBaseContext(), "Internal Error. Please Try Again.", Toast.LENGTH_LONG).show();
			else if (result.equals("java.net.SocketTimeoutException"))
				Toast.makeText(getBaseContext(), "Network Error. Please Try Again", Toast.LENGTH_LONG).show();
			else
			{
				try
				{
					JSONObject jsonObject1=new JSONObject(result);
					JSONArray jsonArray1=jsonObject1.getJSONArray("Table");
					for(int i=0;i<jsonArray1.length();i++)
					{
						JSONObject jsonObject2=(JSONObject)jsonArray1.get(i);
						TextView textView=new TextView(TariffInquiryActivity.this);
						textView.setText(jsonObject2.optString("CONSULTATION_TYPE") + " -> Rs. " + jsonObject2.optString("TARIFF"));
						FontUtils.setCustomFont(textView, getAssets());textView.setPadding(0, 20, 0, 20);
						textView.setTextSize(TypedValue.COMPLEX_UNIT_SP, 15);
						linearLayout1.addView(textView);
					}
				}
				catch (Exception e)
				{
					Log.d("TAG_FILTER", e.toString());
				}
			}
		}
	}
	
	private class GetRoomTariffAsyncTask extends AsyncTask<Void, Void, String>
	{
		@Override
		protected void onPreExecute()
		{
			progressDialog2=ProgressDialog.show(TariffInquiryActivity.this, "Loading", "Retrieving Room Tariff...");
		}
		@Override
		protected String doInBackground(Void... params)
		{
			SoapObject request = new SoapObject(NAMESPACE, METHOD_NAME_2);

			SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
			envelope.dotNet = true;
			envelope.setOutputSoapObject(request);
			HttpTransportSE transport = new HttpTransportSE(URL);
			try
			{
				transport.call(SOAP_ACTION_2, envelope);
				String response = envelope.getResponse().toString();
				return response;
			}
			catch (Exception e)
			{
				Log.d("TAG_FILTER", e.toString());
				return e.toString();
			}
		}
		
		@Override
		protected void onPostExecute(String result)
		{
			progressDialog2.dismiss();
			if (result.equals("org.ksoap2.SoapFault"))
				Toast.makeText(getBaseContext(), "Internal Error. Please Try Again.", Toast.LENGTH_LONG).show();
			else if (result.equals("java.net.SocketTimeoutException"))
				Toast.makeText(getBaseContext(), "Network Error. Please Try Again", Toast.LENGTH_LONG).show();
			else
			{
				try
				{
					JSONObject jsonObject1=new JSONObject(result);
					JSONArray jsonArray1=jsonObject1.getJSONArray("Table");
					for(int i=0;i<jsonArray1.length();i++)
					{
						JSONObject jsonObject2=(JSONObject)jsonArray1.get(i);
						TextView textView=new TextView(TariffInquiryActivity.this);
						textView.setText(jsonObject2.optString("WARD_NAME") + " -> Rs. " + jsonObject2.optString("WARD_CHARGE"));
						FontUtils.setCustomFont(textView, getAssets());textView.setPadding(0, 20, 0, 20);
						textView.setTextSize(TypedValue.COMPLEX_UNIT_SP, 15);
						linearLayout2.addView(textView);
					}
				}
				catch (Exception e)
				{
					Log.d("TAG_FILTER", e.toString());
				}
			}
		}
	}
	
	private class GetMiscTariffAsyncTask extends AsyncTask<Void, Void, String>
	{
		@Override
		protected void onPreExecute()
		{
			progressDialog3=ProgressDialog.show(TariffInquiryActivity.this, "Loading", "Retrieving Misc. Tariff...");
		}
		@Override
		protected String doInBackground(Void... params)
		{
			SoapObject request = new SoapObject(NAMESPACE, METHOD_NAME_3);

			SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
			envelope.dotNet = true;
			envelope.setOutputSoapObject(request);
			HttpTransportSE transport = new HttpTransportSE(URL);
			try
			{
				transport.call(SOAP_ACTION_3, envelope);
				String response = envelope.getResponse().toString();
				return response;
			}
			catch (Exception e)
			{
				Log.d("TAG_FILTER", e.toString());
				return e.toString();
			}
		}
		
		@Override
		protected void onPostExecute(String result)
		{
			progressDialog3.dismiss();
			if (result.equals("org.ksoap2.SoapFault"))
				Toast.makeText(getBaseContext(), "Internal Error. Please Try Again.", Toast.LENGTH_LONG).show();
			else if (result.equals("java.net.SocketTimeoutException"))
				Toast.makeText(getBaseContext(), "Network Error. Please Try Again", Toast.LENGTH_LONG).show();
			else
			{
				try
				{
					JSONObject jsonObject1=new JSONObject(result);
					JSONArray jsonArray1=jsonObject1.getJSONArray("Table");
					for(int i=0;i<jsonArray1.length();i++)
					{
						JSONObject jsonObject2=(JSONObject)jsonArray1.get(i);
						TextView textView=new TextView(TariffInquiryActivity.this);
						textView.setText(jsonObject2.optString("SERVICE_TYPE") + " -> Rs. " + jsonObject2.optString("TARIFF"));
						FontUtils.setCustomFont(textView, getAssets());textView.setPadding(0, 20, 0, 20);
						textView.setTextSize(TypedValue.COMPLEX_UNIT_SP, 15);
						linearLayout3.addView(textView);
					}
				}
				catch (Exception e)
				{
					Log.d("TAG_FILTER", e.toString());
				}
			}
		}
	}
}