using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string PhoneNumberTitle { get; set; }
        public string PhoneNumberDesc { get; set; }
        public string PersonPhoneNumber { get; set; }
    }
}