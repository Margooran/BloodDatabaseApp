using Microsoft.EntityFrameworkCore;
using System;

namespace BloodDatabaseApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        using (var context = new BloodDbContext())
        {
            var patients = context.Patients;
            foreach (var patient in patients)
            {
                comboBox1.Items.Add(patient.PatientName);
                comboBox3.Items.Add(patient.PatientName);
            }

            numericUpDown2.Maximum = context.Records.Count();

            var bloodTypes = context.BloodTypes;
            foreach (var bloodType in bloodTypes)
            {
                comboBox2.Items.Add(bloodType.BloodTypeName);
            }
        }

        comboBox4.Items.Add("Male");
        comboBox4.Items.Add("Female");

        comboBox1.SelectedIndex = 0;
        comboBox2.SelectedIndex = 0;
        comboBox3.SelectedIndex = 0;
        comboBox4.SelectedIndex = 0;

        label1.Text = GetAllPatients();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private async void button1_Click(object sender, EventArgs e)
    {
        label1.Text = GetAllBloodTypes();
    }


    private void label1_Click(object sender, EventArgs e)
    {

    }

    private async void button2_Click(object sender, EventArgs e)
    {
        label1.Text = GetAllPatients();
    }

    private async void button3_Click(object sender, EventArgs e)
    {
        label1.Text = GetAllRecords();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        AddRecord(comboBox1.SelectedIndex + 1, Decimal.ToInt32(numericUpDown1.Value), dateTimePicker1.Value);
        label1.Text = GetAllRecords();
        numericUpDown2.Maximum++;
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {

    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {

    }

    private void button5_Click(object sender, EventArgs e)
    {
        if (Decimal.ToInt32(numericUpDown2.Value) > 0)
        {
            DeleteRecord(Decimal.ToInt32(numericUpDown2.Value));
            numericUpDown2.Maximum--;
        }
        label1.Text = GetAllRecords();
    }

    private void button6_Click(object sender, EventArgs e)
    {
        if (Decimal.ToInt32(numericUpDown2.Value) > 0)
        {
            Select(Decimal.ToInt32(numericUpDown2.Value));
        }
    }

    private void button7_Click(object sender, EventArgs e)
    {
        Change(Decimal.ToInt32(numericUpDown2.Value), comboBox1.Text, Decimal.ToInt32(numericUpDown1.Value), dateTimePicker1.Value);
        label1.Text = GetAllRecords();
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button8_Click(object sender, EventArgs e)
    {
        label2.Text = GetBloodQuantityByBloodID(comboBox2.SelectedIndex + 1).ToString();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button9_Click(object sender, EventArgs e)
    {
        label1.Text = GetRecordsByPatient(comboBox3.SelectedIndex + 1);
    }

    private void button10_Click(object sender, EventArgs e)
    {
        label1.Text = GetRecordsByBloodID(comboBox2.SelectedIndex + 1);
    }

    private void button11_Click(object sender, EventArgs e)
    {
        label2.Text = GetBloodQuantityByPatientID(comboBox3.SelectedIndex + 1).ToString();
    }

    private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button12_Click(object sender, EventArgs e)
    {
        label1.Text = GetRecordsByGender(comboBox4.Text);
    }

    private void button13_Click(object sender, EventArgs e)
    {
        label2.Text = GetQuantityByGender(comboBox4.Text).ToString();
    }
}
