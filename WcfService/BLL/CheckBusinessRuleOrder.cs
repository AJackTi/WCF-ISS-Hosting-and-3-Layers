using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MyProperties;

namespace BLL
{
    public class CheckBusinessRuleOrder
    {
        private CRUDOrder crudOrders;
        public CheckBusinessRuleOrder()
        {
            crudOrders = new CRUDOrder();
        }
        public int AddOrder(OrdersObj o)
        {
            return crudOrders.AddOrder(o);
        }
        public void AddOrderDetail(OrderDetailsObj o)
        {
           crudOrders.AddOrderDetail(o);
            
        }
    }
}
