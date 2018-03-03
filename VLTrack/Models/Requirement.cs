using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// Requirement class manipulates all the requirements of any service
    /// </summary>
    public class Requirement
    {
        public int Id { get; set; }
        public string RequirementTitle { get; set; }
        public string RequirementDesc { get; set; }
        //The requirement type means: is the original evidence required, a copy, or both?
        public string RequirementType { get; set; }
        //The rquirement supplier means: is it the embassy, noter, or any others will supply?
        public string RequirementSupplier { get; set; }
        public string Notes { get; set; }

    }
}