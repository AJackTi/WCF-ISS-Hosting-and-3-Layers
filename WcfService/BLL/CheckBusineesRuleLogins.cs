using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MyProperties;

namespace BLL
{
    public class CheckBusineesRuleLogins
    {
        private CRUDLogins crudLogins;
        public CheckBusineesRuleLogins()
        {
            crudLogins = new CRUDLogins();
        }
        public bool CheckLogin(string username, string password)
        {
            return crudLogins.CheckLogin(username, password);
        }
    }
}
