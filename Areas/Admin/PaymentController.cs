using Irandoc.EPayment.Web.Areas.Admin.Models;
using Irandoc.EPayment.Web.CustomAttributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCPRoject.Utilities.Models;
using System.Security.Cryptography;

namespace MVCProject.Areas.Admin
{
    [Area("Admin")]
    [Authorize]
    public class PaymentController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<MessageCode>> Check()
        {
            int status = CustomRandomNumberGenerator.GenerateRandomNumber(); // Generate random number to determine payment status

            string description = status == 1 ? "Payment Settled!" : "Payment Unsettled!"; // Set the description based on the status

            MessageCode message = new MessageCode()
            {
                Time = DateTime.Now,
                State = status,
                Description = description
            };

            return Ok(message);
        }
    }
}


