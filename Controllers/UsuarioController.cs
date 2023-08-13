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

        private CadastroService _cadastroSevice;

        public UsuarioController(CadastroService cadastroSevice)
        {
            _cadastroSevice = cadastroSevice;
        }

        [HttpPost]
        public async Task<IActionResult> CadastraUsuarioAsync([FromBody]CreateUsuarioDto dto)
        {
             await _cadastroSevice.Cadastro(dto);
            return Ok("Usuário cadastrado");


        }
    }
}
