using MVCCodebasedTestQuestion1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodebasedTestQuestion1.Controllers
{
    public class CodeController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities(); 
        public ActionResult CustomersInGermany()
        {
            var germanyCustomers = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(germanyCustomers);
        }

        public ActionResult CustomerDetailsByOrderId(int orderId = 10248)
        {
            var customer = db.Customers
                .Where(c => c.Orders.Any(o => o.OrderID == orderId))
                .SingleOrDefault();

            if (customer == null)
            {
                return HttpNotFound(); 
            }

            return View(customer);
        }
    }
}
