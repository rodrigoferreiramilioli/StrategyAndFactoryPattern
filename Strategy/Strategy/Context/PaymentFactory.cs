using Strategy.Domain;
using Strategy.Strategy.Concrete;
using System;

namespace Strategy.Strategy.Context
{
    public class PaymentFactory : IPaymentFactory
    {
        public IPayment Create(Order order)
        {
            switch (order.BannerId)
            {
                case BannerType.MASTERCARD:
                    return new MasterDatail();
                case BannerType.VISA:
                    return new VisaDatail();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
