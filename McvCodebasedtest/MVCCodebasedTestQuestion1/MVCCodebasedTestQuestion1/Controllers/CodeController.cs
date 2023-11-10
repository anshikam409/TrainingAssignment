using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodebasedTestQuestion1.Controllers
{
    public class CodeController : Controller
    {
        
        private NorthwindEntities dbContext = new NorthwindEntities();

     
        public ActionResult CustomersInGermany()
        {
            var customers = dbContext.Customers.Where(c => c.Country == "Germany").ToList();
            return View(customers);
        }

      
        public ActionResult CustomerDetailsByOrderId()
        {
            var customerDetails = dbContext.Customers
                .Join(dbContext.Orders,
                    customer => customer.CustomerID,
                    order => order.CustomerID,
                    (customer, order) => new { Customer = customer, Order = order })
                .Where(result => result.Order.OrderID == 10248)
                .ToList();

            return View(customerDetails);
        }
    }

}