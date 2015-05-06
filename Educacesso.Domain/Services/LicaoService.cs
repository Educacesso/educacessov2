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
   public class LicaoService : ServiceBase<Licao>, ILicaoService
    {

       private readonly ILicaoRepository _licaoRepository;

       public LicaoService(ILicaoRepository licaoRepository )
           : base(licaoRepository)
       {
           _licaoRepository = licaoRepository;
       }

       public IEnumerable<Licao> LicoesDoCursoSelecionado(int id)
       {
           return _licaoRepository.LicoesDoCursoSelecionado(id);
       }


       public Licao GetLicaoById(int id)
       {
           return _licaoRepository.GetLicaoById(id);
       }
    }
}
