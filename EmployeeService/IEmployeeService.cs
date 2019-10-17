using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    /*Solution 2 for known type
    [ServiceKnownType(typeof(FullTimeEmployee))]
    [ServiceKnownType(typeof(PartTimeEmployee))]*/
    [ServiceContract]
    public interface IEmployeeService
    {
        /*Solution 3 for known type
        [ServiceKnownType(typeof(FullTimeEmployee))]
        [ServiceKnownType(typeof(PartTimeEmployee))]*/
        [OperationContract]
        Employee GetEmployee(int Id);

        [OperationContract]
        void SaveEmployee(Employee employee);
    }
}
