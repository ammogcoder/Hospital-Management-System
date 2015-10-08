using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_AddIPDObservationMedicineBO
/// </summary>
public class Doctor_AddIPDObservationMedicineBO
{
    public string ipdObservationId { get; set; }
    public int ipdObservationReportId { get; set; }
    public int medicineTypeId { get; set; }
    public int medicineNameId { get; set; }
    public string medicineStrength { get; set; }
    public string medicineQuantity { get; set; }
    public string medicineStartDate { get; set; }
    public int numberOfRefills { get; set; }
    public string quantityOnRefills { get; set; }
    public string medicineInstructions { get; set; }
}