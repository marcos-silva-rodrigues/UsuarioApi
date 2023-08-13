using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuarioApi.Data;
using UsuarioApi.Data.Dtos;
using UsuarioApi.Services;

namespace UsuarioApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        private UsuarioService _cadastroSevice;

        public UsuarioController(UsuarioService cadastroSevice)
        {
            _cadastroSevice = cadastroSevice;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastraUsuarioAsync([FromBody]CreateUsuarioDto dto)
        {
             await _cadastroSevice.Cadastro(dto);
            return Ok("Usuário cadastrado");


        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {
            await _cadastroSevice.Login(dto);
            return Ok("Usuário autenticado!");
        }
    }
}
