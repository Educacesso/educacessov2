using Educacesso.Domain.Entities;
using Educacesso.Domain.Interfaces.Repositories;
using Educacesso.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Domain.Services
{
    public class AmigoUsuarioService : ServiceBase<AmigoUsuario>, IAmigoUsuarioService
    {

        private readonly IAmigoUsuarioRepository _amigoUsuarioRepository;

        public AmigoUsuarioService(IAmigoUsuarioRepository amigoUsuarioRepository)
            :base(amigoUsuarioRepository)
        {
            _amigoUsuarioRepository = amigoUsuarioRepository;
        }


         public List<AmigoUsuario> ListaDeIdDeAmigos(string usuarioLogadoID)
        {
            return _amigoUsuarioRepository.ListaDeIdDeAmigos(usuarioLogadoID);
        }


         public void addAmigo(int idNovoAmigo, string idUsuario)
         {
              _amigoUsuarioRepository.addAmigo(idNovoAmigo, idUsuario);
         }
    }
}
