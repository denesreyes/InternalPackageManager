using Contract.ApiProxies;
using Contract.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ContactDTO>> Get()
        {
            var proxy = new ContactAPI();
            return Ok(await proxy.GetContact());
        }
    }
}
