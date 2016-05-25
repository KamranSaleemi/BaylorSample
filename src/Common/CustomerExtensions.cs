using BaylorSample.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaylorSample.Shared.Entities;

namespace BaylorSample.Web.Common
{
    public static class CustomerExtensions
    {
        public static IEnumerable<ListCustomerModel> ToListCustomerModel(this IEnumerable<Customer> customers)
        {
            return customers.Select(x => ListCustomerModel.From(x));
        }
    }
}