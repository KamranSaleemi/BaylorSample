using BaylorSample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaylorSample.Data.Queries
{
    public class FindCustomerQuery 
    {


        public FindCustomerQuery(Criteria criteria)
        {
            this.SearchCriteria = criteria;
        }

        public Criteria SearchCriteria { get; set; }

        public IEnumerable<Customer> Execute(NorthwindDBContext dbContext)
        {
            var baseQuery = dbContext.Customers.AsQueryable();

            if (String.IsNullOrWhiteSpace(SearchCriteria.CustomerID) == false)
                baseQuery = baseQuery.Where(x => x.CustomerID == SearchCriteria.CustomerID);

            if (String.IsNullOrWhiteSpace(SearchCriteria.CustomerName) == false)
                baseQuery = baseQuery.Where(x => x.CompanyName.Contains(SearchCriteria.CustomerName.Trim()));

            return baseQuery;
        }

        public class Criteria
        {
            public string CustomerID { get; set; }

            public string CustomerName { get; set; }
        }
    }
}