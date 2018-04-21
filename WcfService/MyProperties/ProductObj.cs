using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProperties
{
    public class ProductObj
    {
        public int ProductIDObj
        {
            get { return ProductIDObj; }
            set { ProductIDObj = value; }
        }
        public string ProductNameObj
        {
            get { return ProductNameObj; }
            set { ProductNameObj = value; }
        }
        public int SupplierIDObj
        {
            get { return SupplierIDObj; }
            set { SupplierIDObj = value; }
        }
        public double UnitPriceObj
        {
            get { return UnitPriceObj; }
            set { UnitPriceObj = value; }
        }
        public int UnitInStock
        {
            get { return UnitInStock; }
            set { UnitPriceObj = value; }
        }
    }
}
