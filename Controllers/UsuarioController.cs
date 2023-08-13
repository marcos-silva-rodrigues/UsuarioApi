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

        private UsuarioService _usuarioSevice;

        public UsuarioController(UsuarioService cadastroSevice)
        {
            _usuarioSevice = cadastroSevice;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastraUsuarioAsync([FromBody]CreateUsuarioDto dto)
        {
             await _usuarioSevice.Cadastro(dto);
            return Ok("Usuário cadastrado");


        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {
            await _usuarioSevice.Login(dto);
            return Ok("Usuário autenticado!");
        }
    }
}
