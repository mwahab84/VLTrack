using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CutomerName { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string  MartialStatus { get; set; }
        public int NumberOfDependants { get; set; }
        public int NationalityId { get; set; } //CountryId
        public IList<Service> Services { get; set; }
        public IList<Order> Orders { get; set; }
        public IList<MediaFile> MediaFiles { get; set; }
        public IList<Transaction> Stages { get; set; }
    }
}