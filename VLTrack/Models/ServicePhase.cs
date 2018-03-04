using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// ServicePhase class associates the service with its phases
    /// </summary>
    public class ServicePhase
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int PhaseId { get; set; }
        public string ServicePhaseDesc { get; set; }
        public string Notes { get; set; }
        public Service Service { get; set; }
        public Phase Phase { get; set; }
    }
}