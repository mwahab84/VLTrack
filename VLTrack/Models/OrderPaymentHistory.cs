using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// Order class maniuplates the orders' payments whenever it
    /// may be paid over installments
    /// </summary>

    [Table("OrderPaymentHistory")]
    public class OrderPaymentHistory
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PaymentMethodId { get; set; }
        public double AmountPaid { get; set; }
        public Order Order { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}