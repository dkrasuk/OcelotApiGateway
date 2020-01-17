using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.HttpAggregator.Interfaces;
using Web.Api.HttpAggregator.Models;
using Web.Api.HttpAggregator.Models.ModelBase;

namespace Web.Api.HttpAggregator.Services
{
    public class ValuationService : IValuationService
    {
        public Task<DetailsResponse<ValuationDetails>> GetByIdAsync(Guid Id)
        {
            return Task.FromResult(new DetailsResponse<ValuationDetails>
            {
                Data = new ValuationDetails(),
                Metadata = new DetailsMetadata
                {
                    Timestamp = BitConverter.GetBytes((int)DateTime.Now.Second)
                }
            });
        }
    }
}
