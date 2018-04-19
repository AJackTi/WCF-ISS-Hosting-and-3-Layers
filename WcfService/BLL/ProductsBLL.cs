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

        public IEnumerable<Product> GetALlProduct()
        {
            IEnumerable<Product> data = dbClassesDataContext.Products;
            return data;
        }

        public void Add1PR(Product pr)
        {
            dbClassesDataContext.Products.InsertOnSubmit(pr);
            dbClassesDataContext.SubmitChanges();
        }

        public void Del1PR(Product pr)
        {
            Product delProduct =
                dbClassesDataContext.Products.Where(w => w.ProductID == pr.ProductID).FirstOrDefault();
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
