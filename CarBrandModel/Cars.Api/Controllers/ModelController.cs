using Cars.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            return Ok("models...");
        }
    }
}
