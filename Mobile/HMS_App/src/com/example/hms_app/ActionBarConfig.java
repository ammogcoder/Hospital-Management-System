package com.example.hms_app;

import android.app.ActionBar;
import android.app.Application;
import android.content.Context;
import android.graphics.Color;
import android.graphics.Typeface;
import android.graphics.drawable.ColorDrawable;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.TextView;

public class ActionBarConfig extends Application
{
	public void Config(Context context, ActionBar actionBar)
	{
		actionBar.setDisplayHomeAsUpEnabled(true);
		actionBar.setBackgroundDrawable(new ColorDrawable(Color.parseColor("#00BFFF")));
		actionBar.setDisplayShowCustomEnabled(true);
		actionBar.setDisplayShowTitleEnabled(false);
		actionBar.setIcon(R.drawable.document);
		LayoutInflater inflater=(LayoutInflater)getSystemService(context.LAYOUT_INFLATER_SERVICE);
		View view=inflater.inflate(R.layout.action_bar_style, null);
		TextView action_bar_title=(TextView)view.findViewById(R.id.action_bar_title);
		Typeface typeface=Typeface.createFromAsset(getAssets(), "fonts/cooper.ttf");
		action_bar_title.setTypeface(typeface);
		action_bar_title.setText("New Appointment");
		actionBar.setCustomView(view);
	}
}
