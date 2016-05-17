using BaylorSample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaylorSample.ViewModels
{
    public class ListCustomerModel
    {
        public string CustomerID { get; set; }

        public string CompanyName { get; set; }

        public static ListCustomerModel From(Customer customer)
        {
            return new ListCustomerModel { CustomerID = customer.CustomerID, CompanyName = customer.CompanyName };
        }

    }
}