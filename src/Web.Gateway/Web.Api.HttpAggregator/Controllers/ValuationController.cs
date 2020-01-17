using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Api.HttpAggregator.Interfaces;
using Web.Api.HttpAggregator.Models;
using Web.Api.HttpAggregator.Models.ModelBase;

namespace Web.Api.HttpAggregator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuationController : ControllerBase
    {
        private readonly IValuationService _valuationService;
        public ValuationController(IValuationService valuationService)
        {
            _valuationService = valuationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
       
        [HttpGet("{id}")]
        public async Task<ActionResult<DetailsResponse<ValuationDetails>>> GetById(Guid id)
        {
            return await _valuationService.GetByIdAsync(id);
        }        
    }
}
