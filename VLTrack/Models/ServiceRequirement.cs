using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// ServiceRequirement class associates the requirements to the services provided.
    /// Also it specifies whether the requirement is mandatory or optional in addition to
    /// stating who will get this requirement done: Customer or the Company.
    /// </summary>
    public class ServiceRequirement
    {
        public int Id { get; set; }
        public int RequirementId { get; set; }
        public int ServiceId { get; set; }
        public bool Optional { get; set; }
        //DoneBy means: will this be done by the customer or the company?
        public string DoneBy { get; set; }
        public string Notes { get; set; }

    }
}