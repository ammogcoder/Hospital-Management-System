package com.example.hms_app;

import java.util.Calendar;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;
import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.PropertyInfo;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapPrimitive;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

import android.app.ActionBar;
import android.app.Activity;
import android.app.AlertDialog;
import android.app.DatePickerDialog;
import android.app.DatePickerDialog.OnDateSetListener;
import android.app.Dialog;
import android.app.ProgressDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.content.SharedPreferences.Editor;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Typeface;
import android.graphics.drawable.ColorDrawable;
import android.net.ConnectivityManager;
import android.os.AsyncTask;
import android.os.Bundle;
import android.text.Editable;
import android.text.InputType;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.MotionEvent;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnTouchListener;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.CompoundButton.OnCheckedChangeListener;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends Activity {

	private EditText passwordEditText;
	private EditText phoneNumberEditText;
	
	private TextView requestPasswordTextView; 
	private TextView textview_signup;
	private TextView textview_request_password;
	
	private DatePickerDialog datepickerDialog;
	
	private EditText dobEditText;
	
	private static boolean ISVALID;
	
	private ProgressDialog progressDialog;
	
	private static final String SOAP_ACTION_1="http://tempuri.org/Login";    
	private static final String METHOD_NAME_1="Login";
	
	private static int NETWORK=0;
	
	private CheckBox checkbox_remember;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main); 
		setUpLayout();		
		GetSavedCredentials();
	}           
	
	private void setUpLayout() {
		ActionBar actionBar=getActionBar();
		actionBar.setBackgroundDrawable(new ColorDrawable(Color.parseColor("#00BFFF")));
		actionBar.setDisplayShowCustomEnabled(true);
		actionBar.setDisplayShowTitleEnabled(false);
		actionBar.setIcon(R.drawable.hospital);
		LayoutInflater inflater=(LayoutInflater)getSystemService(Context.LAYOUT_INFLATER_SERVICE);
		View view=inflater.inflate(R.layout.action_bar_style, null);
		TextView action_bar_title=(TextView)view.findViewById(R.id.action_bar_title);
		Typeface typeface=Typeface.createFromAsset(getAssets(), "fonts/cooper.ttf");
		action_bar_title.setTypeface(typeface);
		action_bar_title.setText("Hospital Management System");
		actionBar.setCustomView(view); 
		/*ActionBarConfig actionBarConfig=new ActionBarConfig();
		actionBarConfig.Config(getBaseContext(), getActionBar());*/
		passwordEditText=(EditText)findViewById(R.id.edittext_password);
		phoneNumberEditText=(EditText)findViewById(R.id.edittext_phone);
		requestPasswordTextView=(TextView)findViewById(R.id.textview_request_password);
		checkbox_remember=(CheckBox)findViewById(R.id.checkbox_remember);
		textview_request_password=(TextView)findViewById(R.id.textview_request_password);
		textview_request_password.setPaintFlags(textview_request_password.getPaintFlags()|Paint.UNDERLINE_TEXT_FLAG);
	}      
	
	public void textview_request_password_onClick(View v)
	{		
		Intent intent=new Intent(MainActivity.this, RequestPasswordActivity.class);
		startActivity(intent);
	}      
	
	public void button_retrieve_onClick(View v)
	{
		Toast.makeText(getBaseContext(), "Hello", Toast.LENGTH_LONG).show();
	}
	
	public void textview_signup_onClick(View v)
	{
		textview_signup=(TextView)findViewById(R.id.textview_signup);
		textview_signup.setPaintFlags(textview_signup.getPaintFlags()|Paint.UNDERLINE_TEXT_FLAG);
		Intent intent=new Intent(MainActivity.this, RegisterPatientActivity.class);
		startActivity(intent);
	}	 
	
	private void validate()      
	{    
		if(passwordEditText.getText().toString().equals(""))
		{
			passwordEditText.setError("Password cannot be blank");
			ISVALID=false;
		}
		else
			ISVALID=true;
		if(phoneNumberEditText.getText().toString().equals(""))
		{
			phoneNumberEditText.setError("Phone No. cannot be blank");
			ISVALID=false;
		}
		else
			ISVALID=true;
		/*if(phoneNumberEditText.getText().toString().length()<10&&phoneNumberEditText.getText().toString().length()>0)
		{
			phoneNumberEditText.setError("Enter Phone No. in correct format");
			ISVALID=false;
		}
		else
			ISVALID=true;*/
	}
	
	private class LoginAsyncTaskClass extends AsyncTask<String, Void, String>
	{

		@Override
		protected void onPreExecute()
		{
			progressDialog=ProgressDialog.show(MainActivity.this,  "Loading", "Logging In...");
		}
		protected String doInBackground(String... params)
		{
			SoapObject request=new SoapObject(getResources().getString(R.string.NAMESPACE), METHOD_NAME_1);  
			
			PropertyInfo patientPhoneProperty=new PropertyInfo();
			patientPhoneProperty.setName("patientPhone");
			patientPhoneProperty.setValue(params[0]);
			patientPhoneProperty.setType(String.class);
			request.addProperty(patientPhoneProperty); 
			
			PropertyInfo patientPasswordProperty=new PropertyInfo(); 
			patientPasswordProperty.setName("patientPassword");
			patientPasswordProperty.setValue(params[1]);
			patientPasswordProperty.setType(String.class);
			request.addProperty(patientPasswordProperty);
			
			SoapSerializationEnvelope envelope=new SoapSerializationEnvelope(SoapEnvelope.VER11);
			envelope.dotNet=true;
			envelope.setOutputSoapObject(request);
			HttpTransportSE transport=new HttpTransportSE(getResources().getString(R.string.URL));
			try
			{
				transport.call(SOAP_ACTION_1, envelope);
				SoapPrimitive response=(SoapPrimitive)envelope.getResponse();
				return response.toString();
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
				Toast.makeText(getBaseContext(), "Invalid Phone No./Password.", Toast.LENGTH_LONG).show();
			else if(result.equals("java.net.SocketTimeoutException")) 
				Toast.makeText(getBaseContext(), "Network Error. Please Try Again", Toast.LENGTH_LONG).show();
			else
			{
				try 
				{
					JSONObject jsonObject1=new JSONObject(result);
					JSONArray array1=jsonObject1.getJSONArray("Table");
					JSONObject jsonObject2=new JSONObject(array1.getString(0));
					SharedPreferences sharedPreferences=getSharedPreferences("HMS", Context.MODE_PRIVATE);
					SharedPreferences.Editor editor=sharedPreferences.edit();
					editor.putString("patientId", jsonObject2.optString("PATIENT_ID_FK"));
					editor.putString("patientName", jsonObject2.optString("PATIENT_FIRST_NAME"));					
					editor.commit();
					Intent intent=new Intent(MainActivity.this, HomeActivity.class);
					startActivity(intent);
				}      
				catch (Exception e)
				{
					Log.d("TAG_FILTER", e.toString());
				}		
			}
		}
	}
	
	private void checkNetwork()
	{
		ConnectivityManager connectivityManager=(ConnectivityManager)this.getSystemService(Context.CONNECTIVITY_SERVICE);
		if(connectivityManager.getActiveNetworkInfo()!=null&&connectivityManager.getActiveNetworkInfo().isConnected()&&connectivityManager.getActiveNetworkInfo().isAvailable())
			NETWORK=1;
		else
			displayNetworkErrorDialog();
	}
	
	private void displayNetworkErrorDialog()
	{
		AlertDialog.Builder builder=new AlertDialog.Builder(MainActivity.this);
		builder.setTitle("Network Error")
			   .setMessage("No internet connection found. Please check your network settings.")
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
	 
	private void GetSavedCredentials()
	{
		SharedPreferences sharedPreferences=getSharedPreferences("HMS", Context.MODE_PRIVATE);
		String username=sharedPreferences.getString("username", "-1");
		String password=sharedPreferences.getString("password", "-1");
		if(!username.equals("-1")&&!password.equals("-1"))
		{
			phoneNumberEditText.setText(username);
			passwordEditText.setText(password);
			checkbox_remember.setChecked(true); 
		}
		else if(username.equals("-1")&&password.equals("-1"))
		{
			phoneNumberEditText.setText("");
			passwordEditText.setText("");
			checkbox_remember.setChecked(false); 
		}
	}
	 
	private void CheckRememberMe()
	{
		if(checkbox_remember.isChecked())
		{
			SharedPreferences sharedPreferences=getSharedPreferences("HMS", Context.MODE_PRIVATE);  
			Editor editor=sharedPreferences.edit(); 
			editor.putString("username", phoneNumberEditText.getText().toString());
			editor.putString("password", passwordEditText.getText().toString());
			editor.commit();
		}
		if(!checkbox_remember.isChecked())
		{
			SharedPreferences sharedPreferences=getSharedPreferences("HMS", Context.MODE_PRIVATE); 
			Editor editor=sharedPreferences.edit();
			editor.putString("username", "-1");
			editor.putString("password", "-1");
			editor.commit();
		}
	}
	
	public void button_login_onClick(View v)
	{
		validate();
		if(ISVALID==true)
		{
			checkNetwork();
			if(NETWORK==1)
			{
				CheckRememberMe();
				LoginAsyncTaskClass objLoginAsyncTaskClass=new LoginAsyncTaskClass();
				objLoginAsyncTaskClass.execute(phoneNumberEditText.getText().toString(), passwordEditText.getText().toString());
			}
		}
	}
}
