package com.example.hms_app;

public class GenderClass {

	public String genderName;
	public String genderCode;
	
	public GenderClass(String genderName, String genderCode) {
		super();
		this.genderName = genderName;
		this.genderCode = genderCode;
	}
	
	public String toString()
	{
		return genderName;
	}
}
