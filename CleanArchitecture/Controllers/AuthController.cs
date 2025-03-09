using CleanArchitecture.Application.DTOs.Auth;
using CleanArchitecture.Application.Features.Auth.Commands;
using CleanArchitecture.Application.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IMediator _mediator;

        public AuthController(IAuthService authService, IMediator mediator)
        {
            _authService = authService;
            _mediator = mediator;
        }


        [HttpOptions]
        public IActionResult Options()
        {
            return Ok();
        }



        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterCommand request)
        {
            try
            {
                var result = await _mediator.Send(request);
                if (!result.IsSuccessful)
                {
                    return BadRequest(result);
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmail([FromQuery] string userId, [FromQuery] string token)
        {
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(token))
            {
                return BadRequest("Invalid email confirmation request");
            }

            var result = await _authService.ConfirmEmailAsync(userId, token);
            if (!result)
            {
                return BadRequest("Invalid email confirmation request");
            }

            return Ok("Email confirmed successfully. You can now login to your account.");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginCommand request)
        {

            try
            {
                var result = await _mediator.Send(request);
                if (result == null)
                {
                    return BadRequest(result);
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }

            //try
            //{
            //    var result = await _authService.LoginAsync(request);
            //    if (result == null)
            //    {
            //        return BadRequest(new { message = "Invalid email or password" });
            //    }
            //    return Ok(result);
            //}
            //catch (Exception ex)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            //}
        }

        //[HttpPost("forgot-password")]
        //public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordRequest request)
        //{
        //    try
        //    {
        //        var result = await _authService.ForgotPasswordAsync(request.Email);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
        //    }
        //}

        //[HttpPost("reset-password")]
        //public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequest request)
        //{
        //    try
        //    {
        //        var result = await _authService.ResetPasswordAsync(request);
        //        if (!result.IsSuccessful)
        //        {
        //            return BadRequest(result);
        //        }
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
        //    }
        //}
    }
}