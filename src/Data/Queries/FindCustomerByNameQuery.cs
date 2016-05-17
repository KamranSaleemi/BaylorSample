using BaylorSample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaylorSample.Data.Queries
{
    public class FindCustomerByNameQuery : IQuery<IEnumerable<Customer>>
    {
        NorthwindDBContext _dbContext = null;

        public FindCustomerByNameQuery(NorthwindDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string Criteria { get; set; }

        public IEnumerable<Customer> Execute()
        {
            return _dbContext.Customers.Where(x => x.CompanyName.Contains(Criteria)).ToList();
        }
    }
}