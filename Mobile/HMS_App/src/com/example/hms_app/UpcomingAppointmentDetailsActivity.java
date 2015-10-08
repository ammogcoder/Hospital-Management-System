package com.example.hms_app;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;
import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.PropertyInfo;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

import android.app.ActionBar;
import android.app.Activity;
import android.app.ProgressDialog;
import android.content.Context;
import android.graphics.Color;
import android.graphics.Typeface;
import android.graphics.drawable.ColorDrawable;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

public class UpcomingAppointmentDetailsActivity extends Activity
{
	private static final String SOAP_ACTION_1="http://tempuri.org/GetAppointmentDetails";
	private static final String METHOD_NAME_1="GetAppointmentDetails";
	
	private ProgressDialog progressDialog1;
	
	private TextView appointmentTokenTextView;
	private TextView doctorNameTextView;
	private TextView appointmentDateTextView;
	private TextView appointmentTimeTextView;
	private TextView problemBodyPartTextView;
	private TextView problemDetailsTextView;
	
	@Override
	protected void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_upcoming_appointment_details);
		setUpLayout();
		GetUpcomingAppointmentDetailsAsyncTask objAppointmentDetailsAsyncTask=new GetUpcomingAppointmentDetailsAsyncTask();
		objAppointmentDetailsAsyncTask.execute(getIntent().getExtras().getString("appointmentToken"));
	}
	
	private void setUpLayout()
	{
		ActionBar actionBar=getActionBar();
		actionBar.setDisplayHomeAsUpEnabled(true);
		actionBar.setBackgroundDrawable(new ColorDrawable(Color.parseColor("#00BFFF")));
		actionBar.setDisplayShowCustomEnabled(true);
		actionBar.setDisplayShowTitleEnabled(false);
		actionBar.setIcon(R.drawable.document);
		LayoutInflater inflater=(LayoutInflater)getSystemService(Context.LAYOUT_INFLATER_SERVICE);
		View view=inflater.inflate(R.layout.action_bar_style, null);
		TextView action_bar_title=(TextView)view.findViewById(R.id.action_bar_title);
		Typeface typeface=Typeface.createFromAsset(getAssets(), "fonts/cooper.ttf");
		action_bar_title.setTypeface(typeface);
		action_bar_title.setText("Appointment Details");
		actionBar.setCustomView(view);  
		
		appointmentTokenTextView=(TextView)findViewById(R.id.textview2);
		doctorNameTextView=(TextView)findViewById(R.id.textview4);
		appointmentDateTextView=(TextView)findViewById(R.id.textview6);
		appointmentTimeTextView=(TextView)findViewById(R.id.textview8);
		problemBodyPartTextView=(TextView)findViewById(R.id.textview10);
		problemDetailsTextView=(TextView)findViewById(R.id.textview12);
	}
	
	private class GetUpcomingAppointmentDetailsAsyncTask extends AsyncTask<String, Void, String>
	{
		
		@Override
		protected void onPreExecute()
		{
			progressDialog1=ProgressDialog.show(UpcomingAppointmentDetailsActivity.this, "Loading", "Retrieving Appointment Details...");
		}
		
		@Override
		protected String doInBackground(String... params)
		{
			SoapObject request=new SoapObject(getResources().getString(R.string.NAMESPACE), METHOD_NAME_1);
			
			PropertyInfo appointmentTokenProperty=new PropertyInfo();
			appointmentTokenProperty.setName("appointmentToken");
			appointmentTokenProperty.setValue(params[0]);
			appointmentTokenProperty.setType(String.class); 
			request.addProperty(appointmentTokenProperty);
			
			SoapSerializationEnvelope envelope=new SoapSerializationEnvelope(SoapEnvelope.VER11);
			envelope.dotNet=true;
			envelope.setOutputSoapObject(request);
			HttpTransportSE transport=new HttpTransportSE(getResources().getString(R.string.URL));
			try
			{
				transport.call(SOAP_ACTION_1, envelope);
				String response=envelope.getResponse().toString();
				return response;
			}
			catch(Exception e)
			{
				Log.d("TAG_FILTER", e.toString());
				return e.toString();
			}
		}
		
		@Override
		protected void onPostExecute(String result)
		{
			progressDialog1.dismiss();
			if(result.equals("org.ksoap2.SoapFault"))
				Toast.makeText(getBaseContext(), "Internal Error. Please Try Again.", Toast.LENGTH_LONG).show();
			else if(result.equals("java.net.SocketTimeoutException")) 
				Toast.makeText(getBaseContext(), "Network Error. Please Try Again", Toast.LENGTH_LONG).show();
			else
			{
				try
				{
					JSONObject jsonObject1=new JSONObject(result);
					JSONArray jsonArray1=jsonObject1.getJSONArray("Table");
					jsonObject1=(JSONObject)jsonArray1.get(0);
					appointmentTokenTextView.setText(jsonObject1.optString("APPOINTMENT_TOKEN"));
					doctorNameTextView.setText(jsonObject1.optString("DOCTOR_NAME"));
					appointmentDateTextView.setText(jsonObject1.optString("APPOINTMENT_DATE"));
					appointmentTimeTextView.setText(jsonObject1.optString("APPOINTMENT_TIME"));
					problemBodyPartTextView.setText(jsonObject1.optString("BODY_PART"));
					problemDetailsTextView.setText(jsonObject1.optString("PROBLEM_DESCRIPTION"));
				}
				catch (Exception e)
				{
					Log.d("TAG_FILTER", e.toString());
				}
				
			}
		}
	}
}
