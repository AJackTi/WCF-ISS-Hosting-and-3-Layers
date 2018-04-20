using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ProductsBLL
    {
        private DataClassesDataContext dbClassesDataContext;

        public ProductsBLL()
        {
            dbClassesDataContext = new DataClassesDataContext();
        }

        public List<Product> GetALlProduct()
        {
            return dbClassesDataContext.Products.ToList();
        }

        public void Add1PR(Product product)
        {
            dbClassesDataContext.Products.InsertOnSubmit(product);
            dbClassesDataContext.SubmitChanges();
        }

        public void Del1PR(Product product)
        {
            Product delProduct =
                dbClassesDataContext.Products.Where(w => w.ProductID == product.ProductID).FirstOrDefault();
            dbClassesDataContext.Products.DeleteOnSubmit(delProduct);
            dbClassesDataContext.SubmitChanges();
        }

        public void UpdateProduct(Product product)
        {
            Product pro = dbClassesDataContext.Products.Where(w => w.ProductID == product.ProductID).FirstOrDefault();
            pro.ProductID = product.ProductID;

            dbClassesDataContext.SubmitChanges();
        }
    }
}
