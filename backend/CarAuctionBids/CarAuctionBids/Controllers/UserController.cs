using CarAuctionBids_Business.Abstraction;
using CarAuctionBids_Business.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarAuctionBids.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("Register")]
        public async Task<IActionResult> CreateUser([FromBody] RegisterRequestDTO model)
        {
            var response = await _userService.Register(model);
            return Ok(response);
        }


        [HttpPost("Login")]
        public async Task<IActionResult> LoginUser([FromBody] LoginRequestDTO model)
        {
            var response = await _userService.Login(model);
            if (response.isSuccess)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}
