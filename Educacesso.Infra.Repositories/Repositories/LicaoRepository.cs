using Educacesso.Domain.Entities;
using Educacesso.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Infra.Repositories.Repositories
{
   public class LicaoRepository : RepositoryBase<Licao>, ILicaoRepository
    {

       public IEnumerable<Licao> LicoesDoCursoSelecionado(int id)
       {
           return Db.Licoes.Where(l => l.CursoID == id);
        
       }


       public Licao GetLicaoById(int id)
       {
           return Db.Licoes.Where(l => l.LicaoID == id).First();
       }
    }
}
