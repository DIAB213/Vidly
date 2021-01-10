using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;


namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer() {Name = "John Smith", Id = 1},
            new Customer() {Name = "Mary Williams", Id = 2}
        };
        // GET: Customer
        public ActionResult Index()
        {

            return View(customers);

        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id) {
            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {   
                    return View(customer);
                }
                
            }
            return HttpNotFound();
        }
    }
}