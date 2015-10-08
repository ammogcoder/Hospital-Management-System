package com.example.hms_app;

import java.util.Calendar;

import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.PropertyInfo;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapPrimitive;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

import android.app.ActionBar;
import android.app.Activity;
import android.app.DatePickerDialog;
import android.app.ProgressDialog;
import android.content.Context;
import android.graphics.Color;
import android.graphics.Typeface;
import android.graphics.drawable.ColorDrawable;
import android.os.AsyncTask;
import android.os.Bundle;
import android.transition.Visibility;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

public class RequestPasswordActivity extends Activity {

	private ProgressDialog progressDialog;
	
	private static final String SOAP_ACTION_1="http://tempuri.org/RequestPassword";
	private static final String METHOD_NAME_1="RequestPassword";
	
	private EditText phoneNumberEditText;
	private EditText dobEditText;
	
	private DatePickerDialog datePickerDialog;
	
	private static boolean ISVALID;
	
	private TextView textview_password;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_request_password);
		setUpLayout();
	}
	
	private void setUpLayout()
	{
		getActionBar().setDisplayHomeAsUpEnabled(true);
		textview_password=(TextView)findViewById(R.id.textview_password);
		phoneNumberEditText=(EditText)findViewById(R.id.edittext_phone);
		dobEditText=(EditText)findViewById(R.id.edittext_dob);
		setUpDatePickerDialog();
	}
	
	private void setUpDatePickerDialog()
	{
		ActionBar actionBar=getActionBar();
		actionBar.setBackgroundDrawable(new ColorDrawable(Color.parseColor("#00BFFF")));
		actionBar.setDisplayShowCustomEnabled(true);
		actionBar.setDisplayShowTitleEnabled(false);
		actionBar.setIcon(R.drawable.padlock); 
		LayoutInflater inflater=(LayoutInflater)getSystemService(Context.LAYOUT_INFLATER_SERVICE);
		View view=inflater.inflate(R.layout.action_bar_style, null);
		TextView action_bar_title=(TextView)view.findViewById(R.id.action_bar_title);
		Typeface typeface=Typeface.createFromAsset(getAssets(), "fonts/cooper.ttf");
		action_bar_title.setTypeface(typeface);
		action_bar_title.setText("Request New Password");
		actionBar.setCustomView(view);
		Calendar cal=Calendar.getInstance();
		final int y=cal.get(Calendar.YEAR);
		final int m=cal.get(Calendar.MONTH);
		final int d=cal.get(Calendar.DAY_OF_MONTH);
		
		dobEditText.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				datePickerDialog = new DatePickerDialog(RequestPasswordActivity.this, new DatePickerDialog.OnDateSetListener() 
				{
				 
				            @Override
				            public void onDateSet(DatePicker view, int year,
				                    int monthOfYear, int dayOfMonth) 
				            {
				                dobEditText.setText(dayOfMonth + "/"
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
		dobEditText.setText(d + "/" + m + "/" + year);
	}
	
	private class RequestPasswordAsyncTask extends AsyncTask<String, Void, String>
	{
		@Override
		protected void onPreExecute() {
			progressDialog=ProgressDialog.show(RequestPasswordActivity.this, "Loading", "Requesting New Password...");
		}
		@Override
		protected String doInBackground(String... params) {
			SoapObject request=new SoapObject(getResources().getString(R.string.NAMESPACE), METHOD_NAME_1);
			
			PropertyInfo phoneProperty=new PropertyInfo();
			phoneProperty.setName("patientPhone");
			phoneProperty.setValue(params[0]);
			phoneProperty.setType(String.class);
			request.addProperty(phoneProperty);
			
			PropertyInfo dobProperty=new PropertyInfo();
			dobProperty.setName("patientDOB");
			dobProperty.setValue(params[1]);
			dobProperty.setType(String.class);
			request.addProperty(dobProperty);
			
			SoapSerializationEnvelope envelope=new SoapSerializationEnvelope(SoapEnvelope.VER11);
			envelope.setOutputSoapObject(request);
			envelope.dotNet=true;
			HttpTransportSE transport=new HttpTransportSE(getResources().getString(R.string.URL));
			try
			{
				transport.call(SOAP_ACTION_1, envelope);
				SoapPrimitive primitive=(SoapPrimitive)envelope.getResponse();
				String response=primitive.toString();
				return response;
			}
			catch(Exception e)
			{				
				Log.e("T", "EXCEPTION", e);
				return e.getClass().getName();
			}
		}
		@Override
		protected void onPostExecute(String result) {
			progressDialog.dismiss();
			if(result.equals("org.ksoap2.SoapFault"))
				Toast.makeText(getBaseContext(), "Invalid Phone No./DOB", Toast.LENGTH_LONG).show();
			else if(result.equals("java.net.SocketTimeoutException")) 
				Toast.makeText(getBaseContext(), "Network Error. Please Try Again", Toast.LENGTH_LONG).show();
			else
			{
				LinearLayout linearLayout=new LinearLayout(RequestPasswordActivity.this);
				linearLayout=(LinearLayout)findViewById(R.id.linearlayout1);
				linearLayout.setVisibility(View.VISIBLE);
				textview_password.setText("Your password is: " + result);
			}
		}
	}
	private void validate()
	{
		if(phoneNumberEditText.getText().toString().equals(""))
		{
			phoneNumberEditText.setError("Phone No. cannot be blank");
			ISVALID=false;
		}
		else
			ISVALID=true;
		if(phoneNumberEditText.getText().toString().length()<10&&phoneNumberEditText.getText().toString().length()>0)
		{
			phoneNumberEditText.setError("Enter Phone No. in correct format");
			ISVALID=false;
		}
		else
			ISVALID=true;
		if(dobEditText.getText().toString().equals(""))
		{
			dobEditText.setError("Date Of Birth cannot be blank");
			ISVALID=false;
		}
		else
			ISVALID=true;
	}
	public void button_retrieve_token_onClick(View v)
	{
		//validate();
		//if(ISVALID==true)
		{
			String patientPhoneNumber=phoneNumberEditText.getText().toString();
			String patientDOB=dobEditText.getText().toString();
			RequestPasswordAsyncTask objRequestPasswordAsyncTask=new RequestPasswordAsyncTask();
			objRequestPasswordAsyncTask.execute(patientPhoneNumber, patientDOB);
		}
	}
}
