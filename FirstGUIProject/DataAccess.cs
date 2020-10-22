using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FirstGUIProject
{
  public class DataAccess
  {
    public List<Employee> GetEmployeeList(string lastName)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
      {
        var output = connection.Query<Employee>($"SELECT * FROM Employee WHERE LastName = '{lastName}'").ToList();
        return output;
      }
    }
    public Employee GetEmployeeByLastName(string lastName)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
      {
        var output = connection.Query<Employee>($"SELECT * FROM Employee WHERE LastName = '{lastName}'").FirstOrDefault();
        return output;
      }
    }
    public Employee GetEmployeeByID(string ID)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
      {
        var output = connection.Query<Employee>($"SELECT * FROM Employee WHERE ID = '{ID}'").FirstOrDefault();
        return output;
      }
    }
    public Employee GetEmployeeByFirstName(string FirstName)
    {
      using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("EmployeeDB")))
      {
        var output = connection.Query<Employee>($"SELECT * FROM Employee WHERE FirstName = '{FirstName}'").FirstOrDefault();
        return output;
      }
    }
  }
}
