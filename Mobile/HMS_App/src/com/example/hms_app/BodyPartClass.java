package com.example.hms_app;

public class BodyPartClass
{
	public int bodyPartId;
	public String bodyPartName;
	
	public BodyPartClass(int bodyPartId, String bodyPartName)
	{
		super();
		this.bodyPartId = bodyPartId;
		this.bodyPartName = bodyPartName;
	}
	
	public String toString()
	{
		return bodyPartName;
	}
}
