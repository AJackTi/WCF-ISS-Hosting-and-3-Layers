using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProperties;

namespace DAL
{
    public class CRUDLogins
    {
        ServiceReference.Service1Client obj;
        public CRUDLogins()
        {
            obj = new ServiceReference.Service1Client();
        }

        public bool CheckLogin(string username, string password)
        {
            return obj.CheckLogin(username, password);
        }
    }
}
