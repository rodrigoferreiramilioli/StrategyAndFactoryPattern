using Strategy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy.Strategy.Context
{
    public interface IPaymentFactory
    {
        IPayment Create(Order order);
    }
}
