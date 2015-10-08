using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Common_PatientWardTransferBL
/// </summary>
public class Common_PatientWardTransferBL
{
    public int Common_PatientWardTransfer(int patientId, int previousWardId, int previousWardNumber, 
        string transferDate, string transferTime, string reasonForTransfer, int newWardId, 
        int newWardNumber, int empId)
	{
        Common_PatientWardTransferBO objCommon_PatientWardTransferBO = new Common_PatientWardTransferBO();
        objCommon_PatientWardTransferBO.patientId = patientId;
        objCommon_PatientWardTransferBO.previousWardId = previousWardId;
        objCommon_PatientWardTransferBO.previousWardNumber = previousWardNumber;
        objCommon_PatientWardTransferBO.transferDate = transferDate;
        objCommon_PatientWardTransferBO.transferTime = transferTime;
        objCommon_PatientWardTransferBO.reasonForTransfer = reasonForTransfer;
        objCommon_PatientWardTransferBO.newWardId = newWardId;
        objCommon_PatientWardTransferBO.newWardNumber = newWardNumber;
        objCommon_PatientWardTransferBO.empId = empId;

        Common_PatientWardTransferDL objCommon_PatientWardTransferDL = new Common_PatientWardTransferDL();
        return objCommon_PatientWardTransferDL.Common_PatientWardTransfer(objCommon_PatientWardTransferBO);
	}
}