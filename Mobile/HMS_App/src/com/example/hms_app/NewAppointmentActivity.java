package com.example.hms_app;

import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.List;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;
import org.ksoap2.SoapEnvelope;
import org.ksoap2.SoapFault;
import org.ksoap2.serialization.PropertyInfo;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpResponseException;
import org.ksoap2.transport.HttpTransportSE;
import org.xmlpull.v1.XmlPullParserException;

import android.app.ActionBar;
import android.app.Activity;
import android.app.AlertDialog;
import android.app.DatePickerDialog;
import android.app.DatePickerDialog.OnDateSetListener;
import android.app.ProgressDialog;
import android.app.TimePickerDialog;
import android.app.TimePickerDialog.OnTimeSetListener;
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
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemSelectedListener;
import android.widget.ArrayAdapter;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.HorizontalScrollView;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.TimePicker;
import android.widget.Toast;

public class NewAppointmentActivity extends Activity {
	
	private EditText edittext_appointment_date;
	private EditText edittext_appointment_time;
	private EditText edittext_problem_details;
	
	private TextView textview_appointment_date;
	private TextView textview_appointment_time;
	private TextView textview_department;
	private TextView textview_body_part;
	private TextView textview_problem_details;
	private TextView textview_doctor;
	
	private Spinner spinner_department;
	private Spinner spinner_body_part;
	private Spinner spinner_doctor;
	
	private ProgressDialog progressDialog;
	
	private static final String SOAP_ACTION_1="http://tempuri.org/GetBodyParts";
	private static final String SOAP_ACTION_2="http://tempuri.org/GetDepartments";
	private static final String SOAP_ACTION_3="http://tempuri.org/GetDoctorsByDepartment";
	private static final String SOAP_ACTION_4="http://tempuri.org/CreateAppointment";
	private static final String METHOD_NAME_1="GetBodyParts";
	private static final String METHOD_NAME_2="GetDepartments";
	private static final String METHOD_NAME_3="GetDoctorsByDepartment"; 
	private static final String METHOD_NAME_4="CreateAppointment"; 
	
	private Calendar calendar;
	
	private int year;
	private int month;
	private int day;
	private int hour;
	private int min;
	
	private static int NETWORK=0;
	
	private DatePickerDialog datePickerDialog;
	
	private TimePickerDialog timePickerDialog;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_new_appointment);
		setUpLayout();
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
		action_bar_title.setText("New Appointment");
		actionBar.setCustomView(view);
		calendar=Calendar.getInstance();
		year=calendar.get(Calendar.YEAR);
		month=calendar.get(Calendar.MONTH);
		day=calendar.get(Calendar.DAY_OF_MONTH);
		hour=calendar.get(Calendar.HOUR);
		min=calendar.get(Calendar.MINUTE);
		
		edittext_appointment_date=(EditText)findViewById(R.id.edittext_appointment_date);
		edittext_appointment_date.setOnClickListener(new OnClickListener()
		{
			
			@Override
			public void onClick(View v)
			{
				datePickerDialog=new DatePickerDialog(NewAppointmentActivity.this, new OnDateSetListener()
				{
					
					public void onDateSet(DatePicker view, int year, int monthOfYear,
							int dayOfMonth)
					{
						String d=String.valueOf(dayOfMonth);
						String m=String.valueOf(monthOfYear+1);
						if(dayOfMonth/10==0)
							d="0" + String.valueOf(dayOfMonth);
						if((monthOfYear+1)/10==0)
							m="0" + String.valueOf(monthOfYear+1);
						edittext_appointment_date.setText(d + "/" + m + "/" + year);
					}
				}, year, month, day);
				datePickerDialog.show();
			}
		});
		edittext_appointment_time=(EditText)findViewById(R.id.edittext_appointment_time);
		edittext_appointment_time.setOnClickListener(new OnClickListener()
		{
			
			@Override
			public void onClick(View v)
			{
				timePickerDialog=new TimePickerDialog(NewAppointmentActivity.this, new OnTimeSetListener()
				{
					
					@Override
					public void onTimeSet(TimePicker view, int hourOfDay, int minute)
					{
						String time=hourOfDay + ":" + minute;
						SimpleDateFormat simpleDateFormat=new SimpleDateFormat("H:mm");
						Date date;
						try
						{
							date = simpleDateFormat.parse(time);
							edittext_appointment_time.setText(new SimpleDateFormat("hh:mm aa").format(date));
						}
						catch (Exception e)
						{
							Log.d("TAG_FILTER", e.toString());
						}						
					}
				}, hour, min, false);
				timePickerDialog.show();
			}
		});
		edittext_problem_details=(EditText)findViewById(R.id.edittext_problem_details);
		
		spinner_department=(Spinner)findViewById(R.id.spinner_department);
		spinner_department.setOnItemSelectedListener(new OnItemSelectedListener()
		{

			@Override
			public void onItemSelected(AdapterView<?> parent, View view,
					int position, long id)
			{
				DepartmentClass objDepartmentClass=(DepartmentClass) spinner_department.getSelectedItem();
				int departmentId=objDepartmentClass.departmentId;
				DoctorByDepartmentAsyncTask objdocDoctorByDepartmentAsyncTask=new DoctorByDepartmentAsyncTask();
				objdocDoctorByDepartmentAsyncTask.execute(departmentId);
			}

			@Override
			public void onNothingSelected(AdapterView<?> parent)
			{
				// TODO Auto-generated method stub
				
			}
			
		});
		spinner_body_part=(Spinner)findViewById(R.id.spinner_body_part);
		spinner_doctor=(Spinner)findViewById(R.id.spinner_doctor);
		
		textview_appointment_date=(TextView)findViewById(R.id.textview_appointment_date);
		textview_appointment_time=(TextView)findViewById(R.id.textview_appointment_time);
		textview_department=(TextView)findViewById(R.id.textview_department);
		textview_body_part=(TextView)findViewById(R.id.textview_body_part);
		textview_problem_details=(TextView)findViewById(R.id.textview_problem_details);
		textview_doctor=(TextView)findViewById(R.id.textview_doctor);
		
/*		typeface=Typeface.createFromAsset(getAssets(), "fonts/consola.ttf");
		textview_appointment_date.setTypeface(typeface);
		textview_appointment_time.setTypeface(typeface);
		textview_department.setTypeface(typeface);
		textview_body_part.setTypeface(typeface);
		textview_problem_details.setTypeface(typeface);
		textview_doctor.setTypeface(typeface);*/
		GetBodyPartsAsyncTask objGetGetBodyPartsAsyncTask=new GetBodyPartsAsyncTask();
		objGetGetBodyPartsAsyncTask.execute();
		GetDepartmentsAsyncTask objGetDepartmentsAsyncTask=new GetDepartmentsAsyncTask();
		objGetDepartmentsAsyncTask.execute();
	}
	
	private class GetBodyPartsAsyncTask extends AsyncTask<Void, Void, String>
	{

		@Override
		protected String doInBackground(Void... params)
		{
			SoapObject request=new SoapObject(getResources().getString(R.string.NAMESPACE), METHOD_NAME_1);
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
				return e.getClass().getName();
			}
		}
		
		@Override
		protected void onPostExecute(String result)
		{
			if(result.equals("org.ksoap2.SoapFault"))
				Toast.makeText(getBaseContext(), "Internal Error. Please Try Again.", Toast.LENGTH_LONG).show();
			else if(result.equals("java.net.SocketTimeoutException")) 
				Toast.makeText(getBaseContext(), "Network Error. Please Try Again", Toast.LENGTH_LONG).show();
			else
			{
				List<BodyPartClass> bodyPartList=new ArrayList<BodyPartClass>();
				bodyPartList.add(new BodyPartClass(0, "--Select--"));
				try
				{
					JSONObject jsonObject1=new JSONObject(result);
					JSONArray jsonArray1=jsonObject1.getJSONArray("Table");
					for(int i=0;i<jsonArray1.length();i++)
					{
						JSONObject jsonObject=jsonArray1.getJSONObject(i);
						int bodyPartId=jsonObject.optInt("ID");
						String bodyPartName=jsonObject.optString("BODY_PART");
						bodyPartList.add(new BodyPartClass(bodyPartId, bodyPartName));
					}
					ArrayAdapter<BodyPartClass> adapter=new ArrayAdapter<BodyPartClass>(NewAppointmentActivity.this, R.layout.simple_spinner_item, bodyPartList);
					spinner_body_part.setAdapter(adapter);
				}
				catch (Exception e)
				{
					Log.d("TAG_FILTER", e.toString());
				}
			}
		}
	}
		
	private class GetDepartmentsAsyncTask extends AsyncTask<Void, Void, String>
	{

		@Override
		protected String doInBackground(Void... params)
		{
			SoapObject request=new SoapObject(getResources().getString(R.string.NAMESPACE), METHOD_NAME_2);
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
				return e.getClass().getName();
			}
		}
		
		protected void onPostExecute(String result)
		{
			if(result.equals("org.ksoap2.SoapFault"))
				Toast.makeText(getBaseContext(), "Internal Error. Please Try Again.", Toast.LENGTH_LONG).show();
			else if(result.equals("java.net.SocketTimeoutException")) 
				Toast.makeText(getBaseContext(), "Network Error. Please Try Again", Toast.LENGTH_LONG).show();
			else
			{
				List<DepartmentClass> departmentList=new ArrayList<DepartmentClass>();
				departmentList.add(new DepartmentClass(0, "--Select--"));
				try
				{
					JSONObject jsonObject1=new JSONObject(result);
					JSONArray jsonArray1=jsonObject1.getJSONArray("Table");
					for(int i=0;i<jsonArray1.length();i++)
					{
						JSONObject jsonObject=jsonArray1.getJSONObject(i);
						int departmentId=jsonObject.optInt("ID");
						String departmentName=jsonObject.optString("SPECIALITY");
						departmentList.add(new DepartmentClass(departmentId, departmentName));
					}
					ArrayAdapter<DepartmentClass> adapter=new ArrayAdapter<DepartmentClass>(NewAppointmentActivity.this, R.layout.simple_spinner_item, departmentList);
					spinner_department.setAdapter(adapter);
				}
				catch (Exception e)
				{
					Log.d("TAG_FILTER", e.toString());
				}
			}
		}
	}
	
	private class DoctorByDepartmentAsyncTask extends AsyncTask<Integer, Void, String>
	{
		@Override
		protected void onPreExecute()
		{
			progressDialog=ProgressDialog.show(NewAppointmentActivity.this, "Loading", "Retrieving Doctors...");
		}
		@Override
		protected String doInBackground(Integer... params)
		{
			SoapObject request=new SoapObject(getResources().getString(R.string.NAMESPACE), METHOD_NAME_3);
			
			PropertyInfo departmentProperty=new PropertyInfo();
			departmentProperty.setType(Integer.class);
			departmentProperty.setName("departmentId");
			departmentProperty.setValue(params[0]);
			request.addProperty(departmentProperty);
			
			SoapSerializationEnvelope envelope=new SoapSerializationEnvelope(SoapEnvelope.VER11);
			envelope.dotNet=true;
			envelope.setOutputSoapObject(request);
			HttpTransportSE transport=new HttpTransportSE(getResources().getString(R.string.URL));
			try
			{
				transport.call(SOAP_ACTION_3, envelope);
				String response=envelope.getResponse().toString();
				return response;
			}
			catch (Exception e)
			{
				Log.d("TAG_FILTER", e.toString());
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
				spinner_doctor.setAdapter(null);
				List<DoctorClass> doctorList=new ArrayList<DoctorClass>();
				doctorList.add(new DoctorClass(0, "--Select--"));
				try
				{
					JSONObject jsonObject1=new JSONObject(result);
					JSONArray jsonArray1=jsonObject1.getJSONArray("Table");
					for(int i=0;i<jsonArray1.length();i++)
					{
						JSONObject jsonObject=jsonArray1.getJSONObject(i);
						int doctorId=jsonObject.optInt("ID");
						String doctorName="Dr. " + jsonObject.optString("DOCTOR_NAME");
						doctorList.add(new DoctorClass(doctorId, doctorName));
					}
					ArrayAdapter<DoctorClass> adapter=new ArrayAdapter<DoctorClass>(NewAppointmentActivity.this, R.layout.simple_spinner_item, doctorList);
					spinner_doctor.setAdapter(adapter);
				}
				catch (Exception e)
				{
					Log.e("TAG_FILTER", e.toString());
				}
			}
		}
	}

	private class CreateAppointmentAsyncTask extends AsyncTask<String, Void, String>
	{
		@Override
		protected void onPreExecute()
		{
			progressDialog=ProgressDialog.show(NewAppointmentActivity.this, "Loading", "Scheduling New Appointment...");
		}
		@Override
		protected String doInBackground(String... params)
		{
			SoapObject request=new SoapObject(getResources().getString(R.string.NAMESPACE), METHOD_NAME_4);
			
			PropertyInfo patientIdProperty=new PropertyInfo();
			patientIdProperty.setName("patientId");
			patientIdProperty.setValue(params[0]);
			patientIdProperty.setType(String.class);
			request.addProperty(patientIdProperty);
			
			PropertyInfo doctorIdProperty=new PropertyInfo();
			doctorIdProperty.setName("doctorId");
			doctorIdProperty.setValue(params[1]);
			doctorIdProperty.setType(String.class);
			request.addProperty(doctorIdProperty);
			
			PropertyInfo appointmentDateProperty=new PropertyInfo();
			appointmentDateProperty.setName("appointmentDate");
			appointmentDateProperty.setValue(params[2]);
			appointmentDateProperty.setType(String.class);
			request.addProperty(appointmentDateProperty);
			
			PropertyInfo appointmentTimeProperty=new PropertyInfo();
			appointmentTimeProperty.setName("appointmentTime");
			appointmentTimeProperty.setValue(params[3]);
			appointmentTimeProperty.setType(String.class);
			request.addProperty(appointmentTimeProperty);
			
			PropertyInfo problemBodyPartIdProperty=new PropertyInfo();
			problemBodyPartIdProperty.setName("problemBodyPartId");
			problemBodyPartIdProperty.setValue(params[4]);
			problemBodyPartIdProperty.setType(String.class);
			request.addProperty(problemBodyPartIdProperty);
			
			PropertyInfo problemDescriptionProperty=new PropertyInfo();
			problemDescriptionProperty.setName("problemDescription");
			problemDescriptionProperty.setValue(params[5]);
			problemDescriptionProperty.setType(String.class);
			request.addProperty(problemDescriptionProperty);
			
			SoapSerializationEnvelope envelope=new SoapSerializationEnvelope(SoapEnvelope.VER11);
			envelope.dotNet=true;
			envelope.setOutputSoapObject(request);
			HttpTransportSE transport=new HttpTransportSE(getResources().getString(R.string.URL));
			try
			{
				transport.call(SOAP_ACTION_4, envelope);
				String response=envelope.getResponse().toString();
				return response;
			}
			catch (Exception e)
			{
				Log.d("TAG_FILTER", e.toString());
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
				Toast.makeText(getBaseContext(), "Appointment Scheduled", Toast.LENGTH_LONG).show();
				setResult(RESULT_OK);
				finish();
			}
		}
	}
	
	private void checkNetwork()
	{
		ConnectivityManager connectivityManager=(ConnectivityManager)getSystemService(Context.CONNECTIVITY_SERVICE);
		if(connectivityManager.getActiveNetworkInfo()!=null&&connectivityManager.getActiveNetworkInfo().isAvailable()&&connectivityManager.getActiveNetworkInfo().isConnected())
			NETWORK=1;
		else
			displayNetworkErrorDialog();
	}
	
	private void displayNetworkErrorDialog()
	{
		AlertDialog.Builder builder=new AlertDialog.Builder(NewAppointmentActivity.this);
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
	
	private int validate()
	{
		if(edittext_appointment_date.getText().toString().equals(""))
		{
			edittext_appointment_date.requestFocus();
			textview_appointment_date.setTextColor(Color.RED);
			textview_appointment_time.setTextColor(Color.BLACK);
			textview_body_part.setTextColor(Color.BLACK);
			textview_department.setTextColor(Color.BLACK);
			textview_doctor.setTextColor(Color.BLACK);
			Toast.makeText(getBaseContext(), "Please Select Appointment Date", Toast.LENGTH_SHORT).show();
			return 0;
		}
		if(edittext_appointment_time.getText().toString().equals(""))
		{
			edittext_appointment_time.requestFocus();
			textview_appointment_time.setTextColor(Color.RED);
			textview_appointment_date.setTextColor(Color.BLACK);			
			textview_body_part.setTextColor(Color.BLACK);
			textview_department.setTextColor(Color.BLACK);
			textview_doctor.setTextColor(Color.BLACK);
			Toast.makeText(getBaseContext(), "Please Select Appointment Time", Toast.LENGTH_SHORT).show();
			return 0;
		}
		if(spinner_department.getSelectedItemPosition()==0)
		{
			spinner_department.requestFocus();
			textview_department.setTextColor(Color.RED);
			textview_appointment_time.setTextColor(Color.BLACK);
			textview_appointment_date.setTextColor(Color.BLACK);			
			textview_body_part.setTextColor(Color.BLACK);			
			textview_doctor.setTextColor(Color.BLACK);
			Toast.makeText(getBaseContext(), "Please Select Doctor Department", Toast.LENGTH_SHORT).show();
			return 0;
		}
		if(spinner_doctor.getSelectedItemPosition()==0)
		{
			spinner_doctor.requestFocus();
			textview_doctor.setTextColor(Color.RED);
			textview_department.setTextColor(Color.BLACK);
			textview_appointment_time.setTextColor(Color.BLACK);
			textview_appointment_date.setTextColor(Color.BLACK);			
			textview_body_part.setTextColor(Color.BLACK);		
			Toast.makeText(getBaseContext(), "Please Select Doctor", Toast.LENGTH_SHORT).show();
			return 0;
		}
		if(spinner_body_part.getSelectedItemPosition()==0)
		{
			spinner_body_part.requestFocus();
			textview_body_part.setTextColor(Color.RED);
			textview_doctor.setTextColor(Color.BLACK);
			textview_department.setTextColor(Color.BLACK);
			textview_appointment_time.setTextColor(Color.BLACK);
			textview_appointment_date.setTextColor(Color.BLACK);	
			Toast.makeText(getBaseContext(), "Please Select Body Part", Toast.LENGTH_SHORT).show();
			return 0;
		}
		return 1;
	}
	
	public void button1_onClick(View v)
	{		
		if(validate()==1)
		{
			checkNetwork();
			if(NETWORK==1)
			{
				SharedPreferences sharedPreferences=getSharedPreferences("HMS", Context.MODE_PRIVATE);
				String patientId=sharedPreferences.getString("patientId", "-1");
				DoctorClass objDoctorClass=(DoctorClass)spinner_doctor.getSelectedItem();
				String doctorId=String.valueOf(objDoctorClass.doctorId);
				String appointmentDate=edittext_appointment_date.getText().toString();
				String appointmentTime=edittext_appointment_time.getText().toString();
				BodyPartClass objBodyPartClass=(BodyPartClass)spinner_body_part.getSelectedItem();
				String problemBodyPartId=String.valueOf(objBodyPartClass.bodyPartId);
				String problemDescription=edittext_problem_details.getText().toString();
				
				CreateAppointmentAsyncTask objCreateAppointmentAsyncTask=new CreateAppointmentAsyncTask();
				objCreateAppointmentAsyncTask.execute(patientId, doctorId, appointmentDate, appointmentTime, problemBodyPartId, problemDescription);
			}
		}
	}
	
}
