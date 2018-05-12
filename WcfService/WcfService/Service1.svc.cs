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

        public void AddProduct(ProductsObj productObj)
        {
            Product product = new Product();
            product.ProductID = productObj.ProductIDObj;
            product.ProductName = productObj.ProductNameObj;
            product.UnitPrice = productObj.UnitPriceObj;
            product.UnitInStock = productObj.UnitInStockObj;
            product.ProductType = productObj.ProductTypeObj;
            data.Products.InsertOnSubmit(product);
            data.SubmitChanges();
        }

        public void DeleteProduct(int id)
        {
            var item = data.Products.Where(t => t.ProductID == id).FirstOrDefault();
            data.Products.DeleteOnSubmit(item);
            data.SubmitChanges();
        }

        public void UpdateProduct(ProductsObj productObj)
        {
            var item = data.Products.Where(t => t.ProductID == productObj.ProductIDObj).FirstOrDefault();
            item.ProductID = productObj.ProductIDObj;
            item.ProductName = productObj.ProductNameObj;
            item.UnitPrice = productObj.UnitPriceObj;
            item.UnitInStock = productObj.UnitInStockObj;
            item.ProductType = productObj.ProductTypeObj;
            data.SubmitChanges();
        }

        public List<Order> GetAllOrder()
        {
            return data.Orders.ToList();
        }

        public int AddOrder(OrdersObj order)
        {
            Order o = new Order();
            o.CustomerID = order.CustomerIDObj;
            o.OrderDate = DateTime.Now;
            o.EmployeeID = 1;
            data.Orders.InsertOnSubmit(o);
            data.SubmitChanges();
            return o.OrderID;
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

        public void AddOrderDetail(OrderDetailsObj orderdetail)
        {
            OrderDetail o = new OrderDetail();
            o.OrderID = orderdetail.OrderIDObj;
            o.ProductID = orderdetail.ProductIDObj;
            o.Quantity = orderdetail.QuantityObj;
            o.UnitPrice = orderdetail.UnitPriceObj;
            data.OrderDetails.InsertOnSubmit(o);
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

        public int CheckLogin(string username, string password)
        {
            var login = from l in data.Logins where l.UserName == username select l;
            if (login.FirstOrDefault().Password == password)
            {
                var cus = (from i in login
                           join c in data.Customers on i.UserID equals c.UserID
                           select c).FirstOrDefault();
                if (cus != null) return cus.CustomerID;
                else return 0;
            } 
            return -1;
        }
    }
}