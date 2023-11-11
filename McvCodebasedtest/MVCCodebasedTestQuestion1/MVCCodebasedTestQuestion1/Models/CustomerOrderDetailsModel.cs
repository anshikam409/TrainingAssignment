using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodebasedTestQuestion1.Models
{
    public class CustomerOrderDetailsModel
    {
        public Customer Customer { get; set; }
        public Order Order { get; set; }
    }
}