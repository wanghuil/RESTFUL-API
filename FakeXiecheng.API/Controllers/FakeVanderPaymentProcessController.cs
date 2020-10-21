using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FakeVanderPaymentProcessController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> ProcessPayment(
            [FromQuery] Guid orderNumber,
            [FromQuery] bool returnFault = false
        )
        {
            // pretend to handle
            await Task.Delay(3000);

            // if returnFault is true, Return payment failed
            if (returnFault)
            {
                return Ok(new
                {
                    id = Guid.NewGuid(),
                    created = DateTime.UtcNow,
                    approved = false,
                    message = "Reject",
                    payment_metohd = "Pay by credit card",
                    order_number = orderNumber,
                    card = new { 
                        card_type = "Credit Card",
                        last_four = "1234"
                    }
                }) ;
            }

            return Ok(new
            {
                id = Guid.NewGuid(),
                created = DateTime.UtcNow,
                approved = true,
                message = "Reject",
                payment_metohd = "Pay by credit card",
                order_number = orderNumber,
                card = new
                {
                    card_type = "Credit Card",
                    last_four = "1234"
                }
            });
        }
    }
}
