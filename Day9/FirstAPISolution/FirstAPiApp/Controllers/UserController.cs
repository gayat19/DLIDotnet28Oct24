﻿using FirstAPiApp.Interfaces;
using FirstAPiApp.Misc;
using FirstAPiApp.Models;
using FirstAPiApp.Models.DTOs;
using FirstAPiApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [CustomExceptionFilter]
    public class UserController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public UserController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult<LoginResponseDTO>> Register(LoginRequestDTO loginRequestDTO)
        {
            var result = await _loginService.RegisterAsync(loginRequestDTO); ;
            if (result == null)
                return BadRequest(new ErrorObject
                {
                    ErrorCode = 500,
                    Message = "Unable to register at this moment"
                });
            return Ok(result);
        }
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<LoginResponseDTO>> Login(LoginRequestDTO loginRequestDTO)
        {
            var result = await _loginService.LoginAsync(loginRequestDTO); 
           //try
           // {
                if (result == null)
                    return BadRequest(new ErrorObject
                    {
                        ErrorCode = 500,
                        Message = "Unable to register at this moment"
                    });
                return Ok(result);
            //}
            //catch (Exception ex)
            //{
            //    return Unauthorized(new ErrorObject
            //    {
            //        ErrorCode = 500,
            //        Message = "UnAuthorizec"
            //    });
            //}
        }
    }
}
