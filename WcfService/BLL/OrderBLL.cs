using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class OrderBLL
    {
        private DataClassesDataContext db;

        public OrderBLL()
        {
            db = new DataClassesDataContext();
        }

        public List<Order> GetAllOrders()
        {
            return db.Orders.ToList();
        }

        public void Add1Order(Order order)
        {
            db.Orders.InsertOnSubmit(order);
            db.SubmitChanges();
        }

        public void Del1Order(Order order)
        {
            db.Orders.DeleteOnSubmit(order);
            db.SubmitChanges();
        }

        public void UpdateOrder(Order order)
        {
            var data = db.Orders.Where(w => w.OrderID == order.OrderID).FirstOrDefault();
            data.OrderID = order.OrderID;
            data.OrderDate = order.OrderDate;
            data.EmployeeID = order.EmployeeID;
            data.CustomerID = order.CustomerID;
            db.SubmitChanges();
        }
    }
}
