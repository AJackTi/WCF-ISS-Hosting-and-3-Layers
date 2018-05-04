using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperties
{
    public class OrderDetailsObj
    {
        private int orderIDObj;

        public int OrderIDObj
        {
            get { return orderIDObj; }
            set { orderIDObj = value; }
        }

        private int productIDObj;

        public int ProductIDObj
        {
            get { return productIDObj; }
            set { productIDObj = value; }
        }

        private decimal unitPriceObj;

        public decimal UnitPriceObj
        {
            get { return unitPriceObj; }
            set { unitPriceObj = value; }
        }

        private int quantityObj;

        public int QuantityObj
        {
            get { return quantityObj; }
            set { quantityObj = value; }
        }
    }
}
