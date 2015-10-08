using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_LeaveApplicationBL
/// </summary>
public class Doctor_LeaveApplicationBL
{
	public void Doctor_LeaveApplication(int doctorId, string leaveFromDate, string leaveFromTime, 
        string leaveToDate, string leaveToTime, string leaveReason)
	{
        Doctor_LeaveApplicationBO objDoctor_LeaveApplicationBO = new Doctor_LeaveApplicationBO();
        objDoctor_LeaveApplicationBO.doctorId = doctorId;
        objDoctor_LeaveApplicationBO.leaveFromDate = leaveFromDate;
        objDoctor_LeaveApplicationBO.leaveFromTime = leaveFromTime;
        objDoctor_LeaveApplicationBO.leaveToDate = leaveToDate;
        objDoctor_LeaveApplicationBO.leaveToTime = leaveToTime;
        objDoctor_LeaveApplicationBO.leaveReason = leaveReason;

        Doctor_LeaveApplicationDL objDoctor_LeaveApplicationDL = new Doctor_LeaveApplicationDL();
        objDoctor_LeaveApplicationDL.Doctor_LeaveApplication(objDoctor_LeaveApplicationBO);
	}
}