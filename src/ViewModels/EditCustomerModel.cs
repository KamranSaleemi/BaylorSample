using BaylorSample.Entities;
using System.ComponentModel.DataAnnotations;

namespace BaylorSample.ViewModels
{
    public class EditCustomerModel
    {
        public string CustomerID { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage = "Company Name is Required")]
        public string CompanyName { get; set; }

        public static EditCustomerModel From(Customer customer)
        {
            return new EditCustomerModel { CustomerID = customer.CustomerID, CompanyName = customer.CompanyName };
        }
    }
}