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
            var brandList = new List<BrandDto>()
            {
                new BrandDto { Id = 1, Name = "Ford" },
                new BrandDto { Id = 2, Name = "Subaru" },
                new BrandDto { Id = 3, Name = "Opel" },
            };

            return Ok(brandList);
        }
    }
}
