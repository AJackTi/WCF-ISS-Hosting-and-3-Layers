using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        DataClassesDataContext data = new DataClassesDataContext();

        public List<Product> GetAllProduct()
        {
            return data.Products.ToList();
        }

        public void AddProduct(Product product)
        {
            data.Products.InsertOnSubmit(product);
            data.SubmitChanges();
        }

        public void DeleteProduct(int id)
        {
            var item = data.Products.Where(t => t.ProductID == id).FirstOrDefault();
            data.Products.DeleteOnSubmit(item);
            data.SubmitChanges();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetAllSupplier()
        {
            throw new NotImplementedException();
        }

        public void AddSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public void DeleteSupplier(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrder()
        {
            throw new NotImplementedException();
        }

        public void AddOrder()
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder()
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetAllOrderDetail()
        {
            throw new NotImplementedException();
        }

        public void AddOrderDetail()
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderDetail()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderDetail()
        {
            throw new NotImplementedException();
        }
    }
}
