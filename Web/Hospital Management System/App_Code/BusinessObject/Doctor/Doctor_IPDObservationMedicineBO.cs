using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IPDObservationMedicineBO
/// </summary>
public class Doctor_IPDObservationMedicineBO
{
    public int ipdObservationId { get; set; }
    public int ipdObservationReportId { get; set; }
    public string medicineType { get; set; }
    public string medicineName { get; set; }
    public string medicineStrength { get; set; }
    public string medicineQuantity { get; set; }
    public string medicineStartDate { get; set; }
    public int numberOfRefills { get; set; }
    public string quantityOnRefills { get; set; }
    public string medicineInstructions { get; set; }
}