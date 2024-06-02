using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreCafe.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryPostalCode { get; set; }
        public OrderStatus Status { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public decimal TotalAmount { get; set; }

        public void CalculateTotalAmount()
        {
            TotalAmount = OrderDetails.Sum(od => od.Quantity * od.UnitPrice);
        }
    }
}
