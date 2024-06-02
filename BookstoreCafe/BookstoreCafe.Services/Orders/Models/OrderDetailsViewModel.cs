using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreCafe.Services.Orders.Models
{
    public class OrderDetailsViewModel
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryPostalCode { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItemViewModel> OrderDetails { get; set; }
    }
}
