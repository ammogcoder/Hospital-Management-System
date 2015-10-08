using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetAllDoctorsBL
/// </summary>
public class Doctor_GetAllDoctorsBL
{
    public DataSet Doctor_GetAllDoctors(int doctorId)
	{
        Doctor_GetAllDoctorsDL objDoctor_GetAllDoctorsDL=new Doctor_GetAllDoctorsDL();
        return objDoctor_GetAllDoctorsDL.Doctor_GetAllDoctors(doctorId);
	}
}