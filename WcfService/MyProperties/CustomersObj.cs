using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperties
{
    public class CustomersObj
    {
        private int customerIDObj;

        public int CustomerIDObj
        {
            get { return customerIDObj; }
            set { customerIDObj = value; }
        }

        private string contactNameObj;

        public string ContactNameObj
        {
            get { return contactNameObj; }
            set { contactNameObj = value; }
        }
        private string addressObj;

        public string AddressObj
        {
            get { return addressObj; }
            set { addressObj = value; }
        }

        private string phoneObj;

        public string PhoneObj
        {
            get { return phoneObj; }
            set { phoneObj = value; }
        }
        private int userIDObj;

        public int UserIDObj
        {
            get { return userIDObj; }
            set { userIDObj = value; }
        }
    }
}
