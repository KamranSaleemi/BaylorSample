using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaylorSample.Data.Queries
{
    public interface IQuery<T>
    {
        T Execute();
    }
}