using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperties
{
    public class LoginObj
    {
        private int userIDObj;

        public int UserIDObj
        {
            get { return userIDObj; }
            set { userIDObj = value; }
        }

        private string userNameObj;

        public string UserNameObj
        {
            get { return userNameObj; }
            set { userNameObj = value; }
        }

        private string passwordObj;

        public string PasswordObj
        {
            get { return passwordObj; }
            set { passwordObj = value; }
        }
    }
}
