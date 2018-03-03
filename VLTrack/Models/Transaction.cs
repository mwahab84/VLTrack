using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// Transaction class maniuplates the orders' transactions
    /// such as Order Placed, Under Review, Initiated, ...etc
    /// </summary>
    public class Transaction
    {
        public int Id { get; set; }
        public string TransactionTitle { get; set; }
        public string TransactionDesc { get; set; }
        public string Notes { get; set; }
    }
}