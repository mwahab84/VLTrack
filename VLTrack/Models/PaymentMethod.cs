using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// PaymentMethod class manipulates all the payment methods of any order
    /// </summary>
    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; }
        public string PymentMethodTitle { get; set; }
        public string PymentMethodDesc { get; set; }
        public bool IsCard { get; set; }
        public string CardType{get;set;}
    }
}