using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// Order class maniuplates the orders requested by a customer
    /// </summary>
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string OrderDesc { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderTime { get; set; }
        public double PaidAmount { get; set; }
        public double TotalAmount { get; set; }
        public bool Discounted { get; set; }
        public double TotalAmountAfterDiscount { get; set; }
        public int PaymentMethodId { get; set; }
        public string Notes { get; set; }
    }
}