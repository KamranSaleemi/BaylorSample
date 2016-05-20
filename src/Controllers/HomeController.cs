using BaylorSample.Data;
using BaylorSample.Infrastructure;
using BaylorSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BaylorSample.Entities;
using BaylorSample.Data.Queries;

namespace BaylorSample.Controllers
{
    public class HomeController : Controller
    {
        readonly NorthwindDBContext _dbContext = null;
        readonly ILogger _logger = null;

        public HomeController(ILogger logger)
        {
            _dbContext = new NorthwindDBContext();
            _logger = logger;
        }

        // GET: Home
        public ActionResult Index()
        {
            var query = new FindCustomerQuery(new FindCustomerQuery.Criteria {
                CustomerName = "Ana"
            });

            var customers = query.Execute(_dbContext);
            customers.ToList();

            IEnumerable<ListCustomerModel> model = _dbContext.Customers.ToArray().Select(x => ListCustomerModel.From(x));
            return View(model);
        }

        public ActionResult Edit(string customerID)
        {
            var customer = _dbContext.Customers.Find(customerID);
            if (customer == null)
                return HttpNotFound();

            var model = EditCustomerModel.From(customer);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(EditCustomerModel model)
        {

            if (ModelState.IsValid == false)
            {
                return View();  
            }
                

            var customer = _dbContext.Customers.Find(model.CustomerID);
            customer.CompanyName = model.CompanyName;
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}