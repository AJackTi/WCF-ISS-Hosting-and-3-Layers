using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.ServiceReference;
using MyProperties;

namespace DAL
{
    public class CRUDProducts
    {
        private ServiceReference.Service1Client obj;
        public CRUDProducts()
        {
            obj = new Service1Client();
        }
        // Get Data
        public List<ProductObj> GetProductObjs()
        {
            return obj.GetAllProducts();
        }
        // Add
        public void Add1Pr(ProductObj productObj)
        {

        }
    }
}
