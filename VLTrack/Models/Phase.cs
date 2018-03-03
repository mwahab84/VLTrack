using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// Phase class manipulates the phases that are accompained with each service
    /// such as: Complete Profile, Setting Appointment, Interview, Delivery
    /// </summary>
    public class Phase
    {
        public int Id { get; set; }
        public string PhaseTitle { get; set; }
        public string PhaseDesc { get; set; }
        public string Notes { get; set; }
    }
}