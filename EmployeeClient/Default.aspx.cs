using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetEmployee_Click(object sender, EventArgs e)
    {
        EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
        EmployeeService.Employee employee = client.GetEmployee(Convert.ToInt32(txtID.Text));

        if(employee.Type == EmployeeService.EmployeeType.FullTimeEmployee)
        {
            txtAnnualSalary.Text = ((EmployeeService.FullTimeEmployee)employee).AnnualSalary.ToString();
            trAnnualSalary.Visible = true;
            trHourlyPay.Visible = false;
            trHoursWorked.Visible = false;
        }
        else
        {
            txtHourlyPay.Text = ((EmployeeService.PartTimeEmployee)employee).HourlyPay.ToString();
            txtHoursWorked.Text = ((EmployeeService.PartTimeEmployee)employee).HoursWorked.ToString();
            trAnnualSalary.Visible = false;
            trHourlyPay.Visible = true;
            trHoursWorked.Visible = true;
        }

        txtName.Text = employee.Name;
        txtGender.Text = employee.Gender;
        txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();
        ddlEmployeeType.SelectedValue = ((int)employee.Type).ToString();
        lblMessage.Text = "Employee retrieved";
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
        EmployeeService.Employee employee = null;
        string message = string.Empty;

        if (((EmployeeService.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue)) == EmployeeService.EmployeeType.FullTimeEmployee)
        {
            employee = new EmployeeService.FullTimeEmployee
            {
                ID = Convert.ToInt32(txtID.Text),
                Name = txtName.Text,
                Gender = txtGender.Text,
                DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                Type = EmployeeService.EmployeeType.FullTimeEmployee,



                AnnualSalary = Convert.ToInt32(txtAnnualSalary.Text),
            };
            client.SaveEmployee(employee);
            lblMessage.Text = "Employee saved";
        }
        else if (((EmployeeService.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue)) == EmployeeService.EmployeeType.PartTimeEmployee)
        {
            employee = new EmployeeService.PartTimeEmployee
            {
                ID = Convert.ToInt32(txtID.Text),
                Name = txtName.Text,
                Gender = txtGender.Text,
                DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                Type = EmployeeService.EmployeeType.PartTimeEmployee,
                HourlyPay = Convert.ToInt32(txtHourlyPay.Text),
                HoursWorked = Convert.ToInt32(txtHoursWorked.Text),
            };
            client.SaveEmployee(employee);
            lblMessage.Text = "Employee saved";
        }
        else
        {
            lblMessage.Text = "Please select Employee Type";
        }
    }

    protected void ddlEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddlEmployeeType.SelectedValue == "-1")
        {
            trAnnualSalary.Visible = false;
            trHourlyPay.Visible = false;
            trHoursWorked.Visible = false;
        }
        else if (ddlEmployeeType.SelectedValue == "1")
        {
            trAnnualSalary.Visible = true;
            trHourlyPay.Visible = false;
            trHoursWorked.Visible = false;
        }
        else
        {
            trAnnualSalary.Visible = false;
            trHourlyPay.Visible = true;
            trHoursWorked.Visible = true;
        }
    }
}