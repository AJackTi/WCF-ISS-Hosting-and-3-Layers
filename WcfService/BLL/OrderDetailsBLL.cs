using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class OrderDetailsBLL
    {
        private DataClassesDataContext db;

        public OrderDetailsBLL()
        {
            db = new DataClassesDataContext();
        }

        public List<Order_Detail> GetAllOrderDetails()
        {
            return db.Order_Details.ToList();
        }

        public void Add1OrderDetail(Order_Detail orderDetail)
        {
            db.Order_Details.InsertOnSubmit(orderDetail);
            db.SubmitChanges();
        }

        public void DelOrderDetail(Order_Detail orderDetail)
        {
            var data = db.Order_Details.Where(w => w.OrderID == orderDetail.OrderID).FirstOrDefault();
            data.OrderID = orderDetail.OrderID;
            data.ProductID = orderDetail.ProductID;
            data.UnitPrice = orderDetail.UnitPrice;
            data.Quantity = orderDetail.Quantity;
            db.Order_Details.DeleteOnSubmit(data);
            db.SubmitChanges();
        }

        public void Update1OrderDetail(Order_Detail orderDetail)
        {
            var data = db.Order_Details.Where(w => w.OrderID == orderDetail.OrderID).FirstOrDefault();
            data.OrderID = orderDetail.OrderID;
            data.ProductID = orderDetail.ProductID;
            data.UnitPrice = orderDetail.UnitPrice;
            data.Quantity = orderDetail.Quantity;
            db.SubmitChanges();
        }
    }
}
