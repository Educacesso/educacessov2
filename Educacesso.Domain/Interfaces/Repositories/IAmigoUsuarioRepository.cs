using Educacesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Domain.Interfaces.Repositories
{
   public  interface IAmigoUsuarioRepository :IRepositoryBase<AmigoUsuario>
    {

       List<AmigoUsuario> ListaDeIdDeAmigos(string usuarioLogadoID);
       void addAmigo(int idNovoAmigo, string idUsuario);
    }
}
