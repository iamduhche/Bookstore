using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreCafe.Data.Enums;

namespace BookstoreCafe.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public User User { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public string DeliveryAddress { get; set; } = null!;
        public string DeliveryCity { get; set; } = null!;
        public string DeliveryPostalCode { get; set; } = null!;
        public OrderStatus Status { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
        public decimal TotalAmount { get; set; }

        public void CalculateTotalAmount()
        {
            TotalAmount = OrderDetails.Sum(od => od.Quantity * od.UnitPrice);
        }
    }
}
