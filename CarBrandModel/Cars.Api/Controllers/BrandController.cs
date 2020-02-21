using Cars.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
    }
}
