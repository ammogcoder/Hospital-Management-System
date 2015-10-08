package com.example.hms_app;

public class DoctorClass
{
	public int doctorId;
	public String doctorName;
	
	public DoctorClass(int doctorId, String doctorName)
	{
		super();
		this.doctorId = doctorId;
		this.doctorName = doctorName;
	}
	
	public String toString()
	{
		return doctorName;
	}
}
