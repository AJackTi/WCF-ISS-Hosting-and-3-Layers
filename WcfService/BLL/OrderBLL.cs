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

        public IEnumerable<Order> GetAllOrders()
        {
            return db.Orders;
        }

        public void Add1Order(Order or)
        {
            db.Orders.InsertOnSubmit(or);
            db.SubmitChanges();
        }

        public void Del1Order(Order or)
        {
            db.Orders.DeleteOnSubmit(or);
            db.SubmitChanges();
        }

        public void UpdateOrder(Order or)
        {
            var data = db.Orders.Where(w => w.OrderID == or.OrderID).FirstOrDefault();
            data.OrderID = or.OrderID;
            data.OrderDate = or.OrderDate;
            data.EmployeeID = or.EmployeeID;
            data.CustomerID = or.CustomerID;
            db.SubmitChanges();
        }
    }
}
