package com.example.hms_app;

import java.util.ArrayList;

import android.content.Context;
import android.graphics.Color;
import android.graphics.Typeface;
import android.graphics.drawable.ColorDrawable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

public class HomeActivityBaseAdapter extends BaseAdapter {

	ArrayList<HomeItemsClass> itemList;
	Context context;
	
	public HomeActivityBaseAdapter(Context context) {
		
		itemList=new ArrayList<HomeItemsClass>();
		this.context=context;
		int[] imageArray={R.drawable.calendar, R.drawable.doctor, R.drawable.stethoscope2, R.drawable.money};
		String[] nameArray=context.getResources().getStringArray(R.array.home_array);
		for(int i=0;i<4;i++)
			itemList.add(new HomeItemsClass(imageArray[i], nameArray[i]));
	}
	@Override
	public int getCount() {
		// TODO Auto-generated method stub
		return itemList.size();
	}
 
	@Override
	public Object getItem(int position) {
		// TODO Auto-generated method stub
		return itemList.get(position);
	}

	@Override
	public long getItemId(int position) {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public View getView(int position, View convertView, ViewGroup parent) {
		// TODO Auto-generated method stub
		LayoutInflater inflater=(LayoutInflater) context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
		View item=inflater.inflate(R.layout.home_item, parent, false);
		ImageView imageview1=(ImageView)item.findViewById(R.id.imageview1);
		TextView textview1=(TextView)item.findViewById(R.id.textview1);
		HomeItemsClass objHomeItemsClass=itemList.get(position);
		imageview1.setImageResource(objHomeItemsClass.imageId);
		textview1.setText(objHomeItemsClass.itemName);
		if(objHomeItemsClass.itemName.equals("DIAGNOSIS SCHEDULE"))
			textview1.setTextColor(Color.parseColor("#33A1DE"));
		else if(objHomeItemsClass.itemName.equals("NEW APPOINTMENT"))
			textview1.setTextColor(Color.parseColor("#34925E"));
		else if(objHomeItemsClass.itemName.equals("HEALTH CHECKUP"))
			textview1.setTextColor(Color.parseColor("#01C5BB"));
		else if(objHomeItemsClass.itemName.equals("TARRIF INQUIRY"))
			textview1.setTextColor(Color.parseColor("#4CBB17"));
		Typeface typeface=Typeface.createFromAsset(context.getAssets(), "fonts/arialbd.ttf");
		textview1.setTypeface(typeface);
		return item;
	}

}
