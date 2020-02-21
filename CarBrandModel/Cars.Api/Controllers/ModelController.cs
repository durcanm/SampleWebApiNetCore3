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
            var brand = CarsDataStore.current.Brands
                .FirstOrDefault(x => x.Id == brandId);

            if (brand == null)
            {
                return NotFound();
            }

            return Ok(brand.Models);
        }

        [HttpGet("{modelId}")]
        public ActionResult<ModelDto> GetModel(int brandId, int modelId)
        {
            var brand = CarsDataStore.current.Brands
                .FirstOrDefault(x => x.Id == brandId);

            if (brand == null)
            {
                return NotFound();
            }

            var model = brand.Models
                .FirstOrDefault(x => x.Id == modelId);

            return Ok(model);
        }
    }
}
