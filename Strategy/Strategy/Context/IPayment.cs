using Strategy.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy.Context
{
    public interface IPayment
    {
        public Task PaymentData(Order order);
    }
}
