using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ThanosSoft.Infraestrutura.EDMX;
using ThanosSoft.ViewModel.DTO;

namespace ThanosSoft.WebAPI.DTO
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UsuarioDTO, Usuario>();
        }

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
    }
}