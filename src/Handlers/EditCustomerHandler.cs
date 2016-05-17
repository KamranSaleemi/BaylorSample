using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediatR;

namespace BaylorSample.Handlers
{
    public class EditCustomerHandler : IRequestHandler<EditCustomerModel, Unit>
    {
        public Unit Handle(EditCustomerModel message)
        {
            return Unit.Value;
        }
    }
}