using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Objects_Temp
{
    [DataContract]
    public class Order_Temp
    {
        [DataMember]
        public int OrderID { get; set; }
        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
    }
}