using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FirstGUIProject
{
  public partial class Form1 : Form
  {
    Dictionary<string, Employee> employeeInfoData = new Dictionary<string, Employee>();
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      string line = "";
      int selection = 1;
      int numDayTestLimit = -180;
      DateTime dateTestLimit = DateTime.Today.AddDays(numDayTestLimit);
      var rand = new Random();

      StreamReader reader = new StreamReader(@"EmployeeRecords.csv");
      
      Dictionary<string, Employee> employeesEligible = new Dictionary<string, Employee>();
      Dictionary<string, Employee> employeesSelectedForTesting = new Dictionary<string, Employee>();

      int i = 1;

      while (line != null)
      {
        line = reader.ReadLine();

        if (line != null)
        {
          if (i > 1)
          {
            string[] employeeInformation = line.Split(',');
            // got stuck here
            Employee emp = new Employee();
            emp.ID = employeeInformation[0];
            emp.NamePrefix = employeeInformation[1];
            emp.FirstName = employeeInformation[2];
            emp.MiddleInitial = employeeInformation[3];
            emp.LastName = employeeInformation[4];
            emp.Gender = employeeInformation[5];
            emp.DrugTestDateLast = Convert.ToDateTime(employeeInformation[6]);
            emp.EMail = employeeInformation[7];
            emp.DateOfBirth = Convert.ToDateTime(employeeInformation[8]);
            emp.DateHired = Convert.ToDateTime(employeeInformation[9]);
            emp.Salary = Convert.ToDecimal(employeeInformation[10]);
            emp.LastPayHike = Convert.ToDecimal(employeeInformation[11]);
            emp.SSN = employeeInformation[12];
            emp.PhoneNumber = employeeInformation[13];
            emp.County = employeeInformation[14];
            emp.City = employeeInformation[15];
            emp.State = employeeInformation[16];
            emp.ZipCode = employeeInformation[17];
            emp.UserName = employeeInformation[18];
            emp.Password = employeeInformation[19];

            employeeInfoData.Add(employeeInformation[0], emp);
          }
          i++;
        }
      }
    }
    private void Cancel_Click(object sender, EventArgs e)
    {
      Close();
    }
    private void FindEmployeeByID_Click(object sender, EventArgs e)
    {
      Employee emp = new Employee();
      if (!employeeInfoData.ContainsKey(ID.Text))
      {
        MessageBox.Show("Invalid Employee ID.");
        ID.Clear();
        return;
      }
      emp = employeeInfoData[ID.Text];

      NamePrefix.Text = emp.NamePrefix;
      FirstName.Text = emp.FirstName;
      MiddleInitial.Text = emp.MiddleInitial;
      LastName.Text = emp.LastName;
      Gender.Text = emp.Gender;
      DrugTestDateLast.Text = Convert.ToString(emp.DrugTestDateLast);
      EMail.Text = emp.EMail;
      DateOfBirth.Text = Convert.ToString(emp.DateOfBirth);
      DateHired.Text = Convert.ToString(emp.DateHired);
      Salary.Text = Convert.ToString(emp.Salary);
      LastPayHike.Text = Convert.ToString(emp.LastPayHike);
      SSN.Text = emp.SSN;
      PhoneNumber.Text = emp.PhoneNumber;
      County.Text = emp.County;
      City.Text = emp.City;
      State.Text = emp.State;
      ZipCode.Text = emp.ZipCode;
      UserName.Text = emp.UserName;
      Password.Text = emp.Password;
    }
    private void ID_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        FindEmployeeByID_Click(this, new EventArgs());
      }
    }
    
    private void FirstName_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        FindEmployeeByFirstName_Click(this, new EventArgs());
      }
    }
    private void LastName_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        FindEmployeeByLastName_Click(this, new EventArgs());
      }
    }
    private void ID_MouseClick(object sender, MouseEventArgs e)
    {
      ID.SelectionStart = 0;
    }

    private void FirstName_MouseClick(object sender, MouseEventArgs e)
    {
      FirstName.SelectionStart = 0;
    }

    private void LastName_MouseClick(object sender, MouseEventArgs e)
    {
      LastName.SelectionStart = 0;
    }

    private void FindEmployeeByLastName_Click(object sender, EventArgs e)
    {
      Employee emp = new Employee();
      
      foreach (KeyValuePair<string, Employee> entry in employeeInfoData)
      {
        if (entry.Value.LastName == LastName.Text)
        {
          emp = entry.Value;

          ID.Text = entry.Key;
          NamePrefix.Text = emp.NamePrefix;
          FirstName.Text = emp.FirstName;
          MiddleInitial.Text = emp.MiddleInitial;
          LastName.Text = emp.LastName;
          Gender.Text = emp.Gender;
          DrugTestDateLast.Text = Convert.ToString(emp.DrugTestDateLast);
          EMail.Text = emp.EMail;
          DateOfBirth.Text = Convert.ToString(emp.DateOfBirth);
          DateHired.Text = Convert.ToString(emp.DateHired);
          Salary.Text = Convert.ToString(emp.Salary);
          LastPayHike.Text = Convert.ToString(emp.LastPayHike);
          SSN.Text = emp.SSN;
          PhoneNumber.Text = emp.PhoneNumber;
          County.Text = emp.County;
          City.Text = emp.City;
          State.Text = emp.State;
          ZipCode.Text = emp.ZipCode;
          UserName.Text = emp.UserName;
          Password.Text = emp.Password;
          return;
        }
      }
    }

    private void FindEmployeeByFirstName_Click(object sender, EventArgs e)
    {
      Employee emp = new Employee();

      foreach (KeyValuePair<string, Employee> entry in employeeInfoData)
      {
        if (entry.Value.FirstName == FirstName.Text)
        {
          emp = entry.Value;

          ID.Text = entry.Key;
          NamePrefix.Text = emp.NamePrefix;
          FirstName.Text = emp.FirstName;
          MiddleInitial.Text = emp.MiddleInitial;
          LastName.Text = emp.LastName;
          Gender.Text = emp.Gender;
          DrugTestDateLast.Text = Convert.ToString(emp.DrugTestDateLast);
          EMail.Text = emp.EMail;
          DateOfBirth.Text = Convert.ToString(emp.DateOfBirth);
          DateHired.Text = Convert.ToString(emp.DateHired);
          Salary.Text = Convert.ToString(emp.Salary);
          LastPayHike.Text = Convert.ToString(emp.LastPayHike);
          SSN.Text = emp.SSN;
          PhoneNumber.Text = emp.PhoneNumber;
          County.Text = emp.County;
          City.Text = emp.City;
          State.Text = emp.State;
          ZipCode.Text = emp.ZipCode;
          UserName.Text = emp.UserName;
          Password.Text = emp.Password;
          return;
        }
      }
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        this.Close();
      }
    }

  }
}
