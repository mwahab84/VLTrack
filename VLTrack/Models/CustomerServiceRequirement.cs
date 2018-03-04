using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// CustomerServiceRequirement class asscoiates the customer to
    /// the service phase which is already associating the service with its phases;
    /// in addition to associate the phase service requirements
    /// </summary>
    public class CustomerServiceRequirement
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ServiceRequirementId { get; set; }
        public int ServicePhaseId { get; set; }
        public int MediaFileId { get; set; }
        public bool Completed { get; set; }
        public string Notes { get; set; }
        public Customer Customer { get; set; }
        public ServiceRequirement ServiceRequirement { get; set; }
        public ServicePhase ServicePhase { get; set; }
        public MediaFile MediaFile { get; set; }

    }
}