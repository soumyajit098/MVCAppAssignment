using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAppProductAssignment.Models
{
    public class Product
    {
        public int Product_Id { get; set; }
        public String Product_Name { get; set; }

        public double Rate { get; set; }
    }
}