using Cars.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Cars.Api.Controllers
{
    [ApiController]
    [Route("api/brand")]
    public class BrandController : ControllerBase
    {
        public BrandController()
        { }

        [HttpGet]
        public ActionResult<IEnumerable<BrandDto>> GetAllBrands()
        {
            var brandList = CarsDataStore.current.Brands;

            return Ok(brandList);
        }


        [HttpGet("{brandId}")]
        public ActionResult<BrandDto> GetBrand(int brandId)
        {
            var brand = CarsDataStore.current.Brands
                .FirstOrDefault(x => x.Id == brandId);

            if (brand == null)
            {
                return NotFound();
            }

            return Ok(brand);
        }
    }
}
