using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodebasedTestQuestion1.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }

    }
}