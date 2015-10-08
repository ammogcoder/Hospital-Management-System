using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_IPDDoctorTransferBL
/// </summary>
public class Doctor_IPDDoctorTransferBL
{
	public int Doctor_IPDDoctorTransfer(string transferDate, string transferTime, string reasonForTransfer,
        int transferToDoctorId, int transferByDoctorId, int patientId)
	{
        Doctor_IPDDoctorTransferBO objDoctor_IPDDoctorTransferBO = new Doctor_IPDDoctorTransferBO();
        objDoctor_IPDDoctorTransferBO.transferDate = transferDate;
        objDoctor_IPDDoctorTransferBO.transferTime = transferTime;
        objDoctor_IPDDoctorTransferBO.reasonForTransfer = reasonForTransfer;
        objDoctor_IPDDoctorTransferBO.transferByDoctorId = transferByDoctorId;
        objDoctor_IPDDoctorTransferBO.transferToDoctorId = transferToDoctorId;
        objDoctor_IPDDoctorTransferBO.patientId = patientId;

        Doctor_IPDDoctorTransferDL objDoctor_IPDDoctorTransferDL = new Doctor_IPDDoctorTransferDL();
        return objDoctor_IPDDoctorTransferDL.Doctor_IPDDoctorTransfer(objDoctor_IPDDoctorTransferBO);
	}
}