using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperties
{
    public class ProductsObj
    {
        private int productIDObj;

        public int ProductIDObj
        {
            get { return productIDObj; }
            set { productIDObj = value; }
        }
        private string productNameObj;

        public string ProductNameObj
        {
            get { return productNameObj; }
            set { productNameObj = value; }
        }
        private decimal unitPriceObj;

        public decimal UnitPriceObj
        {
            get { return unitPriceObj; }
            set { unitPriceObj = value; }
        }
        private int unitInStockObj;

        public int UnitInStockObj
        {
            get { return unitInStockObj; }
            set { unitInStockObj = value; }
        }

        
        private string productTypeObj;

        public string ProductTypeObj
        {
            get { return productTypeObj; }
            set { productTypeObj = value; }
        }
    }
}
