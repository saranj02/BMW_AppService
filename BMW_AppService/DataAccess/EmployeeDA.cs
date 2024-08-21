using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using BMW_AppService.Model;
using System.Data;

namespace BMW_AppService.DataAccess
{
    public class EmployeeDA
    {
        private readonly SqlConnection _connectionString;

        public EmployeeDA(SqlConnection connectionString)
        {
            _connectionString = connectionString;
        }

        public void Insert_Update_Employee(Employee emp, bool IsAddNew)
        {
            using (_connectionString)
            {
                _connectionString.Open();
                SqlCommand sql_cmnd;
                if (IsAddNew)
                    sql_cmnd = new SqlCommand("[dbo].[SP_Employee_Insert]", _connectionString);
                else sql_cmnd = new SqlCommand("[dbo].[sp_Employee_Update]", _connectionString);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@EmployeeCode", SqlDbType.VarChar).Value = emp.EmployeeCode;
                sql_cmnd.Parameters.AddWithValue("@NameTitle", SqlDbType.VarChar).Value = emp.NameTitle;
                sql_cmnd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = emp.Name;
                sql_cmnd.Parameters.AddWithValue("@Surname", SqlDbType.NVarChar).Value = emp.Surname;
                sql_cmnd.Parameters.AddWithValue("@Gender", SqlDbType.Char).Value = emp.Gender;
                sql_cmnd.Parameters.AddWithValue("@DateOfBirth", SqlDbType.Date).Value = emp.DateOfBirth;
                sql_cmnd.Parameters.AddWithValue("@DateOfJoin", SqlDbType.Date).Value = emp.DateOfJoin;
                sql_cmnd.Parameters.AddWithValue("@Position", SqlDbType.NVarChar).Value = emp.Position;
                sql_cmnd.Parameters.AddWithValue("@Salary", SqlDbType.Decimal).Value = emp.Salary;
                sql_cmnd.Parameters.AddWithValue("@DepartmentCode", SqlDbType.Int).Value = emp.DepartmentCode;
                sql_cmnd.Parameters.AddWithValue("@K_TelephoneNumber", SqlDbType.VarChar).Value = emp.TelephoneNumber;
                sql_cmnd.Parameters.AddWithValue("@L_LastUpdateBy", SqlDbType.NVarChar).Value = emp.LastUpdateBy;
                sql_cmnd.ExecuteNonQuery();
                _connectionString.Close();
            }
        }

        public void DeleteEmployee(string EmpCode)
        {
            using (_connectionString)
            {
                _connectionString.Open();
                SqlCommand sql_cmnd;
                sql_cmnd = new SqlCommand("[dbo].[SP_Employee_Delete]", _connectionString);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@EmployeeCode", SqlDbType.VarChar).Value = EmpCode;
                sql_cmnd.ExecuteNonQuery();
                _connectionString.Close();
            }
        }

        public Employee GetDetailEmployee(string EmpCode)
        {
            SqlDataReader reader;
            Employee employee = new Employee();

            using (_connectionString)
            {
                _connectionString.Open();
                SqlCommand sql_cmnd;
                sql_cmnd = new SqlCommand("[dbo].[SP_Employee_Details]", _connectionString);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@EmployeeCode", SqlDbType.VarChar).Value = EmpCode;
                reader = sql_cmnd.ExecuteReader();
                while (reader.Read())
                {

                    employee.EmployeeCode = reader["EmployeeCode"].ToString();
                    employee.NameTitle = Convert.ToString(reader["NameTitle"]);
                    employee.Name = Convert.ToString(reader["Name"]);
                    employee.Surname = Convert.ToString(reader["Surname"]);
                    employee.Gender = Convert.ToString(reader["Gender"]);
                    employee.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]); //.ToString("MM/dd/YYYY");
                    employee.DateOfJoin = Convert.ToDateTime(reader["DateOfJoin"]);
                    employee.Position = Convert.ToString(reader["Position"]);
                    employee.Salary = Convert.ToDecimal(reader["Salary"]);
                    employee.DepartmentCode = Convert.ToInt32(reader["DepartmentCode"]);
                    employee.TelephoneNumber = Convert.ToString(reader["K_TelephoneNumber"]);
                    employee.LastUpdateBy = Convert.ToString(reader["L_LastUpdateBy"]);
                }

            }
            
            
            //_connectionString.Close();
            //reader.Close();
            return employee;
        }


    }
}

