using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
[ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service1 : IService1
    {
        private DAL.DataClassesDataContext dbClassesDataContext = new DataClassesDataContext();
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

        public List<Order> GetAllOrders()
        {
            return dbClassesDataContext.Orders.ToList();
        }

        public void Add1Order(Order order)
        {
            dbClassesDataContext.Orders.InsertOnSubmit(order);
            dbClassesDataContext.SubmitChanges();
        }

        public void Del1Order(Order order)
        {
            dbClassesDataContext.Orders.DeleteOnSubmit(order);
            dbClassesDataContext.SubmitChanges();
        }

        public void UpdateOrder(Order order)
        {
            var data = dbClassesDataContext.Orders.Where(w => w.OrderID == order.OrderID).FirstOrDefault();
            data.OrderID = order.OrderID;
            data.OrderDate = order.OrderDate;
            data.EmployeeID = order.EmployeeID;
            data.CustomerID = order.CustomerID;
            dbClassesDataContext.SubmitChanges();
        }

        public List<Order_Detail> GetAllOrderDetails()
        {
            return dbClassesDataContext.Order_Details.ToList();
        }

        public void Add1OrderDetail(Order_Detail orderDetail)
        {
            dbClassesDataContext.Order_Details.InsertOnSubmit(orderDetail);
            dbClassesDataContext.SubmitChanges();
        }

        public void DelOrderDetail(Order_Detail orderDetail)
        {
            dbClassesDataContext.Order_Details.DeleteOnSubmit(orderDetail);
            dbClassesDataContext.SubmitChanges();
        }

        public void Update1OrderDetail(Order_Detail orderDetail)
        {
            var data = dbClassesDataContext.Order_Details.Where(w => w.OrderID == orderDetail.OrderID).FirstOrDefault();
            data.OrderID = orderDetail.OrderID;
            data.ProductID = orderDetail.ProductID;
            data.UnitPrice = orderDetail.UnitPrice;
            data.Quantity = orderDetail.Quantity;
            dbClassesDataContext.SubmitChanges();
        }
    }
}
