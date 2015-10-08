package com.example.hms_app;

public class DepartmentClass
{
	public int departmentId;
	public String departmentName;
	
	public DepartmentClass(int departmentId, String departmentName)
	{
		super();
		this.departmentId = departmentId;
		this.departmentName = departmentName;
	}
	
	public String toString()
	{
		return departmentName;
	}
}
