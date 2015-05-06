using AutoMapper;
using Educacesso.Domain.Entities;
using Educacesso.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Educacesso.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UsuarioViewModel, Usuario>();
            Mapper.CreateMap<CursoViewModel, Curso>();
            Mapper.CreateMap<LicaoViewModel, Licao>();
            Mapper.CreateMap<ExercicioViewModel, Exercicio>();


        }
    }
}