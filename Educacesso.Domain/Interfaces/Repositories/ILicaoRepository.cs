using Educacesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Domain.Interfaces.Repositories
{
    public interface ILicaoRepository : IRepositoryBase<Licao>
    {
        IEnumerable<Licao> LicoesDoCursoSelecionado(int id);

        Licao GetLicaoById(int id);
    }
}
