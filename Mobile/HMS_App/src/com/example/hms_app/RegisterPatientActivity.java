package com.example.hms_app;

import java.util.ArrayList;
import java.util.Calendar;

import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.PropertyInfo;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

import android.app.ActionBar;
import android.app.Activity;
import android.app.AlertDialog;
import android.app.DatePickerDialog;
import android.app.DatePickerDialog.OnDateSetListener;
import android.app.ProgressDialog;
import android.content.ContentValues;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.Color;
import android.graphics.Typeface;
import android.graphics.drawable.ColorDrawable;
import android.net.ConnectivityManager;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnTouchListener;
import android.widget.ArrayAdapter;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

public class RegisterPatientActivity extends Activity {

	private EditText patientNameEditText;
	private EditText patientDOBEditText;
	private EditText patientPhoneEditText;
	private EditText patientAddressEditText;
	private Spinner genderSpinner;
	private static boolean ISVALID;
	private DatePickerDialog datePickerDialog;
	private ArrayList<GenderClass> genderList;
	private static final String SOAP_ACTION_1="http://www.tempuri.org/RegisterPatient";
	private static final String METHOD_NAME_1="RegisterPatient";
	private ProgressDialog progressDialog;
	private static int NETWORK=0;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_register_patient);
		setUpLayout();
	}
	
	private void setUpLayout()
	{
		ActionBar actionBar=getActionBar();
		actionBar.setBackgroundDrawable(new ColorDrawable(Color.parseColor("#00BFFF")));
		actionBar.setDisplayShowCustomEnabled(true);
		actionBar.setDisplayShowTitleEnabled(false);
		actionBar.setIcon(R.drawable.add_user);
		LayoutInflater inflater=(LayoutInflater)getSystemService(Context.LAYOUT_INFLATER_SERVICE);
		View view=inflater.inflate(R.layout.action_bar_style, null);
		TextView action_bar_title=(TextView)view.findViewById(R.id.action_bar_title);
		Typeface typeface=Typeface.createFromAsset(getAssets(), "fonts/cooper.ttf");
		action_bar_title.setTypeface(typeface);
		action_bar_title.setText("Register New Patient");
		actionBar.setCustomView(view);
		actionBar.setDisplayHomeAsUpEnabled(true);
		patientNameEditText=(EditText)findViewById(R.id.edittext_name);
		genderSpinner=(Spinner)findViewById(R.id.spinner_gender);
		patientDOBEditText=(EditText)findViewById(R.id.edittext_dob);
		patientPhoneEditText=(EditText)findViewById(R.id.edittext_phone);
		patientAddressEditText=(EditText)findViewById(R.id.edittext_address);
		setUpDatePickerDialog();
		genderList=new ArrayList<GenderClass>();
		genderList.add(new GenderClass("--Select--", "-1"));
		genderList.add(new GenderClass("Male", "M"));
		genderList.add(new GenderClass("Female", "F"));
		ArrayAdapter<GenderClass> genderAdapter=new ArrayAdapter<GenderClass>(RegisterPatientActivity.this, R.layout.simple_spinner_item, genderList);
		genderSpinner.setAdapter(genderAdapter);
	}
	
	private void setUpDatePickerDialog()
	{
		Calendar cal=Calendar.getInstance();
		final int y=cal.get(Calendar.YEAR);
		final int m=cal.get(Calendar.MONTH);
		final int d=cal.get(Calendar.DAY_OF_MONTH);
		
		patientDOBEditText.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				datePickerDialog = new DatePickerDialog(RegisterPatientActivity.this, new DatePickerDialog.OnDateSetListener() 
				{
				 
				            @Override
				            public void onDateSet(DatePicker view, int year,
				                    int monthOfYear, int dayOfMonth) 
				            {
				                patientDOBEditText.setText(dayOfMonth + "/"
				                        + (monthOfYear)+1 + "/" + year);
				                checkDate(dayOfMonth, monthOfYear+1, year);
				            }
				        }, y, m, d);
				datePickerDialog.show();	
			}
		});
	}
	
	private void checkDate(int day, int month, int year)
	{
		String d=String.valueOf(day);
		String m=String.valueOf(month);
		if(day/10==0)
			d="0" + String.valueOf(day);
		if(month/10==0)
			m="0" + String.valueOf(month);
		patientDOBEditText.setText(d + "/" + m + "/" + year);
	}
	
	private void validate()
	{
		if(patientNameEditText.getText().toString().equals(""))
		{
			patientNameEditText.setError("Name cannot be blank");
			ISVALID=false;
		}
		else
			ISVALID=true;
		if(patientDOBEditText.getText().toString().equals(""))
		{
			patientDOBEditText.setError("DOB cannot be blank");
			ISVALID=false;
		}
		else
			ISVALID=true;
		if(patientPhoneEditText.getText().toString().equals(""))
		{
			patientPhoneEditText.setError("Phone No. cannot be blank");
			ISVALID=false;
		}
		else
			ISVALID=true;
		if(patientAddressEditText.getText().toString().equals(""))
		{
			patientAddressEditText.setError("Address cannot be blank");
			ISVALID=false;
		}
		else
			ISVALID=true;
	}
	
	private class RegisterPatientAsyncTask extends AsyncTask<String, Void, String>
	{
		@Override
		protected void onPreExecute()
		{
			progressDialog=progressDialog.show(RegisterPatientActivity.this, "Loading", "Registering Patient...");
		}
		@Override
		protected String doInBackground(String... params)
		{
			SoapObject request=new SoapObject(getResources().getString(R.string.NAMESPACE), METHOD_NAME_1);
			
			PropertyInfo patientNameProperty=new PropertyInfo();
			patientNameProperty.setName("patientName");
			patientNameProperty.setValue(params[0]);
			patientNameProperty.setType(String.class);
			request.addProperty(patientNameProperty);
			
			PropertyInfo patientGenderProperty=new PropertyInfo();
			patientGenderProperty.setName("patientGender");
			patientGenderProperty.setValue(params[1]);
			patientGenderProperty.setType(String.class);
			request.addProperty(patientGenderProperty);
			
			PropertyInfo patientDOBProperty=new PropertyInfo();
			patientDOBProperty.setName("patientDOB");
			patientDOBProperty.setValue(params[2]);
			patientDOBProperty.setType(String.class);
			request.addProperty(patientDOBProperty);
			
			PropertyInfo patientPhoneProperty=new PropertyInfo();
			patientPhoneProperty.setName("patientPhone");
			patientPhoneProperty.setValue(params[3]);
			patientPhoneProperty.setType(String.class);
			request.addProperty(patientPhoneProperty);
			
			PropertyInfo patientAddressProperty=new PropertyInfo();
			patientAddressProperty.setName("patientAddress");
			patientAddressProperty.setValue(params[4]);
			patientAddressProperty.setType(String.class);
			request.addProperty(patientAddressProperty);
			
			PropertyInfo patientRegisteredByIdProperty=new PropertyInfo();
			patientRegisteredByIdProperty.setName("patientRegisteredById");
			patientRegisteredByIdProperty.setValue(0);
			patientRegisteredByIdProperty.setType(Integer.class);
			request.addProperty(patientRegisteredByIdProperty);
			
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
				Log.e("T", "EXCEPTION", e);
				return e.getClass().getName();
			}
		}
		@Override
		protected void onPostExecute(String result)
		{
			progressDialog.dismiss();
			if(result.equals("org.ksoap2.SoapFault"))
				Toast.makeText(getBaseContext(), "Internal Error. Please Try Again.", Toast.LENGTH_LONG).show();
			else if(result.equals("java.net.SocketTimeoutException")) 
				Toast.makeText(getBaseContext(), "Network Error. Please Try Again", Toast.LENGTH_LONG).show();
			else
			{
				SharedPreferences sharedPreferences=getSharedPreferences("HMS", Context.MODE_PRIVATE);
				SharedPreferences.Editor editor=sharedPreferences.edit();
				editor.putInt("patientId", Integer.valueOf(result));
				editor.putString("patientName", patientNameEditText.getText().toString());
				editor.commit();
				Intent intent=new Intent(RegisterPatientActivity.this, HomeActivity.class);
				startActivity(intent);
			} 
		}
	}
	private void checkNetwork()
	{
		ConnectivityManager connectivityManager=(ConnectivityManager)this.getSystemService(Context.CONNECTIVITY_SERVICE);
		if(connectivityManager.getActiveNetworkInfo()!=null&&connectivityManager.getActiveNetworkInfo().isAvailable()&&connectivityManager.getActiveNetworkInfo().isConnected())
			NETWORK=1;
		else
			displayNetworkErrorDialog();
	}
	private void displayNetworkErrorDialog()
	{
		AlertDialog.Builder builder=new AlertDialog.Builder(RegisterPatientActivity.this);
		builder.setTitle("Network Error")
			   .setMessage("No internet connection found. Please check your network settings.")
			   .setCancelable(false)
			   .setPositiveButton("Cancel", new DialogInterface.OnClickListener()
				{
					
					@Override
					public void onClick(DialogInterface dialog, int which)
					{
						dialog.cancel();
					}
				})
				.setNegativeButton("Enable Mobile Data", new DialogInterface.OnClickListener()
				{
					
					@Override
					public void onClick(DialogInterface dialog, int which)
					{
						startActivity(new Intent(android.provider.Settings.ACTION_DATA_ROAMING_SETTINGS));
					}
				})
				.setNeutralButton("Enable WLAN", new DialogInterface.OnClickListener()
				{
					
					@Override
					public void onClick(DialogInterface dialog, int which)
					{
						startActivity(new Intent(android.provider.Settings.ACTION_WIFI_SETTINGS));
					}
				});
		AlertDialog alertDialog=builder.create();
		alertDialog.show();
	}
	public void button_register_onClick(View v)
	{
		//validate();
		//if(ISVALID==true)
		{
			checkNetwork();
			if(NETWORK==1)
			{
				String patientName=patientNameEditText.getText().toString();
				GenderClass objGenderClass=(GenderClass)genderSpinner.getSelectedItem();
				String patientGender=objGenderClass.genderCode;
				String patientDOB=patientDOBEditText.getText().toString();
				String patientPhone=patientDOBEditText.getText().toString();
				String patientAddress=patientAddressEditText.getText().toString();
				
				RegisterPatientAsyncTask objRegisterPatientAsyncTask=new RegisterPatientAsyncTask();
				objRegisterPatientAsyncTask.execute(patientName, patientGender, patientDOB, patientPhone, patientAddress);
			}
		}
	}
}
