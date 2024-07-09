using CAAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CAAPI.Controllers
{
    [Route("api/bhd")]
    [ApiController]
    public class ContactManagementController : ControllerBase
    {
        private readonly IContactRepository _repo;
        public ContactManagementController(IContactRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetContact()
        {
            var response = _repo.GetAll();
            return Ok(response);
        }


    }
}
