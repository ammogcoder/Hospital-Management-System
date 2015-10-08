package com.example.hms_app;

import java.util.List;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

public class MedicalTestsAdapter extends ArrayAdapter<String>
{
	private Context context;
	
	private List<String> medicalTestNameList;
	private List<String> testTimeList;
	private List<String> testDateList;
	
	public MedicalTestsAdapter(Context context, List<String> medicalTestNameList, List<String> testTimeList, List<String> testDateList)
	{
		super(context, R.layout.row_medical_tests, R.id.textview_medical_test_name, medicalTestNameList);
		this.context=context;
		this.medicalTestNameList=medicalTestNameList;
		this.testDateList=testDateList;
		this.testTimeList=testTimeList;
	}
	
	public View getView(int position, View convertView, ViewGroup parent)
	{
		LayoutInflater inflater=(LayoutInflater)context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
		View v=inflater.inflate(R.layout.row_medical_tests, parent, false);
		TextView textview_medical_test_name=(TextView)v.findViewById(R.id.textview_medical_test_name);
		TextView textview_test_date=(TextView)v.findViewById(R.id.textview_test_date);
		TextView textview_test_time=(TextView)v.findViewById(R.id.textview_test_time);
		textview_medical_test_name.setText("Medical Test: " + medicalTestNameList.get(position));
		textview_test_date.setText("Test Date: " + testDateList.get(position));
		textview_test_time.setText("Test Time: " + testTimeList.get(position));
		return v;
	}
}
