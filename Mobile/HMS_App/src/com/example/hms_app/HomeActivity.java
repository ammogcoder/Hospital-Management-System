package com.example.hms_app;

import org.json.JSONException;
import org.json.JSONObject;
import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.PropertyInfo;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

import com.sentaca.android.accordion.AccordionWidgetDemoActivity;

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
import android.view.View;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.GridView;
import android.widget.TextView;
import android.widget.Toast;

public class HomeActivity extends Activity {

	private TextView textView1;
	private TextView textView2;
	private TextView textView3;
	
	private String patientName;
	private String patientId;
	
	private ProgressDialog progressDialog1;
	private ProgressDialog progressDialog2;
	
	private static final String SOAP_ACTION_1="http://tempuri.org/GetUpcomingAppointmentsCount";
	private static final String SOAP_ACTION_2="http://tempuri.org/GetUpcomingMedicalTestsCount";
	private static final String METHOD_NAME_1="GetUpcomingAppointmentsCount";
	private static final String METHOD_NAME_2="GetUpcomingMedicalTestsCount";  
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_home);
		SharedPreferences sharedPreferences=getSharedPreferences("HMS", Context.MODE_PRIVATE);
		patientId=sharedPreferences.getString("patientId", "-1");
		patientName=sharedPreferences.getString("patientName", "-1");
		setUpLayout();
		GetUpcomingAppointmentsAsyncTask objGetUpcomingAppointmentsAsyncTask=new GetUpcomingAppointmentsAsyncTask();
		objGetUpcomingAppointmentsAsyncTask.execute(patientId);
		GetUpcomingMedicalTestsAsyncTask objGetUpcomingMedicalTestsAsyncTask=new GetUpcomingMedicalTestsAsyncTask();
		objGetUpcomingMedicalTestsAsyncTask.execute(patientId);
	}
	
	private void setUpLayout()
	{
		ActionBar actionBar=getActionBar();
		actionBar.setBackgroundDrawable(new ColorDrawable(Color.parseColor("#00BFFF")));
		actionBar.setDisplayShowCustomEnabled(true);
		actionBar.setDisplayShowTitleEnabled(false);
		actionBar.setIcon(R.drawable.home);
		LayoutInflater inflater=(LayoutInflater)getSystemService(Context.LAYOUT_INFLATER_SERVICE);
		View view=inflater.inflate(R.layout.action_bar_style, null);
		TextView action_bar_title=(TextView)view.findViewById(R.id.action_bar_title);
		Typeface typeface=Typeface.createFromAsset(getAssets(), "fonts/cooper.ttf");
		action_bar_title.setTypeface(typeface);
		action_bar_title.setText("Home");
		actionBar.setCustomView(view);
		textView1=(TextView)findViewById(R.id.textview1);
		textView1.setText("Welcome, " + patientName);
		Typeface.createFromAsset(getAssets(), "fonts/comic.ttf");
		textView1.setTypeface(typeface);
		textView2=(TextView)findViewById(R.id.textview2);
		textView3=(TextView)findViewById(R.id.textview3);
		GridView gridview1=(GridView)findViewById(R.id.gridView1);
		gridview1.setAdapter(new HomeActivityBaseAdapter(HomeActivity.this));
		gridview1.setOnItemClickListener(new OnItemClickListener() {

			@Override
			public void onItemClick(AdapterView<?> parent, View view,
					int position, long id) {
				
				Intent intent;
				switch(position) 
				{
				case 0:
					intent=new Intent(HomeActivity.this, DiagnosisScheduleActivity.class); 
					startActivity(intent);
					break;
				case 1:
					intent=new Intent(HomeActivity.this, NewAppointmentActivity.class);
					startActivityForResult(intent, 1);
					break;
				case 2:
					intent=new Intent(HomeActivity.this, AccordionWidgetDemoActivity.class);
					startActivityForResult(intent, 2);
					break;
				case 3:
					intent=new Intent(HomeActivity.this, TariffInquiryActivity.class);
					startActivity(intent);
					break;
				}
			}
		});
	}
	
	private class GetUpcomingMedicalTestsAsyncTask extends AsyncTask<String, Void, String>
	{
		
		@Override
		protected void onPreExecute()
		{
			progressDialog2=ProgressDialog.show(HomeActivity.this, "Loading", "Retrieving Upcoming Medical Tests...");
		}
		
		@Override
		protected String doInBackground(String... params)
		{
			SoapObject request=new SoapObject(getResources().getString(R.string.NAMESPACE), METHOD_NAME_2);
			
			PropertyInfo patientIdProperty=new PropertyInfo();
			patientIdProperty.setName("patientId");
			patientIdProperty.setValue(patientId);
			patientIdProperty.setType(String.class); 
			request.addProperty(patientIdProperty);
			
			SoapSerializationEnvelope envelope=new SoapSerializationEnvelope(SoapEnvelope.VER11);
			envelope.dotNet=true;
			envelope.setOutputSoapObject(request);
			HttpTransportSE transport=new HttpTransportSE(getResources().getString(R.string.URL));
			try
			{
				transport.call(SOAP_ACTION_2, envelope);
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
			progressDialog2.dismiss();
			if(result.equals("org.ksoap2.SoapFault"))
				Toast.makeText(getBaseContext(), "Internal Error. Please Try Again.", Toast.LENGTH_LONG).show();
			else if(result.equals("java.net.SocketTimeoutException")) 
				Toast.makeText(getBaseContext(), "Network Error. Please Try Again", Toast.LENGTH_LONG).show();
			else
			{
				try
				{
					JSONObject jsonObject1=new JSONObject(result);
					String medicalTestCount=jsonObject1.optString("medicalTestCount");
					if(Integer.valueOf(medicalTestCount)!=0)
						textView3.setText("You have " + Html.fromHtml("<b>" + medicalTestCount + "</b>") + " upcoming medical tests");
					else
						textView3.setText("You have not scheduled a medical test");
				}
				catch (Exception e)
				{
					Log.d("TAG_FILTER", e.toString());
				}
				
			}
		}
	}
	
	private class GetUpcomingAppointmentsAsyncTask extends AsyncTask<String, Void, String>
	{
		@Override
		protected void onPreExecute()
		{
			progressDialog1=ProgressDialog.show(HomeActivity.this, "Loading", "Retrieving Upcoming Appointments...");
		}
		
		@Override
		protected String doInBackground(String... params)
		{
			SoapObject request=new SoapObject(getResources().getString(R.string.NAMESPACE), METHOD_NAME_1);
			
			PropertyInfo patientIdProperty=new PropertyInfo();
			patientIdProperty.setName("patientId");
			patientIdProperty.setValue(patientId);
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
					String appointmentCount=jsonObject1.optString("appointmentCount");
					if(Integer.valueOf(appointmentCount)!=0)
						textView2.setText("You have " + Html.fromHtml("<b>" + appointmentCount + "</b>") + " upcoming appointments");
					else
						textView2.setText("You have not scheduled an appointment");
				}
				catch (Exception e)
				{
					Log.d("TAG_FILTER", e.toString());
				}
				
			}
		}
	}

	@Override
	protected void onActivityResult(int requestCode, int resultCode, Intent data)
	{
		if(requestCode==1)
		{
			if(resultCode==RESULT_OK)
			{
				GetUpcomingAppointmentsAsyncTask objGetUpcomingAppointmentsAsyncTask=new GetUpcomingAppointmentsAsyncTask();
				objGetUpcomingAppointmentsAsyncTask.execute(patientId);
			}
		}
		else if(requestCode==2)
		{
			if(resultCode==RESULT_OK)
				Toast.makeText(getBaseContext(), "Medical Test(s) Scheduled", Toast.LENGTH_LONG).show();
			GetUpcomingMedicalTestsAsyncTask objGetUpcomingMedicalTestsAsyncTask=new GetUpcomingMedicalTestsAsyncTask();
			objGetUpcomingMedicalTestsAsyncTask.execute(patientId);
		}
	}
}
