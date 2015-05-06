using Educacesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacessoV2.Application.Interfaces
{
   public interface IAmigoAppService : IAppServiceBase<Amigo>
    {

        List<Amigo> ListaAmigosDoUsuario(List<AmigoUsuario> ListaAmigoDoUsuario);
        int addAmigo(UserIdentity usuario);
    }
}
