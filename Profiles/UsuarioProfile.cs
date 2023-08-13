using AutoMapper;
using UsuarioApi.Data;
using UsuarioApi.Data.Dtos;

namespace UsuarioApi.Profiles
{
    public class UsuarioProfile: Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
