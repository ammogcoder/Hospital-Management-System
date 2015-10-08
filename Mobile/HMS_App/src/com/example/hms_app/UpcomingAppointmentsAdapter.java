package com.example.hms_app;

import java.util.ArrayList;
import java.util.List;

import android.content.Context;
import android.graphics.Color;
import android.text.Html;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

public class UpcomingAppointmentsAdapter extends ArrayAdapter<String>
{
	private Context context;
	
	private List<String> appointmentDateList;
	private List<String> appointmentTimeList;
	private List<String> doctorList;
	private List<String> appointmentTokenList;
	
	public UpcomingAppointmentsAdapter(Context context, List<String> appointmentDateList, List<String> appointmentTimeList, List<String> doctorList, List<String> appointmentTokenList)
	{
		super(context, R.layout.row_appointments, R.id.textview_doctor_name, doctorList);
		this.context=context;
		this.doctorList=doctorList;
		this.appointmentDateList=appointmentDateList;
		this.appointmentTimeList=appointmentTimeList;
		this.appointmentTokenList=appointmentTokenList;
	}
	
	public View getView(int position, View convertView, ViewGroup parent)
	{		  
		LayoutInflater inflater=(LayoutInflater)context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
		View v=inflater.inflate(R.layout.row_appointments, parent, false);
		TextView textview_doctor_name=(TextView)v.findViewById(R.id.textview_doctor_name);
		TextView textview_appointment_date=(TextView)v.findViewById(R.id.textview_appointment_date);
		TextView textview_appointment_time=(TextView)v.findViewById(R.id.textview_appointment_time);
		textview_doctor_name.setText("Doctor: " + Html.fromHtml("<b>" + doctorList.get(position) + "</b>"));
		textview_doctor_name.setTag(appointmentTokenList.get(position));
		textview_appointment_date.setText("Appointment Date: " + appointmentDateList.get(position));
		textview_appointment_time.setText("Appointment Time: " + appointmentTimeList.get(position));
		return v;
	}
}
