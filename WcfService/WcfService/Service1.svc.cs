using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MyProperties;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        DataClassesDataContext data;
        //ProductsObj productsObj;
        public Service1()
        {
            data = new DataClassesDataContext();
            //productsObj = new ProductsObj();
        }

        public List<Product_Temp> GetProductFromID(int id)
        {
            List<Product_Temp> lstProductTemp = new List<Product_Temp>();
            foreach (var i in data.Products.ToList())
            {
                if (i.ProductID == id)
                    lstProductTemp.Add(ClassConvert.ConvertToProduct_Temp(i as Product));
            }
            return lstProductTemp;
        }

        public List<Product_Temp> GetProductFromType(string producttype)
        {
            List<Product_Temp> lstProductTemp = new List<Product_Temp>();
            foreach (var i in data.Products.ToList())
            {
                if (i.ProductType == producttype)
                    lstProductTemp.Add(ClassConvert.ConvertToProduct_Temp(i as Product));
            }
            return lstProductTemp;
        }

        public List<Product_Temp> GetAllProduct()
        {
            List<Product_Temp> lstProductTemp = new List<Product_Temp>();
            foreach (var i in data.Products.ToList())
            {
                Product_Temp product_temp = ClassConvert.ConvertToProduct_Temp(i as Product);
                lstProductTemp.Add(product_temp);
            }
            return lstProductTemp;
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
            var item = data.Products.Where(t => t.ProductID == product.ProductID).FirstOrDefault();
            item.ProductID = product.ProductID;
            item.ProductName = product.ProductName;
            item.UnitPrice = product.UnitPrice;
            item.UnitInStock = product.UnitInStock;
            data.SubmitChanges();
        }

        public List<Order> GetAllOrder()
        {
            return data.Orders.ToList();
        }

        public void AddOrder(Order order)
        {
            data.Orders.InsertOnSubmit(order);
            data.SubmitChanges();
        }

        public void DeleteOrder(int id)
        {
            var item = data.Orders.Where(t => t.OrderID == id).FirstOrDefault();
            data.Orders.DeleteOnSubmit(item);
            data.SubmitChanges();
        }

        public void UpdateOrder(Order order)
        {
            var item = data.Orders.Where(t => t.OrderID == order.OrderID).FirstOrDefault();
            item.OrderID = order.OrderID;
            item.CustomerID = order.CustomerID;
            item.EmployeeID = order.EmployeeID;
            item.OrderDate = order.OrderDate;
            data.SubmitChanges();
        }

        public List<OrderDetail> GetAllOrderDetail()
        {
            return data.OrderDetails.ToList();
        }

        public void AddOrderDetail(OrderDetail orderdetail)
        {
            data.OrderDetails.InsertOnSubmit(orderdetail);
            data.SubmitChanges();
        }

        public void DeleteOrderDetail(int id)
        {
            var item = data.OrderDetails.Where(t => t.OrderID == id).FirstOrDefault();
            data.OrderDetails.DeleteOnSubmit(item);
            data.SubmitChanges();
        }

        public void UpdateOrderDetail(OrderDetail orderdetail)
        {
            var item = data.OrderDetails.Where(t => t.OrderID == orderdetail.OrderID).FirstOrDefault();
            item.OrderID = orderdetail.OrderID;
            item.ProductID = orderdetail.ProductID;
            item.UnitPrice = orderdetail.UnitPrice;
            item.Quantity = orderdetail.Quantity;
            data.SubmitChanges();
        }
    }
}