using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Objects_Temp
{
    [DataContract]
    public class Order_Detail_Temp
    {
        [DataMember]
        public int OrderID { get; set; }
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public decimal UnitPrice { get; set; }
        [DataMember]
        public int Quantity { get; set; }
    }
}