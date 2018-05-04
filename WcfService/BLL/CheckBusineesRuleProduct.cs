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
        public List<ProductsObj> GetAllProduct()
        {
            return crudProducts.GetAllProduct();
        }

        public List<ProductsObj> GetProductFromType(string producttype)
        {
            return crudProducts.GetProductFromType(producttype);
        }

        public List<ProductsObj> GetProductFromID(int id)
        {
            return crudProducts.GetProductFromID(id);
        }

        public void DeleteProduct(int id)
        {
            crudProducts.DeleteProduct(id);
        }
    }
}
