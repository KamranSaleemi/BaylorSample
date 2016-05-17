using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaylorSample.Data.Queries
{
    public abstract class Query<T>
    {
        public abstract T Execute();
    }
}