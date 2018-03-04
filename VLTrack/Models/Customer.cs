using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// Customer class list the customers and associate them
    /// with the related objects
    /// </summary>
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CutomerName { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string  MartialStatus { get; set; }
        public int NationalityId { get; set; } //Mapped to CountryId
        public bool InternalCustomer { get; set; }
        //CustomerType when it's internal customer, means it's
        //system administrator, editor, noter, ...etc
        public string CustomerType { get; set; }
        public int NumberOfDependants { get; set; }

        public bool IsDependant { get; set; }
        //In case the customer is dependant customer
        //Set the relation to the parent customer such as: son, daughter, wife, ...etc
        public string RelationToParentCustomer { get; set; }
        // Create a self-reference column that holds the dependants of a customer
        [Column("ParentCustomer")]
        public int? ParentCustomerId { get; set; }
        [ForeignKey("ParentCustomerId")]
        public Customer ParentCustomer { get; set; }
        public IList<Customer> Dependants { get; set; }

        //public IList<Service> Services { get; set; }
        public IList<Order> Orders { get; set; }
        public IList<MediaFile> MediaFiles { get; set; }
//        public IList<Transaction> Stages { get; set; }
        public IList<Address> Addresses { get; set; }
        public IList<PhoneNumber> PhoneNumbers { get; set; }
    }
}