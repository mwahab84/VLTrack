using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// Order class maniuplates the orders' payments whenever it
    /// may be paid over installments
    /// </summary>
    public class OrderPaymentHistory
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PaymentMethodId { get; set; }
        public double AmountPaid { get; set; }
        public Order _Order { get; set; }
    }
}