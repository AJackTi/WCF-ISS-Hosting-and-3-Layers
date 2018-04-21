﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MyProperties;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private DataClassesDataContext dbClassesDataContext;
        public Service1()
        {
            dbClassesDataContext = new DataClassesDataContext();
        }
        public List<ProductObj> GetAllProducts()
        {
            var data = dbClassesDataContext.Products.ToList().ConvertAll<ProductObj>(null);
            return data;
        }
    }
}
