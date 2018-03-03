using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    public class Service
    {
        /// <summary>
        /// This class to maniuplate the services provided by
        /// the company, such as Tourism visa, Work visa, or others
        /// </summary>
        public int ServiceId { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDesc { get; set; }
        public string Notes { get; set; }
    }
}