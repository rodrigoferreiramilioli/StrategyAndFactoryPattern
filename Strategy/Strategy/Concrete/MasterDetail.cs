using Strategy.Domain;
using Strategy.Strategy.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy.Concrete
{
    public class MasterDatail : IPayment
    {
        public async Task PaymentData(Order order)
        {
            order.QuantityInstallment = 2000;
        }
    }
}
