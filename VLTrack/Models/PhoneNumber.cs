using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// PhoneNumber class list the customers' phone numbers
    /// </summary>
    public class PhoneNumber
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string PhoneNumberTitle { get; set; }
        public string PhoneNumberDesc { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public Customer _Customer { get; set; }
    }
}