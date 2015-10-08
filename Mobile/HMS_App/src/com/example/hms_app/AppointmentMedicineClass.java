package com.example.hms_app;

import java.util.List;

public class AppointmentMedicineClass
{
	public static List<String> medicineInstructionsList;
	public static List<String> medicineNoOfRefillsList;
	public static List<String> medicineQuantityList;
	public static List<String> medicineQuantityOnRefillList;
	public static List<String> medicineStartDateList;
	public static List<String> medicineStrengthList;
	public static List<String> medicineTypeList;
	public static List<String> medicineNameList;
	
	public AppointmentMedicineClass()
	{
		
	}
	
	public AppointmentMedicineClass(List<String> medicineInstructionsList, List<String> medicineNoOfRefillsList, List<String> medicineQuantityList, List<String> medicineQuantityOnRefillList, List<String> medicineStartDateList, List<String> medicineStrengthList, List<String> medicineTypeList, List<String> medicineNameList)
	{
		this.medicineInstructionsList=medicineInstructionsList;
		this.medicineNameList=medicineNameList;
		this.medicineNoOfRefillsList=medicineNoOfRefillsList;
		this.medicineQuantityList=medicineQuantityList;
		this.medicineQuantityOnRefillList=medicineQuantityOnRefillList;
		this.medicineStartDateList=medicineStartDateList;
		this.medicineStrengthList=medicineStrengthList;
		this.medicineTypeList=medicineTypeList;
	}
}
