using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column("MainCustomer")]
        public int MainCustomerId { get; set; }
        public string OrderDesc { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderTime { get; set; }
        public bool PaymentCompleted { get; set; }
        public double TotalAmount { get; set; }
        public bool Discounted { get; set; }
        public double TotalAmountAfterDiscount { get; set; }
        public string Notes { get; set; }
        [ForeignKey("MainCustomerId")]
        public Customer MainCustomer { get; set; }
        public IList<OrderItem> OrderItems { get; set; }
        public IList<OrderPaymentHistory> OrderPaymentHistory { get; set; }
    }
}