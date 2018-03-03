using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    public class ServiceLevel
    {
        /// <summary>
        /// The ServiceLevel class maniuplates the level of service provided
        /// such as Standard, VIP, ...etc
        /// </summary>
        public int Id { get; set; }
        public string SLTitle { get; set; }
        public string SLDesc { get; set; }
        public string Notes { get; set; }
    }
}