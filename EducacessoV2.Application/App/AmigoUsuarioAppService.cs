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
    public class AmigoUsuarioAppService : AppServiceBase<AmigoUsuario>, IAmigoUsuarioAppService
    {

        private readonly IAmigoUsuarioService _amigoUsuarioService;

        public AmigoUsuarioAppService(IAmigoUsuarioService amigoUsuarioService)
            : base(amigoUsuarioService)
        {
            _amigoUsuarioService = amigoUsuarioService;
        }

        public List<AmigoUsuario> ListaDeIdDeAmigos(string usuarioLogadoID)
        {
            return _amigoUsuarioService.ListaDeIdDeAmigos(usuarioLogadoID);
        }


        public void addAmigo(int idNovoAmigo, string idUsuario)
        {
            _amigoUsuarioService.addAmigo(idNovoAmigo, idUsuario);
        }
    }
}
