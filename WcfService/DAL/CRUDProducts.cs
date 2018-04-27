using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService;

namespace DAL
{
    public class CRUDProducts
    {
        ServiceReference.Service1Client obj;
        public CRUDProducts()
        {
            obj = new ServiceReference.Service1Client();
        }
        public List<DAL.ServiceReference.Product> GetAllProduct()
        {
            List<DAL.ServiceReference.Product> data = obj.GetAllProduct().Cast<DAL.ServiceReference.Product>().ToList();
            return data;
        }
    }
}
