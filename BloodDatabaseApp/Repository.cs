using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDatabaseApp;

partial class Form1
{
    private string GetAllBloodTypes()
    {
        using (var context = new BloodDbContext())
        {
            var bloodTypes = context.BloodTypes;
            string result = string.Empty;
            int i = 1;
            foreach (var bloodType in bloodTypes)
            {
                result += i++ + ") " + bloodType.BloodTypeName + " " + bloodType.ABO + " " + bloodType.Resus.ToString() + "\n";
            }
            return result;
        }
    }

    private string GetAllPatients()
    {
        using (var context = new BloodDbContext())
        {
            var patients = context.Patients;
            string result = string.Empty;
            int i = 1;
            foreach (var patient in patients)
            {
                var bloodType = context.BloodTypes.FirstOrDefault(p => p.BloodTypeID == patient.BloodTypeID);
                result += i++ + ") " + patient.PatientName + " " + patient.PatientGender + " " + bloodType.BloodTypeName + "\n";
            }
            return result;
        }
    }

    private string GetAllRecords()
    {
        using (var context = new BloodDbContext())
        {
            var records = context.Records.ToList();
            return GetRecords(records);
        }
    }

    private string GetRecords(List<RecordEntity> records)
    {
        using (var context = new BloodDbContext())
        {
            string result = string.Empty;
            int i = 1;
            foreach (var record in records)
            {
                var patient = context.Patients.FirstOrDefault(p => p.PatientID == record.PatientID);
                var bloodType = context.BloodTypes.FirstOrDefault(p => p.BloodTypeID == patient.BloodTypeID);
                result += i++ + ") " + patient.PatientName + " " + bloodType.BloodTypeName + " " + record.Quantity + " " + record.DateTime.Date.ToShortDateString() + "\n";
            }
            return result;
        }
    }

    private async void AddRecord(int patientID, int quantity, DateTime dateTime)
    {
        using (var context = new BloodDbContext())
        {;
            var record = new RecordEntity
            {
                PatientID = patientID,
                Quantity = quantity,
                DateTime = dateTime
            };
            context.Records.Add(record);
            await context.SaveChangesAsync();
        }
    }

    private async void DeleteRecord(int recordNum)
    {
        using (var context = new BloodDbContext())
        {
            var record = context.Records
                .OrderBy(r => r.RecordID)
                .Skip(recordNum - 1)
                .FirstOrDefault();
            context.Records.Remove(record);
            await context.SaveChangesAsync();
        }
    }

    private void Select(int recordNum)
    {
        using (var context = new BloodDbContext())
        {
            var record = context.Records
                .OrderBy(r => r.RecordID)
                .Skip(recordNum - 1)
                .FirstOrDefault();

            numericUpDown1.Value = record.Quantity;
            comboBox1.SelectedIndex = record.PatientID - 1;
            dateTimePicker1.Value = record.DateTime;
        }
    }

    private async void Change(int recordNum, string patientName, int quantity, DateTime dateTime)
    {
        using (var context = new BloodDbContext())
        {
            var record = await context.Records
                .OrderBy(r => r.RecordID)
                .Skip(recordNum - 1)
                .FirstOrDefaultAsync();

            record.Quantity = quantity;
            record.DateTime = dateTime;

            var patient = await context.Patients
                .FirstOrDefaultAsync(p => p.PatientName == patientName);

            record.PatientID = patient.PatientID;

            await context.SaveChangesAsync();
        }
    }
    private int GetBloodQuantityByBloodID(int bloodTypeID)
    {
        using (var context = new BloodDbContext())
        {
            var records = context.Records
                .Include(r => r.Patient)
                .Where(r => r.Patient.BloodTypeID == bloodTypeID)
                .ToList();

            return GetBloodQuantity(records);
        }
    }

    private int GetBloodQuantity(List<RecordEntity> records)
    {
        using (var context = new BloodDbContext())
        {
            int totalQuantity = 0;
            foreach (var record in records)
            {
                totalQuantity += record.Quantity;
            }

            return totalQuantity;
        }
    }

    private string GetRecordsByBloodID(int bloodTypeID)
    {
        using (var context = new BloodDbContext())
        {
            var records = context.Records
                .Include(r => r.Patient)
                .Where(r => r.Patient.BloodTypeID == bloodTypeID)
                .ToList();

            return GetRecords(records);
        }
    }

    private int GetBloodQuantityByPatientID(int PatientID)
    {
        using (var context = new BloodDbContext())
        {
            var records = context.Records
                .Where(r => r.PatientID == PatientID)
                .ToList();
            return GetBloodQuantity(records);
        }
    }

    private string GetRecordsByPatient(int PatientID)
    {
        using (var context = new BloodDbContext())
        {
            var records = context.Records
                .Where(r=>r.PatientID == PatientID)
                .ToList();
            return GetRecords(records);
        }
    }

    private string GetRecordsByGender(string Gender)
    {
        using (var context = new BloodDbContext())
        {
            var records = context.Records
                .Include(r => r.Patient)
                .Where(r => r.Patient.PatientGender == Gender)
                .ToList();
            return GetRecords(records);
        }
    }

    private int GetQuantityByGender(string Gender)
    {
        using (var context = new BloodDbContext())
        {
            var records = context.Records
                .Include(r => r.Patient)
                .Where(r => r.Patient.PatientGender == Gender)
                .ToList();
            return GetBloodQuantity(records);
        }
    }
}
