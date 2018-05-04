using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService
{
    [DataContract]
    public class Product_Temp
    {
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public decimal UnitPrice { get; set; }
        [DataMember]
        public int UnitInStock { get; set; }
        [DataMember]
        public string ProductType { get; set; }
    }
}