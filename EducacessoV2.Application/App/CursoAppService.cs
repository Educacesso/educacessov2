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
    public class CursoAppService : AppServiceBase<Curso>, ICursoAppService
    {
         
        private readonly ICursoService _cursoService;

        public CursoAppService(ICursoService cursoService)
            :base(cursoService)
        {
            _cursoService = cursoService;
        }

        public IEnumerable<Curso> CursosDoUsuarioLogado(string id)
        {
            return _cursoService.CursosDoUsuarioLogado(id);
        }


        public IEnumerable<Curso> BuscarCursosAutocomplete(string nome)
        {
            return _cursoService.BuscarCursosAutocomplete(nome);
        }


        public Curso GetCursoByID(int id)
        {
            return _cursoService.GetCursoByID(id);
        }
    }
}
