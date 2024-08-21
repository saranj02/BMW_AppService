using BMW_AppService.DataAccess;
using BMW_AppService.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BMW_AppService
{
    public partial class _Default : Page
    {
        private readonly EmployeeDA _repository;
        public _Default()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
            _repository = new EmployeeDA(con);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Empservice.EmployeeModel es = new Empservice.EmployeeModel();
            if (!IsPostBack)
            {
                LoadEmployees();
            }
          
            //EmployeeService.EmployeeModel EmpService = new EmployeeService.EmployeeModel();
            //Response.Write(es.EmpName);
            //Response.Write(EmpService.G)
        }

            private void LoadEmployees()
        {
            Empservice.IEmployeeService employeeService = new Empservice.IEmployeeService();

            //var employees = employeeService.GetAllEmployee();

            //foreach (var emp in employees)
            //{
            //    Employee employee = new Employee
            //    {
            //        EmployeeCode = emp.EmpCode,
            //        NameTitle = emp.PreName,
            //        Name = emp.EmpName,
            //        Surname = emp.Surname,
            //        Gender = emp.Gender,
            //        DateOfBirth = emp.BirthDate,
            //        DateOfJoin = emp.JoinDate,
            //        Position = emp.Position,
            //        Salary = emp.Salary,
            //        DepartmentCode = Convert.ToInt16(emp.Department.DepartmantCode),
            //        TelephoneNumber = emp.TelephoneNo,
            //        LastUpdateBy = emp.LastUpdateBy
            //    };

            //    _repository.InsertEmployee(employee); // Insert into database
            //}
        }

        protected void AlertMessage(string msg)
        {
            string message = msg;
            string script = "function(){ alert('";
            script += message;
            script += "');";
            script += "window.location = '";
            script += Request.Url.AbsoluteUri;
            script += "'; }";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
        }
        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                EmployeeCode = TxtEmployeeCode.Text,
                NameTitle = DrpTitle.Text,
                Name = TxtName.Text,
                Surname = TxtSurName.Text,
                Gender = DrpGender.Text,
                DateOfBirth = Convert.ToDateTime(TxtDOB.Text),
                DateOfJoin = Convert.ToDateTime(TxtDOJ.Text),
                Position = TxtPosition.Text,
                Salary = Convert.ToDecimal(TxtSalary.Text),
                DepartmentCode = Convert.ToInt32(DrpDepartmentName.SelectedValue),
                TelephoneNumber = TxtTelephoneNo.Text,
                LastUpdateBy = TxtLastUpdateBy.Text
            };
            _repository.Insert_Update_Employee(employee,true);
            string message = "New Employee have been saved successfully.";
            AlertMessage(message);
            
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                EmployeeCode = TxtEmployeeCode.Text,
                NameTitle = DrpTitle.Text,
                Name = TxtName.Text,
                Surname = TxtSurName.Text,
                Gender = DrpGender.Text,
                DateOfBirth = Convert.ToDateTime(TxtDOB.Text),
                DateOfJoin = Convert.ToDateTime(TxtDOJ.Text),
                Position = TxtPosition.Text,
                Salary = Convert.ToDecimal(TxtSalary.Text),
                DepartmentCode = Convert.ToInt32(DrpDepartmentName.SelectedValue),
                TelephoneNumber = TxtTelephoneNo.Text,
                LastUpdateBy = TxtLastUpdateBy.Text
            };
            _repository.Insert_Update_Employee(employee, false);
            string message = "Your details have been Updated successfully.";
            AlertMessage(message);
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            string EmployeeCode = TxtEmployeeCode.Text;
            _repository.DeleteEmployee(EmployeeCode);
            string message = "Your details have been deleted successfully.";
            AlertMessage(message);
        }

        protected void DetailsBtn_Click(object sender, EventArgs e)
        {
            string EmployeeCode = TxtEmployeeCode.Text;
            var emp = _repository.GetDetailEmployee(EmployeeCode);
            if(emp !=  null)
            {
                TxtEmployeeCode.Text = emp.EmployeeCode;
                DrpTitle.SelectedValue = Convert.ToString(emp.NameTitle);
                TxtName.Text = Convert.ToString(emp.Name);
                TxtSurName.Text = Convert.ToString(emp.Surname);
                DrpGender.SelectedValue = Convert.ToString(emp.Gender);
                TxtDOB.Text = emp.DateOfBirth.ToString("yyyy-MM-dd");
                TxtDOJ.Text = emp.DateOfJoin.ToString("yyyy-MM-dd");
                TxtPosition.Text = emp.Position;
                TxtSalary.Text = Convert.ToString(emp.Salary);
                DrpDepartmentName.SelectedValue = Convert.ToString(emp.DepartmentCode);
                TxtTelephoneNo.Text = emp.TelephoneNumber;
                TxtLastUpdateBy.Text = emp.LastUpdateBy;

            }
        }
    }
}