using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreCafe.Services.Orders.Models
{
    public class CheckoutViewModel
    {
        [Required]
        [Display(Name = "Address")]
        public string DeliveryAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public string DeliveryCity { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        public string DeliveryPostalCode { get; set; }
    }

}
