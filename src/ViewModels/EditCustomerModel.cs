﻿using BaylorSample.Shared.Entities;
using System.ComponentModel.DataAnnotations;

namespace BaylorSample.Web.ViewModels
{
    public class EditCustomerModel
    {
        public string CustomerID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Company Name is Required")]
        [MinLength(3)]
        public string CompanyName { get; set; }

        public static EditCustomerModel From(Customer customer)
        {
            return new EditCustomerModel { CustomerID = customer.CustomerID, CompanyName = customer.CompanyName };
        }
    }
}