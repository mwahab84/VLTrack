using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    public class Country
    {
        public int Id { get; set; }
        public String CountryTitle { get; set; }
        public string CountryDesc { get; set; }
        public string CountryNationality { get; set; }
        public string CountryLanguage { get; set; }
        public string Notes { get; set; }
        public IList<City> Cities { get; set; }
    }
}