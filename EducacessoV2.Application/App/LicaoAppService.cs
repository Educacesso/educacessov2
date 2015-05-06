using Educacesso.Domain.Entities;
using Educacesso.Domain.Interfaces.Services;
using EducacessoV2.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacessoV2.Application.App
{
    public class LicaoAppService : AppServiceBase<Licao>, ILicaoAppService
    {
         private readonly ILicaoService _licaoService;

        public LicaoAppService(ILicaoService licaoService)
            :base(licaoService)
        {
            _licaoService = licaoService;
        }

        public IEnumerable<Licao> LicoesDoCursoSelecionado(int id)
        {
           return _licaoService.LicoesDoCursoSelecionado(id);
        }


        public Licao GetLicaoById(int id)
        {
            return _licaoService.GetLicaoById(id);
        }
    }
}
