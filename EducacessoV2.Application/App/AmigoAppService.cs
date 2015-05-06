using Educacesso.Domain.Entities;
using Educacesso.Domain.Interfaces.Services;
using EducacessoV2.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacessoV2.Application.App
{
    public class AmigoAppService : AppServiceBase<Amigo>, IAmigoAppService
    {
        private readonly IAmigoService _amigoService;
        public AmigoAppService(IAmigoService amigoService)
            : base(amigoService)
        {
            _amigoService = amigoService;
        }


        public List<Amigo> ListaAmigosDoUsuario(List<AmigoUsuario> ListaAmigoDoUsuario)
        {
            return _amigoService.ListaAmigosDoUsuario(ListaAmigoDoUsuario);
        }


        public int addAmigo(UserIdentity usuario)
        {
            return _amigoService.addAmigo(usuario);
        }
    }
}
