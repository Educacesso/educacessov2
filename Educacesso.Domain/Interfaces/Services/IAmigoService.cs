using Educacesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Domain.Interfaces.Services
{
    public interface IAmigoService : IServiceBase<Amigo>
    {

        List<Amigo> ListaAmigosDoUsuario(List<AmigoUsuario> ListaAmigoDoUsuario);
        int addAmigo(UserIdentity usuario);
    }
}
