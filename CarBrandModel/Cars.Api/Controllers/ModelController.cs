using Cars.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Cars.Api.Controllers
{
    [ApiController]
    [Route("api/brand/{brandId}/model")]
    public class ModelController : ControllerBase
    {
        public ModelController()
        { }

        [HttpGet]
        public ActionResult<IEnumerable<ModelDto>> GetModelByBrand(int brandId)
        {
            var modelList = CarsDataStore.current.Brands
                .Where(x=>x.Id==brandId)
                .ToList();

            return Ok(modelList);
        }
    }
}
