using Contract.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ContactController : ControllerBase
    {
        [HttpGet]
        public ActionResult<ContactDTO> Get() => Ok(new ContactDTO
        {
            Name = "John",
            Email = "JohnDoe@example.com"
        });
    }
}
