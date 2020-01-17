using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.HttpAggregator.Models
{
    public class ValuationDetails
    {
        public Guid Id { get; set; }
        public int OrderNumber { get; set; }
        public Guid CreatorId { get; set; }
        public string State { get; set; }

        public string GlobalId { get; set; }
        public string Number { get; set; }
        public Guid AssetId { get; set; }
        public string FileId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? NextDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Frequency { get; set; }
        public bool Planned { get; set; }
        public bool Outcome { get; set; }
        public string Purpose { get; set; }
        public string Method { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }
        public Dictionary<string, object> Type { get; set; }
    }
}
