using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.HttpAggregator.Models.ModelBase
{
    public class DetailsResponse<T> where T : class
    {
        public T Data { get; set; }
        public DetailsMetadata Metadata { get; set; }
    }
}
