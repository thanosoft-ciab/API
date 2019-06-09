using AutoMapper;
using AutoMapper.Configuration;
using ThanosSoft.Infraestrutura.EDMX;
using ThanosSoft.ViewModel.DTO;

namespace ThanosSoft.WebAPI.DTO
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioDTO>();
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
    }
}
