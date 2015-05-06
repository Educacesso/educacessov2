using Educacesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacessoV2.Application.Interfaces
{
    public interface ILicaoAppService : IAppServiceBase<Licao>
    {

        IEnumerable<Licao> LicoesDoCursoSelecionado(int id);
        Licao GetLicaoById(int id);
    }
}
