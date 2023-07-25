using RegisDocManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using RegisDocManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.IO;

namespace RegisDocManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly IService _uploadService;

        public ServiceController(IService uploadService)
        {
            _uploadService = uploadService;
        }
        /*
        [HttpPost("authen")]
        public async Task<ActionResult> Authen([FromForm] User user)
        {
            if (user == null) return BadRequest();

            try
            {
                string jwt = _uploadService.AuthorizeUser(user);
                if (jwt.Length > 3) return Ok(jwt);
                return BadRequest();
            }
            catch (Exception)
            {
                throw;
            }
        }
        */

        [HttpPost("NewDomain")]
        public async Task<ActionResult> NewDomain([FromForm] Domain d)
        {
            if (d == null)
            {
                return BadRequest();
            }

            try
            {
                await _uploadService.AddNewDomain(d);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}