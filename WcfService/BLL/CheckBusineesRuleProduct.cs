using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MyProperties;

namespace BLL
{
    public class CheckBusineesRuleProduct
    {
        private CRUDProducts crudProducts;
        public CheckBusineesRuleProduct()
        {
            crudProducts = new CRUDProducts();
        }

        public List<ProductObj> ViewProductObjs()
        {
            return crudProducts.GetProductObjs();
        }
    }
}
