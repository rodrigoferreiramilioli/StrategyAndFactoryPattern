using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy.Domain
{
    public class Order
    {
        public string OrderAuthorizationId { get; set; }
        public BannerType BannerId { get; set; }
        public int QuantityInstallment { get; set; }
        public decimal ValuePayment { get; set; }
    }
}
