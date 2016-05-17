﻿using BaylorSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaylorSample.Entities
{
    public static class CustomerExtensions
    {
        public static IEnumerable<ListCustomerModel> ToListCustomerModel(this IEnumerable<Customer> customers)
        {
            return customers.Select(x => ListCustomerModel.From(x));
        }
    }
}