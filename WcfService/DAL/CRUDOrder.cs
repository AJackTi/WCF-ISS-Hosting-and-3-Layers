using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProperties;

namespace DAL
{
    public class CRUDOrder
    {
        ServiceReference.Service1Client obj;
        public CRUDOrder()
        {
            obj = new ServiceReference.Service1Client();
        }
        
        public int AddOrder(OrdersObj o)
        {
            return obj.AddOrder(o);
        }

        public void AddOrderDetail(OrderDetailsObj o)
        {
                obj.AddOrderDetail(o);
            
        }
    }
}
