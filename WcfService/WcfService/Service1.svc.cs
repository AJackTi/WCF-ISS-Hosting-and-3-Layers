using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using DAL;
using BLL;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        ProductsBLL productsBll = new ProductsBLL();
        OrderBLL orderBll = new OrderBLL();
        OrderDetailsBLL orderDetailsBll = new OrderDetailsBLL();
        public IEnumerable<Product> GetALlProduct()
        {
            return productsBll.GetALlProduct();
        }

        public void Add1PR(Product product)
        {
            productsBll.Add1PR(product);
        }

        public void Del1PR(Product product)
        {
            productsBll.Del1PR(product);
        }

        public void UpdateProduct(Product product)
        {
            productsBll.UpdateProduct(product);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return orderBll.GetAllOrders();
        }

        public void Add1Order(Order order)
        {
            orderBll.Add1Order(order);
        }

        public void Del1Order(Order order)
        {
            orderBll.Del1Order(order);
        }

        public void UpdateOrder(Order order)
        {
            orderBll.UpdateOrder(order);
        }

        public IEnumerable<Order_Detail> GetAllOrderDetails()
        {
            return orderDetailsBll.GetAllOrderDetails();
        }

        public void Add1OrderDetail(Order_Detail orderDetail)
        {
            orderDetailsBll.Add1OrderDetail(orderDetail);
        }

        public void DelOrderDetail(Order_Detail orderDetail)
        {
            orderDetailsBll.DelOrderDetail(orderDetail);
        }

        public void Update1OrderDetail(Order_Detail orderDetail)
        {
            orderDetailsBll.Update1OrderDetail(orderDetail);
        }
    }
}
