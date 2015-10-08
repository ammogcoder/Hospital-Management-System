package com.example.hms_app;

import java.util.ArrayList;
import java.util.List;

import org.json.JSONArray;
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
import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.Color;
import android.graphics.Typeface;
import android.graphics.drawable.ColorDrawable;
import android.os.AsyncTask;
import android.os.Bundle;
import android.text.Html;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

public class UpcomingAppointmentsActivity extends Activity
{	
	private ListView listView;
	
	private List<String> appointmentDateList=new ArrayList<String>();
	private List<String> appointmentTimeList=new ArrayList<String>();
	private List<String> doctorList=new ArrayList<String>();
	private List<String> appointmentTokenList=new ArrayList<String>();
	
	private ProgressDialog progressDialog1;
	
	private static final String SOAP_ACTION_1="http://tempuri.org/GetUpcomingAppointments";
	private static final String METHOD_NAME_1="GetUpcomingAppointments";
	
	@Override
	protected void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_upcoming_appointments);
		SharedPreferences sharedPreferences=getSharedPreferences("HMS", Context.MODE_PRIVATE);
		String patientId=sharedPreferences.getString("patientId", "-1");
		setUpLayout();
		GetUpcomingAppointmentsAsyncTask objGetUpcomingAppointmentsAsyncTask=new GetUpcomingAppointmentsAsyncTask();
		objGetUpcomingAppointmentsAsyncTask.execute(patientId);
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
		action_bar_title.setText("Upcoming Appointments");
		actionBar.setCustomView(view);  
		listView=(ListView)findViewById(R.id.listview1);
		listView.setOnItemClickListener(new OnItemClickListener()
		{

			@Override
			public void onItemClick(AdapterView<?> parent, View view,
					int position, long id)
			{
				TextView textView=(TextView)view.findViewById(R.id.textview_doctor_name);
				Intent intent=new Intent(UpcomingAppointmentsActivity.this, UpcomingAppointmentDetailsActivity.class);
				intent.putExtra("appointmentToken", textView.getTag().toString());
				startActivity(intent);
			}
		});
	}
	
	private class GetUpcomingAppointmentsAsyncTask extends AsyncTask<String, Void, String>
	{
		@Override
		protected void onPreExecute()
		{
			progressDialog1=ProgressDialog.show(UpcomingAppointmentsActivity.this, "Loading", "Retrieving Upcoming Appointments...");
		}
		
		@Override
		protected String doInBackground(String... params)
		{
			SoapObject request=new SoapObject(getResources().getString(R.string.NAMESPACE), METHOD_NAME_1);
			
			PropertyInfo patientIdProperty=new PropertyInfo();
			patientIdProperty.setName("patientId");
			patientIdProperty.setValue(params[0]);
			patientIdProperty.setType(String.class); 
			request.addProperty(patientIdProperty);
			
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
					JSONArray jsonArray=jsonObject1.getJSONArray("Table");
					if(jsonArray.length()==0)
						Toast.makeText(getBaseContext(), "No Appointment Scheduled", Toast.LENGTH_LONG).show();
					else
					{
						for(int i=0;i<jsonArray.length();i++)
						{
							JSONObject jsonObject2=jsonArray.getJSONObject(i);
							appointmentDateList.add(jsonObject2.optString("APPOINTMENT_DATE"));
							appointmentTimeList.add(jsonObject2.optString("APPOINTMENT_TIME"));
							appointmentTokenList.add(jsonObject2.optString("APPOINTMENT_TOKEN"));
							doctorList.add(jsonObject2.optString("DOCTOR_NAME"));
						}
						listView.setAdapter(new UpcomingAppointmentsAdapter(UpcomingAppointmentsActivity.this, appointmentDateList, appointmentTimeList, doctorList, appointmentTokenList));
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
