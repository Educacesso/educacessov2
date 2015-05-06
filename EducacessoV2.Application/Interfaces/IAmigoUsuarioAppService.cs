using Educacesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacessoV2.Application.Interfaces
{
    public interface IAmigoUsuarioAppService : IAppServiceBase<AmigoUsuario>
    {

        List<AmigoUsuario> ListaDeIdDeAmigos(string usuarioLogadoID);
        void addAmigo(int idNovoAmigo, string idUsuario);
    }
}
