using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperties
{
    public class EmployeesObj
    {
        private int employeeIDObj;

        public int EmployeeIDObj
        {
            get { return employeeIDObj; }
            set { employeeIDObj = value; }
        }
        private string employeeNameObj;

        public string EmployeeNameObj
        {
            get { return employeeNameObj; }
            set { employeeNameObj = value; }
        }
        private int userIDObj;

        public int UserIDObj
        {
            get { return userIDObj; }
            set { userIDObj = value; }
        }

    }
}
