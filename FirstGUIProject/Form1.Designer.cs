namespace FirstGUIProject
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.ID = new System.Windows.Forms.MaskedTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.NamePrefix = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.FirstName = new System.Windows.Forms.TextBox();
      this.MiddleInitial = new System.Windows.Forms.TextBox();
      this.LastName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.Gender = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.DrugTestDateLast = new System.Windows.Forms.MaskedTextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.EMail = new System.Windows.Forms.TextBox();
      this.DateOfBirth = new System.Windows.Forms.MaskedTextBox();
      this.State = new System.Windows.Forms.TextBox();
      this.PreviousSalary = new System.Windows.Forms.TextBox();
      this.LastPayHike = new System.Windows.Forms.MaskedTextBox();
      this.Salary = new System.Windows.Forms.MaskedTextBox();
      this.DateHired = new System.Windows.Forms.MaskedTextBox();
      this.UserName = new System.Windows.Forms.TextBox();
      this.ZipCode = new System.Windows.Forms.MaskedTextBox();
      this.City = new System.Windows.Forms.TextBox();
      this.PhoneNumber = new System.Windows.Forms.MaskedTextBox();
      this.County = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.label17 = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.label19 = new System.Windows.Forms.Label();
      this.SSN = new System.Windows.Forms.MaskedTextBox();
      this.label20 = new System.Windows.Forms.Label();
      this.label21 = new System.Windows.Forms.Label();
      this.Password = new System.Windows.Forms.TextBox();
      this.FindEmployeeByID = new System.Windows.Forms.Button();
      this.FindEmployeeByLastName = new System.Windows.Forms.Button();
      this.FindEmployeeByFirstName = new System.Windows.Forms.Button();
      this.Cancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // ID
      // 
      this.ID.BackColor = System.Drawing.SystemColors.Info;
      this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ID.ForeColor = System.Drawing.SystemColors.MenuText;
      this.ID.Location = new System.Drawing.Point(28, 30);
      this.ID.Mask = "000000";
      this.ID.Name = "ID";
      this.ID.Size = new System.Drawing.Size(61, 26);
      this.ID.TabIndex = 1;
      this.ID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ID_MouseClick);
      this.ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_KeyDown);
      // 
      // label1
      // 
      this.label1.AllowDrop = true;
      this.label1.AutoSize = true;
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(28, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 15);
      this.label1.TabIndex = 2;
      this.label1.Text = "Employee ID";
      // 
      // NamePrefix
      // 
      this.NamePrefix.BackColor = System.Drawing.SystemColors.Info;
      this.NamePrefix.Location = new System.Drawing.Point(28, 77);
      this.NamePrefix.Name = "NamePrefix";
      this.NamePrefix.ReadOnly = true;
      this.NamePrefix.Size = new System.Drawing.Size(45, 20);
      this.NamePrefix.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(28, 59);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 15);
      this.label2.TabIndex = 4;
      this.label2.Text = "Prefix:";
      // 
      // FirstName
      // 
      this.FirstName.BackColor = System.Drawing.SystemColors.Info;
      this.FirstName.Location = new System.Drawing.Point(99, 77);
      this.FirstName.Name = "FirstName";
      this.FirstName.Size = new System.Drawing.Size(100, 20);
      this.FirstName.TabIndex = 5;
      this.FirstName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FirstName_MouseClick);
      this.FirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FirstName_KeyDown);
      // 
      // MiddleInitial
      // 
      this.MiddleInitial.BackColor = System.Drawing.SystemColors.Info;
      this.MiddleInitial.Location = new System.Drawing.Point(215, 77);
      this.MiddleInitial.MaxLength = 1;
      this.MiddleInitial.Name = "MiddleInitial";
      this.MiddleInitial.ReadOnly = true;
      this.MiddleInitial.Size = new System.Drawing.Size(27, 20);
      this.MiddleInitial.TabIndex = 6;
      this.MiddleInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // LastName
      // 
      this.LastName.BackColor = System.Drawing.SystemColors.Info;
      this.LastName.Location = new System.Drawing.Point(258, 77);
      this.LastName.Name = "LastName";
      this.LastName.Size = new System.Drawing.Size(100, 20);
      this.LastName.TabIndex = 7;
      this.LastName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LastName_MouseClick);
      this.LastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LastName_KeyDown);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(99, 59);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(73, 15);
      this.label3.TabIndex = 8;
      this.label3.Text = "First Name:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(215, 59);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(27, 15);
      this.label4.TabIndex = 9;
      this.label4.Text = "MI:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(258, 59);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(73, 15);
      this.label5.TabIndex = 10;
      this.label5.Text = "Last Name:";
      // 
      // Gender
      // 
      this.Gender.BackColor = System.Drawing.SystemColors.Info;
      this.Gender.Location = new System.Drawing.Point(395, 77);
      this.Gender.Name = "Gender";
      this.Gender.ReadOnly = true;
      this.Gender.Size = new System.Drawing.Size(24, 20);
      this.Gender.TabIndex = 11;
      this.Gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(380, 59);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(54, 15);
      this.label6.TabIndex = 12;
      this.label6.Text = "Gender:";
      // 
      // DrugTestDateLast
      // 
      this.DrugTestDateLast.BackColor = System.Drawing.SystemColors.Info;
      this.DrugTestDateLast.Location = new System.Drawing.Point(610, 77);
      this.DrugTestDateLast.Mask = "00/00/0000";
      this.DrugTestDateLast.Name = "DrugTestDateLast";
      this.DrugTestDateLast.ReadOnly = true;
      this.DrugTestDateLast.Size = new System.Drawing.Size(142, 20);
      this.DrugTestDateLast.TabIndex = 13;
      this.DrugTestDateLast.ValidatingType = typeof(System.DateTime);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(610, 59);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(142, 15);
      this.label7.TabIndex = 14;
      this.label7.Text = "Date Last Drug Tested:";
      // 
      // EMail
      // 
      this.EMail.BackColor = System.Drawing.SystemColors.Info;
      this.EMail.Location = new System.Drawing.Point(28, 133);
      this.EMail.Name = "EMail";
      this.EMail.ReadOnly = true;
      this.EMail.Size = new System.Drawing.Size(193, 20);
      this.EMail.TabIndex = 15;
      // 
      // DateOfBirth
      // 
      this.DateOfBirth.BackColor = System.Drawing.SystemColors.Info;
      this.DateOfBirth.Location = new System.Drawing.Point(456, 77);
      this.DateOfBirth.Mask = "00/00/0000";
      this.DateOfBirth.Name = "DateOfBirth";
      this.DateOfBirth.ReadOnly = true;
      this.DateOfBirth.Size = new System.Drawing.Size(100, 20);
      this.DateOfBirth.TabIndex = 16;
      this.DateOfBirth.ValidatingType = typeof(System.DateTime);
      // 
      // State
      // 
      this.State.BackColor = System.Drawing.SystemColors.Info;
      this.State.Location = new System.Drawing.Point(178, 189);
      this.State.Name = "State";
      this.State.ReadOnly = true;
      this.State.Size = new System.Drawing.Size(100, 20);
      this.State.TabIndex = 17;
      // 
      // PreviousSalary
      // 
      this.PreviousSalary.BackColor = System.Drawing.SystemColors.Info;
      this.PreviousSalary.Location = new System.Drawing.Point(610, 344);
      this.PreviousSalary.Name = "PreviousSalary";
      this.PreviousSalary.ReadOnly = true;
      this.PreviousSalary.Size = new System.Drawing.Size(100, 20);
      this.PreviousSalary.TabIndex = 18;
      // 
      // LastPayHike
      // 
      this.LastPayHike.BackColor = System.Drawing.SystemColors.Info;
      this.LastPayHike.Location = new System.Drawing.Point(610, 293);
      this.LastPayHike.Name = "LastPayHike";
      this.LastPayHike.ReadOnly = true;
      this.LastPayHike.Size = new System.Drawing.Size(100, 20);
      this.LastPayHike.TabIndex = 19;
      // 
      // Salary
      // 
      this.Salary.BackColor = System.Drawing.SystemColors.Info;
      this.Salary.Location = new System.Drawing.Point(610, 243);
      this.Salary.Name = "Salary";
      this.Salary.ReadOnly = true;
      this.Salary.Size = new System.Drawing.Size(100, 20);
      this.Salary.TabIndex = 20;
      // 
      // DateHired
      // 
      this.DateHired.BackColor = System.Drawing.SystemColors.Info;
      this.DateHired.Location = new System.Drawing.Point(456, 133);
      this.DateHired.Mask = "00/00/0000";
      this.DateHired.Name = "DateHired";
      this.DateHired.ReadOnly = true;
      this.DateHired.Size = new System.Drawing.Size(100, 20);
      this.DateHired.TabIndex = 21;
      this.DateHired.ValidatingType = typeof(System.DateTime);
      // 
      // UserName
      // 
      this.UserName.BackColor = System.Drawing.SystemColors.Info;
      this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.UserName.Location = new System.Drawing.Point(28, 273);
      this.UserName.Name = "UserName";
      this.UserName.ReadOnly = true;
      this.UserName.Size = new System.Drawing.Size(229, 26);
      this.UserName.TabIndex = 22;
      // 
      // ZipCode
      // 
      this.ZipCode.BackColor = System.Drawing.SystemColors.Info;
      this.ZipCode.Location = new System.Drawing.Point(528, 189);
      this.ZipCode.Mask = "00000";
      this.ZipCode.Name = "ZipCode";
      this.ZipCode.ReadOnly = true;
      this.ZipCode.Size = new System.Drawing.Size(61, 20);
      this.ZipCode.TabIndex = 23;
      this.ZipCode.ValidatingType = typeof(int);
      // 
      // City
      // 
      this.City.BackColor = System.Drawing.SystemColors.Info;
      this.City.Location = new System.Drawing.Point(412, 189);
      this.City.Name = "City";
      this.City.ReadOnly = true;
      this.City.Size = new System.Drawing.Size(100, 20);
      this.City.TabIndex = 24;
      // 
      // PhoneNumber
      // 
      this.PhoneNumber.BackColor = System.Drawing.SystemColors.Info;
      this.PhoneNumber.Location = new System.Drawing.Point(28, 189);
      this.PhoneNumber.Mask = "(999) 000-0000";
      this.PhoneNumber.Name = "PhoneNumber";
      this.PhoneNumber.ReadOnly = true;
      this.PhoneNumber.Size = new System.Drawing.Size(119, 20);
      this.PhoneNumber.TabIndex = 25;
      // 
      // County
      // 
      this.County.BackColor = System.Drawing.SystemColors.Info;
      this.County.Location = new System.Drawing.Point(296, 189);
      this.County.Name = "County";
      this.County.ReadOnly = true;
      this.County.Size = new System.Drawing.Size(100, 20);
      this.County.TabIndex = 26;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(28, 171);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(96, 15);
      this.label8.TabIndex = 27;
      this.label8.Text = "Phone Number:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(178, 171);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(43, 15);
      this.label9.TabIndex = 28;
      this.label9.Text = "State:";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(296, 171);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(52, 15);
      this.label10.TabIndex = 29;
      this.label10.Text = "County:";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(412, 171);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(34, 15);
      this.label11.TabIndex = 30;
      this.label11.Text = "City:";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(28, 255);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(69, 15);
      this.label12.TabIndex = 31;
      this.label12.Text = "Username:";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(456, 115);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(82, 15);
      this.label13.TabIndex = 32;
      this.label13.Text = "Date of Hire:";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(610, 225);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(48, 15);
      this.label14.TabIndex = 33;
      this.label14.Text = "Salary:";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label15.Location = new System.Drawing.Point(610, 275);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(92, 15);
      this.label15.TabIndex = 34;
      this.label15.Text = "Last Pay Hike:";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label16.Location = new System.Drawing.Point(258, 115);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(38, 15);
      this.label16.TabIndex = 35;
      this.label16.Text = "SSN:";
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label17.Location = new System.Drawing.Point(528, 171);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(59, 15);
      this.label17.TabIndex = 36;
      this.label17.Text = "Zipcode:";
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label18.Location = new System.Drawing.Point(456, 59);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(39, 15);
      this.label18.TabIndex = 37;
      this.label18.Text = "DOB:";
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label19.Location = new System.Drawing.Point(31, 115);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(48, 15);
      this.label19.TabIndex = 38;
      this.label19.Text = "E-Mail:";
      // 
      // SSN
      // 
      this.SSN.BackColor = System.Drawing.SystemColors.Info;
      this.SSN.Location = new System.Drawing.Point(258, 133);
      this.SSN.Mask = "000-00-0000";
      this.SSN.Name = "SSN";
      this.SSN.ReadOnly = true;
      this.SSN.Size = new System.Drawing.Size(100, 20);
      this.SSN.TabIndex = 39;
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label20.Location = new System.Drawing.Point(610, 326);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(105, 15);
      this.label20.TabIndex = 40;
      this.label20.Text = "Before Pay Hike:";
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label21.Location = new System.Drawing.Point(28, 318);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(67, 15);
      this.label21.TabIndex = 41;
      this.label21.Text = "Password:";
      // 
      // Password
      // 
      this.Password.BackColor = System.Drawing.SystemColors.Info;
      this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Password.Location = new System.Drawing.Point(28, 336);
      this.Password.Name = "Password";
      this.Password.ReadOnly = true;
      this.Password.Size = new System.Drawing.Size(229, 26);
      this.Password.TabIndex = 42;
      // 
      // FindEmployeeByID
      // 
      this.FindEmployeeByID.BackColor = System.Drawing.SystemColors.ControlLight;
      this.FindEmployeeByID.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
      this.FindEmployeeByID.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
      this.FindEmployeeByID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.FindEmployeeByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FindEmployeeByID.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FindEmployeeByID.Location = new System.Drawing.Point(133, 7);
      this.FindEmployeeByID.Name = "FindEmployeeByID";
      this.FindEmployeeByID.Size = new System.Drawing.Size(154, 23);
      this.FindEmployeeByID.TabIndex = 43;
      this.FindEmployeeByID.Text = "Find Employee By ID";
      this.FindEmployeeByID.UseVisualStyleBackColor = false;
      this.FindEmployeeByID.Click += new System.EventHandler(this.FindEmployeeByID_Click);
      // 
      // FindEmployeeByLastName
      // 
      this.FindEmployeeByLastName.BackColor = System.Drawing.SystemColors.ControlLight;
      this.FindEmployeeByLastName.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
      this.FindEmployeeByLastName.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
      this.FindEmployeeByLastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.FindEmployeeByLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FindEmployeeByLastName.Location = new System.Drawing.Point(426, 7);
      this.FindEmployeeByLastName.Name = "FindEmployeeByLastName";
      this.FindEmployeeByLastName.Size = new System.Drawing.Size(127, 23);
      this.FindEmployeeByLastName.TabIndex = 44;
      this.FindEmployeeByLastName.Text = "Find By Last Name";
      this.FindEmployeeByLastName.UseVisualStyleBackColor = false;
      this.FindEmployeeByLastName.Click += new System.EventHandler(this.FindEmployeeByLastName_Click);
      // 
      // FindEmployeeByFirstName
      // 
      this.FindEmployeeByFirstName.BackColor = System.Drawing.SystemColors.ControlLight;
      this.FindEmployeeByFirstName.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
      this.FindEmployeeByFirstName.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
      this.FindEmployeeByFirstName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.FindEmployeeByFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FindEmployeeByFirstName.Location = new System.Drawing.Point(293, 7);
      this.FindEmployeeByFirstName.Name = "FindEmployeeByFirstName";
      this.FindEmployeeByFirstName.Size = new System.Drawing.Size(127, 23);
      this.FindEmployeeByFirstName.TabIndex = 45;
      this.FindEmployeeByFirstName.Text = "Find By First Name";
      this.FindEmployeeByFirstName.UseVisualStyleBackColor = false;
      this.FindEmployeeByFirstName.Click += new System.EventHandler(this.FindEmployeeByFirstName_Click);
      // 
      // Cancel
      // 
      this.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
      this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
      this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
      this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Cancel.Location = new System.Drawing.Point(31, 428);
      this.Cancel.Name = "Cancel";
      this.Cancel.Size = new System.Drawing.Size(59, 23);
      this.Cancel.TabIndex = 46;
      this.Cancel.Text = "Cancel";
      this.Cancel.UseVisualStyleBackColor = true;
      this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.CancelButton = this.Cancel;
      this.ClientSize = new System.Drawing.Size(809, 463);
      this.Controls.Add(this.Cancel);
      this.Controls.Add(this.FindEmployeeByFirstName);
      this.Controls.Add(this.FindEmployeeByLastName);
      this.Controls.Add(this.FindEmployeeByID);
      this.Controls.Add(this.Password);
      this.Controls.Add(this.label21);
      this.Controls.Add(this.label20);
      this.Controls.Add(this.SSN);
      this.Controls.Add(this.label19);
      this.Controls.Add(this.label18);
      this.Controls.Add(this.label17);
      this.Controls.Add(this.label16);
      this.Controls.Add(this.label15);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.County);
      this.Controls.Add(this.PhoneNumber);
      this.Controls.Add(this.City);
      this.Controls.Add(this.ZipCode);
      this.Controls.Add(this.UserName);
      this.Controls.Add(this.DateHired);
      this.Controls.Add(this.Salary);
      this.Controls.Add(this.LastPayHike);
      this.Controls.Add(this.PreviousSalary);
      this.Controls.Add(this.State);
      this.Controls.Add(this.DateOfBirth);
      this.Controls.Add(this.EMail);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.DrugTestDateLast);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.Gender);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.LastName);
      this.Controls.Add(this.MiddleInitial);
      this.Controls.Add(this.FirstName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.NamePrefix);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.ID);
      this.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MaskedTextBox ID;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox NamePrefix;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox FirstName;
    private System.Windows.Forms.TextBox MiddleInitial;
    private System.Windows.Forms.TextBox LastName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox Gender;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox EMail;
    private System.Windows.Forms.MaskedTextBox DateOfBirth;
    private System.Windows.Forms.TextBox State;
    private System.Windows.Forms.TextBox PreviousSalary;
    private System.Windows.Forms.MaskedTextBox LastPayHike;
    private System.Windows.Forms.MaskedTextBox Salary;
    private System.Windows.Forms.MaskedTextBox DateHired;
    private System.Windows.Forms.TextBox UserName;
    private System.Windows.Forms.MaskedTextBox ZipCode;
    private System.Windows.Forms.TextBox City;
    private System.Windows.Forms.MaskedTextBox PhoneNumber;
    private System.Windows.Forms.TextBox County;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.MaskedTextBox SSN;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.TextBox Password;
    private System.Windows.Forms.MaskedTextBox DrugTestDateLast;
    private System.Windows.Forms.Button FindEmployeeByID;
    private System.Windows.Forms.Button FindEmployeeByLastName;
    private System.Windows.Forms.Button FindEmployeeByFirstName;
    private System.Windows.Forms.Button Cancel;
  }
}

