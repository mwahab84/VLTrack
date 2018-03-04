using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models

{
    /// <summary>
    /// Address class list the addresses of A customer
    /// </summary>
    public class Address
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int CustomerId { get; set; }
        public string AddressTitle { get; set; }
        public string AddressDesc { get; set; }
        public bool MainAddress { get; set; }
        public bool BillingAddress { get; set; }
        public bool ShippingAddress { get; set; }
        public double AddressLatitude { get; set; }
        public double AddressMagnitude { get; set; }
        public string LinkOnMaps { get; set; }
        public string ZipCode { get; set; }
        public Customer _Customer { get;set; }

    }
}