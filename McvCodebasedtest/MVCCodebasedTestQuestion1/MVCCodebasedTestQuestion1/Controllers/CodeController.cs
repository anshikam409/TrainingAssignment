using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCodebasedTestQuestion1.Models;

namespace MVCCodebasedTestQuestion1.Controllers
{
    public class CodeController : Controller
    {
        public ActionResult GermanyCustomers()
        {
            using (var db = new NorthWind1Entities())
            {
                var germanCustomers = db.Customers.Where(c => c.City == "Germany").ToList();
                return View(germanCustomers);
            }
        }
        public ActionResult CustomerDetails(int orderId)
        {
            using (var db = new NorthWind1Entities()) 
            {
                var customerDetails = (from c in db.Customers
                                       join o in db.Orders on c.CustomerID equals o.CustomerID
                                       where o.OrderID == 10248
                                       select new CustomerOrderDetailsModel
                                       {
                                           Customer = c,
                                           Order = o
                                       }).SingleOrDefault();
                return View(customerDetails);
            }
        }
    }
}