using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// OrderItemTransactionHistory class manipulates the order item transaction status such as
    /// Order Placed, Under Review, Initiated, Delivered, ....etc. Beside listing the action start and end date
    /// and the current action status; whether it's active, paused, cancelled, or completed.
    /// </summary>
    public class OrderItemTransactionHistory
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public int OrderItemId { get; set; }
        public string TransactionDesc { get; set; }
        public DateTime TransactionStarted { get; set; }
        public DateTime TransactionEnded { get; set; }
        //A Transaction status means is it Active, completed, Paused, or cancelled?
        public string TransactionStatus { get; set; }
        public string Notes { get; set; }

    }
}