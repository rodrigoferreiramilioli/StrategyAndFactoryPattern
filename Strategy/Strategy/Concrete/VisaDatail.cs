using Strategy.Domain;
using Strategy.Strategy.Context;
using System.Threading.Tasks;

namespace Strategy.Strategy.Concrete
{
    public class VisaDatail : IPayment
    {
        public async Task PaymentData(Order order)
        {
            order.QuantityInstallment = 3000;
        }
    }
}
