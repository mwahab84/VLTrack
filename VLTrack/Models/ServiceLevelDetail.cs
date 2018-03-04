using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    public class ServiceLevelDetail
    {
        /// <summary>
        /// The ServiceLevelDetails class associates the Service with
        /// the level of service provided beside maniuplates extra details
        /// such as the Duration to get the service done, the Minimum age
        /// to receive this service {this will require a different pricing for different ages}
        /// in addition to set the UnitPrice for the service at the specified level.
        /// </summary>
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int ServiceLevelId { get; set; }
        public short Duration { get; set; }
        public byte MinAge { get; set; }
        public double UnitPrice { get; set; }
        public string Notes { get; set; }
        public Service Service { get; set; }
        public ServiceLevel ServiceLevel { get; set; }
    }
}