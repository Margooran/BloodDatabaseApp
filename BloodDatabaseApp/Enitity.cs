using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDatabaseApp;
public class RecordEntity
{
    public int RecordID { get; set; }
    public int PatientID { get; set; }
    public int Quantity { get; set; }
    public DateTime DateTime { get; set; }
    public PatientEntity? Patient { get; set; }
}

public class PatientEntity
{
    public int PatientID { get; set; }
    public string PatientName { get; set; } = string.Empty;
    public string PatientGender { get; set; } = string.Empty;
    public int BloodTypeID { get; set; }
    public BloodTypeEntity? BloodType { get; set; }
    public List<RecordEntity> Records { get; set; } = [];
}

public class BloodTypeEntity
{
    public int BloodTypeID { get; set; }
    public string BloodTypeName { get; set; } = string.Empty;
    public string ABO { get; set; } = string.Empty;
    public bool Resus { get; set; }
    public List<PatientEntity> Patients { get; set; } = [];
}