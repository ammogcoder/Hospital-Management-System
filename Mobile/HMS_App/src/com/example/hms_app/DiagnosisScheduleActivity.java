package com.example.hms_app;

import android.app.ActionBar;
import android.app.Activity;
import android.app.Fragment;
import android.app.FragmentTransaction;
import android.app.ActionBar.Tab;
import android.content.Context;
import android.content.Intent;
import android.graphics.Color;
import android.graphics.Typeface;
import android.graphics.drawable.ColorDrawable;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

public class DiagnosisScheduleActivity extends Activity
{
	private static Context appContext;
	private Intent intent;
	
	@Override
	protected void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_diagnosis_schedule);
		appContext = getApplicationContext();

        ActionBar actionBar = getActionBar();
        actionBar.setBackgroundDrawable(new ColorDrawable(Color.parseColor("#00BFFF")));
		actionBar.setDisplayShowCustomEnabled(true);
		actionBar.setDisplayShowTitleEnabled(false);
		actionBar.setIcon(R.drawable.calendar2);
		LayoutInflater inflater=(LayoutInflater)getSystemService(Context.LAYOUT_INFLATER_SERVICE);
		View view=inflater.inflate(R.layout.action_bar_style, null);
		TextView action_bar_title=(TextView)view.findViewById(R.id.action_bar_title);
		Typeface typeface=Typeface.createFromAsset(getAssets(), "fonts/cooper.ttf");
		action_bar_title.setTypeface(typeface);
		action_bar_title.setText("Diagnosis Schedule");
		actionBar.setCustomView(view);
        actionBar.setNavigationMode(ActionBar.NAVIGATION_MODE_TABS);
        
        ActionBar.Tab appointmentTab = actionBar.newTab().setText("Appointment");
        ActionBar.Tab medicalTestTab = actionBar.newTab().setText("Medical Test");
        
        Fragment appointmentFragment = new AppointmentFragment();
        Fragment medicalTestFragment = new MedicalTestFragment();

        appointmentTab.setTabListener(new MyTabsListener(appointmentFragment));
        medicalTestTab.setTabListener(new MyTabsListener(medicalTestFragment));

        actionBar.addTab(appointmentTab);
        actionBar.addTab(medicalTestTab); 
   }
		
    @Override
    protected void onSaveInstanceState(Bundle outState) {
        super.onSaveInstanceState(outState);
        outState.putInt("tab", getActionBar().getSelectedNavigationIndex());
    }
    
    public void button_previous_appointment_onClick(View v)
    {
    	intent=new Intent(DiagnosisScheduleActivity.this, PreviousAppointmentsActivity.class); 
    	startActivity(intent);
    }
    
    public void button_upcoming_appointment_onClick(View v)
    {
    	intent=new Intent(DiagnosisScheduleActivity.this, UpcomingAppointmentsActivity.class);
    	startActivity(intent);
    }
    
    public void button_previous_tests_onClick(View v)
    {
    	intent=new Intent(DiagnosisScheduleActivity.this, PreviousMedicalTestsActivity.class);
    	startActivity(intent);
    }
    
    public void button_upcoming_tests_onClick(View v)
    {
    	intent=new Intent(DiagnosisScheduleActivity.this, UpcomingMedicalTestsActivity.class);
    	startActivity(intent);
    }
}


class MyTabsListener implements ActionBar.TabListener {
	public Fragment fragment;
	
	public MyTabsListener(Fragment fragment) {
		this.fragment = fragment;
	}
	
	@Override
	public void onTabReselected(Tab tab, FragmentTransaction ft) {
	}

	@Override
	public void onTabSelected(Tab tab, FragmentTransaction ft) {
		ft.replace(R.id.fragment_container, fragment);
	}

	@Override
	public void onTabUnselected(Tab tab, FragmentTransaction ft) {
		ft.remove(fragment);
	}	
}
