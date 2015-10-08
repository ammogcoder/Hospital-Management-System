package com.example.hms_app;

import java.util.List;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

public class AppointmentMedicinesAdapter extends ArrayAdapter
{
	private Context context;
	
	private List<String> medicineInstructionsList;
	private List<String> medicineNoOfRefillsList;
	private List<String> medicineQuantityList;
	private List<String> medicineQuantityOnRefillList;
	private List<String> medicineStartDateList;
	private List<String> medicineStrengthList;
	private List<String> medicineTypeList;
	private List<String> medicineNameList;
	
	public AppointmentMedicinesAdapter(Context context, List<String> medicineInstructionsList, List<String> medicineNoOfRefillsList, List<String> medicineQuantityList, List<String> medicineQuantityOnRefillList, List<String> medicineStartDateList, List<String> medicineStrengthList, List<String> medicineTypeList, List<String> medicineNameList)
	{
		super(context, R.layout.row_medicines, R.id.textview_medicine_name, medicineNameList);
		this.context=context;
		this.medicineInstructionsList=medicineInstructionsList;
		this.medicineNameList=medicineNameList;
		this.medicineNoOfRefillsList=medicineNoOfRefillsList;
		this.medicineQuantityList=medicineQuantityList;
		this.medicineQuantityOnRefillList=medicineQuantityOnRefillList;
		this.medicineStartDateList=medicineStartDateList;
		this.medicineStrengthList=medicineStrengthList;
		this.medicineTypeList=medicineTypeList;
	}

	@Override
	public View getView(int position, View convertView, ViewGroup parent)
	{
		LayoutInflater inflater=(LayoutInflater)context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
		View v=inflater.inflate(R.layout.row_medicines, parent, false);
		TextView textview_medicine_name=(TextView)v.findViewById(R.id.textview_medicine_name);
		TextView textview_medicine_type=(TextView)v.findViewById(R.id.textview_medicine_type);
		TextView textview_medicine_strength=(TextView)v.findViewById(R.id.textview_medicine_strength);
		TextView textview_medicine_quantity=(TextView)v.findViewById(R.id.textview_medicine_quantity);
		TextView textview_medicine_number_of_refills=(TextView)v.findViewById(R.id.textview_medicine_number_of_refills);
		TextView textview_medicine_quantity_on_refills=(TextView)v.findViewById(R.id.textview_medicine_quantity_on_refills);
		TextView textview_medicine_start_date=(TextView)v.findViewById(R.id.textview_medicine_start_date);
		TextView textview_medicine_instructions=(TextView)v.findViewById(R.id.textview_medicine_instructions);
		textview_medicine_name.setText("Medicine Name: " + medicineNameList.get(position));
		textview_medicine_type.setText("Medicine Type: " + medicineTypeList.get(position));
		textview_medicine_strength.setText("Medicine Strength: " + medicineStrengthList.get(position));
		textview_medicine_quantity.setText("Medicine Quantity: " + medicineQuantityList.get(position));
		textview_medicine_number_of_refills.setText("No. Of Refills: " + medicineNoOfRefillsList.get(position));
		textview_medicine_quantity_on_refills.setText("Quantity on Refill: " + medicineQuantityOnRefillList.get(position));
		textview_medicine_start_date.setText("Medicine Start Date: " + medicineStartDateList.get(position));
		textview_medicine_instructions.setText("Medicine Instructions: " + medicineInstructionsList.get(position));
		
		return v;
	}
	
	
}
