using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.HttpAggregator.Models.ModelBase
{
    public class ListResponse<T> where T : class
    {
        public ListResponse(IEnumerable<T> data)
        {
            Data = data;
        }

        public IEnumerable<T> Data { get; }
        public ListMetadata Metadata { get; set; }
    }

    public class ListMetadata
    {
        public int Page { get; set; }
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
        public int ItemsPerPage { get; set; }
    }
}
