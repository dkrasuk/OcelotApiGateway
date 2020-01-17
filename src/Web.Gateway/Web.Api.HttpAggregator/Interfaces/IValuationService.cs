using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.HttpAggregator.Models;
using Web.Api.HttpAggregator.Models.ModelBase;

namespace Web.Api.HttpAggregator.Interfaces
{
    public interface IValuationService
    {
        Task<DetailsResponse<ValuationDetails>> GetByIdAsync(Guid Id);
    }
}
