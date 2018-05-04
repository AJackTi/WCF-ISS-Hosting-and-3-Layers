using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperties
{
    public class OrdersObj
    {
        private int orderIDObj;
        public int OrderIDObj
        {
            get { return orderIDObj; }
            set { orderIDObj = value; }
        }

        private int customerIDObj;

        public int CustomerIDObj
        {
            get { return customerIDObj; }
            set { customerIDObj = value; }
        }
        private int employeeIDObj;

        public int EmployeeIDObj
        {
            get { return employeeIDObj; }
            set { employeeIDObj = value; }
        }

        private DateTime orderDateObj;

        public DateTime OrderDateObj
        {
            get { return orderDateObj; }
            set { orderDateObj = value; }
        }
    }
}
