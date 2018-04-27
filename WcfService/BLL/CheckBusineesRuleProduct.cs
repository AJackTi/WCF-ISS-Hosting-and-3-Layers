using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CheckBusineesRuleProduct
    {
        private CRUDProducts crudProducts;
        public CheckBusineesRuleProduct()
        {
            crudProducts = new CRUDProducts();
        }
        public List<DAL.ServiceReference.Product> GetAllProduct()
        {
            return crudProducts.GetAllProduct();
        }
    }
}
