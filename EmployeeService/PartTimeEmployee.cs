using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
    public class PartTimeEmployee : Employee
    {
        public int HourlyPay { get; set; }
        public int HoursWorked { get; set; }
    }
}
