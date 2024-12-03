namespace BloodDatabaseApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new Button();
        label1 = new Label();
        button2 = new Button();
        button3 = new Button();
        dateTimePicker1 = new DateTimePicker();
        button4 = new Button();
        numericUpDown1 = new NumericUpDown();
        comboBox1 = new ComboBox();
        numericUpDown2 = new NumericUpDown();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        comboBox2 = new ComboBox();
        button8 = new Button();
        label2 = new Label();
        button9 = new Button();
        comboBox3 = new ComboBox();
        button10 = new Button();
        button11 = new Button();
        label3 = new Label();
        label4 = new Label();
        comboBox4 = new ComboBox();
        button12 = new Button();
        button13 = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(12, 360);
        button1.Name = "button1";
        button1.Size = new Size(133, 36);
        button1.TabIndex = 0;
        button1.Text = "Blood Types";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 40);
        label1.Name = "label1";
        label1.Size = new Size(45, 17);
        label1.TabIndex = 2;
        label1.Text = "Tables";
        label1.Click += label1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(151, 360);
        button2.Name = "button2";
        button2.Size = new Size(133, 36);
        button2.TabIndex = 3;
        button2.Text = "Patients";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(12, 402);
        button3.Name = "button3";
        button3.Size = new Size(133, 36);
        button3.TabIndex = 4;
        button3.Text = "Records";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new Point(334, 71);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(133, 25);
        dateTimePicker1.TabIndex = 6;
        dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        // 
        // button4
        // 
        button4.Location = new Point(334, 102);
        button4.Name = "button4";
        button4.Size = new Size(133, 36);
        button4.TabIndex = 7;
        button4.Text = "Add";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // numericUpDown1
        // 
        numericUpDown1.Increment = new decimal(new int[] { 10, 0, 0, 0 });
        numericUpDown1.Location = new Point(334, 40);
        numericUpDown1.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
        numericUpDown1.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(133, 25);
        numericUpDown1.TabIndex = 9;
        numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
        numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(334, 9);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(133, 25);
        comboBox1.TabIndex = 10;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // numericUpDown2
        // 
        numericUpDown2.Location = new Point(486, 10);
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new Size(133, 25);
        numericUpDown2.TabIndex = 11;
        numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
        // 
        // button5
        // 
        button5.Location = new Point(640, 60);
        button5.Name = "button5";
        button5.Size = new Size(133, 36);
        button5.TabIndex = 12;
        button5.Text = "Delete";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.Location = new Point(486, 102);
        button6.Name = "button6";
        button6.Size = new Size(133, 36);
        button6.TabIndex = 13;
        button6.Text = "Select";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // button7
        // 
        button7.Location = new Point(640, 102);
        button7.Name = "button7";
        button7.Size = new Size(133, 36);
        button7.TabIndex = 17;
        button7.Text = "Change";
        button7.UseVisualStyleBackColor = true;
        button7.Click += button7_Click;
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new Point(334, 167);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(133, 25);
        comboBox2.TabIndex = 18;
        comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        // 
        // button8
        // 
        button8.Location = new Point(336, 252);
        button8.Name = "button8";
        button8.Size = new Size(131, 43);
        button8.TabIndex = 19;
        button8.Text = "Quantity by Blood Type";
        button8.UseVisualStyleBackColor = true;
        button8.Click += button8_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(452, 322);
        label2.Name = "label2";
        label2.Size = new Size(15, 17);
        label2.TabIndex = 20;
        label2.Text = "0";
        label2.Click += label2_Click;
        // 
        // button9
        // 
        button9.Location = new Point(486, 198);
        button9.Name = "button9";
        button9.Size = new Size(131, 43);
        button9.TabIndex = 21;
        button9.Text = "Records by Patient";
        button9.UseVisualStyleBackColor = true;
        button9.Click += button9_Click;
        // 
        // comboBox3
        // 
        comboBox3.FormattingEnabled = true;
        comboBox3.Location = new Point(486, 167);
        comboBox3.Name = "comboBox3";
        comboBox3.Size = new Size(133, 25);
        comboBox3.TabIndex = 22;
        comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
        // 
        // button10
        // 
        button10.Location = new Point(334, 198);
        button10.Name = "button10";
        button10.Size = new Size(133, 43);
        button10.TabIndex = 23;
        button10.Text = "Records by Blood Type";
        button10.UseVisualStyleBackColor = true;
        button10.Click += button10_Click;
        // 
        // button11
        // 
        button11.Location = new Point(486, 252);
        button11.Name = "button11";
        button11.Size = new Size(131, 43);
        button11.TabIndex = 24;
        button11.Text = "Quantity by Patient";
        button11.UseVisualStyleBackColor = true;
        button11.Click += button11_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(12, 9);
        label3.Name = "label3";
        label3.Size = new Size(45, 17);
        label3.TabIndex = 25;
        label3.Text = "Tables";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(336, 322);
        label4.Name = "label4";
        label4.Size = new Size(94, 17);
        label4.TabIndex = 26;
        label4.Text = "Blood Quantity";
        // 
        // comboBox4
        // 
        comboBox4.FormattingEnabled = true;
        comboBox4.Location = new Point(640, 167);
        comboBox4.Name = "comboBox4";
        comboBox4.Size = new Size(133, 25);
        comboBox4.TabIndex = 27;
        comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
        // 
        // button12
        // 
        button12.Location = new Point(640, 198);
        button12.Name = "button12";
        button12.Size = new Size(131, 43);
        button12.TabIndex = 28;
        button12.Text = "Records by Gender";
        button12.UseVisualStyleBackColor = true;
        button12.Click += button12_Click;
        // 
        // button13
        // 
        button13.Location = new Point(640, 252);
        button13.Name = "button13";
        button13.Size = new Size(131, 45);
        button13.TabIndex = 29;
        button13.Text = "Quantity by Gender";
        button13.UseVisualStyleBackColor = true;
        button13.Click += button13_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button13);
        Controls.Add(button12);
        Controls.Add(comboBox4);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(button11);
        Controls.Add(button10);
        Controls.Add(comboBox3);
        Controls.Add(button9);
        Controls.Add(label2);
        Controls.Add(button8);
        Controls.Add(comboBox2);
        Controls.Add(button7);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(numericUpDown2);
        Controls.Add(comboBox1);
        Controls.Add(numericUpDown1);
        Controls.Add(button4);
        Controls.Add(dateTimePicker1);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(label1);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Label label1;
    private Button button2;
    private Button button3;
    private DateTimePicker dateTimePicker1;
    private Button button4;
    private NumericUpDown numericUpDown1;
    private ComboBox comboBox1;
    private NumericUpDown numericUpDown2;
    private Button button5;
    private Button button6;
    private Button button7;
    private ComboBox comboBox2;
    private Button button8;
    private Label label2;
    private Button button9;
    private ComboBox comboBox3;
    private Button button10;
    private Button button11;
    private Label label3;
    private Label label4;
    private ComboBox comboBox4;
    private Button button12;
    private Button button13;
}

