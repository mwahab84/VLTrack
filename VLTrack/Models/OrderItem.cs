using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLTrack.Models
{
    /// <summary>
    /// OrderItem class maniuplates the Order details including the specified service requested
    /// and the initial city where this service will be done at in addition to the final city
    /// where the service will be marked as delivered successfully!
    /// </summary>
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ServiceLevelDetailId { get; set; }
        public string OrderItemDesc { get; set; }
        public int InitialTargetCityId { get; set; }
        public int FinalTargetCityId { get; set; }
        public string Notes { get; set; }

    }
}