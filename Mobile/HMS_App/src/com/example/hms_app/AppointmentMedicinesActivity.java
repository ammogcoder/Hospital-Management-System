package com.example.hms_app;

import android.app.ActionBar;
import android.app.Activity;
import android.content.Context;
import android.graphics.Color;
import android.graphics.Typeface;
import android.graphics.drawable.ColorDrawable;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

public class AppointmentMedicinesActivity extends Activity
{

	private ListView listView;
	
	@Override
	protected void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_appointment_medicines);
		setUpLayout();
		GetData();
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
		action_bar_title.setText("Appointment Medicines");
		actionBar.setCustomView(view);  
		listView=(ListView)findViewById(R.id.listview1);
	}
	
	private void GetData() 
	{
		AppointmentMedicineClass o=new AppointmentMedicineClass();
		listView.setAdapter(new AppointmentMedicinesAdapter(AppointmentMedicinesActivity.this, o.medicineInstructionsList, o.medicineNoOfRefillsList, o.medicineQuantityList, o.medicineQuantityOnRefillList, o.medicineStartDateList, o.medicineStrengthList, o.medicineTypeList, o.medicineNameList));
	}
}
