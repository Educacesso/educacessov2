using Educacesso.Domain.Entities;
using Educacesso.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Infra.Repositories.Repositories
{
    public class AmigoUsuarioRepository : RepositoryBase<AmigoUsuario>, IAmigoUsuarioRepository
    {


        public List<AmigoUsuario> ListaDeIdDeAmigos(string usuarioLogadoID)
        {

            return Db.AmigoUsuarios.Where(x => x.UserIdentityId == usuarioLogadoID).ToList();
        }

        public void addAmigo(int idNovoAmigo, string idUsuario)
        {
            AmigoUsuario novoAmigo = new AmigoUsuario
            {
                AmigoId = idNovoAmigo,
                UserIdentityId = idUsuario
            };

            Db.Set<AmigoUsuario>().Add(novoAmigo);
            Db.SaveChanges();
        }


    }
}
