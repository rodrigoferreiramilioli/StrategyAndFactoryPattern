using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Strategy.Domain;
using Strategy.Strategy.Concrete;
using Strategy.Strategy.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private IPayment _payment;
        private IPaymentFactory _factory;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IPayment payment, IPaymentFactory paymentFactory)
        {
            _logger = logger;
            _payment = payment;
            _factory = paymentFactory;
        }

        [HttpGet]
        public async Task Get()
        {
            var rng = new Random();
            var order = new Order();
            order.BannerId = BannerType.MASTERCARD;            

            _payment = _factory.Create(order);
            await _payment.PaymentData(order);
            
        }
    }
}
