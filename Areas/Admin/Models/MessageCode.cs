using System.Net;

namespace Irandoc.EPayment.Web.Areas.Admin.Models
{
    public class MessageCode
    {
        public DateTime Time { get; set; }
        public int State { get; set; }
        public string? Description { get; set; }
    }
}
