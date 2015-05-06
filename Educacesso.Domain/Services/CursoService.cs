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
    public class CursoService : ServiceBase<Curso>, ICursoService
    {

        private readonly ICursoRepository _cursoRepository;

       public CursoService(ICursoRepository cursoRepository)
           : base(cursoRepository)
       {
           _cursoRepository = cursoRepository;
          
       }


       public IEnumerable<Curso> CursosDoUsuarioLogado(string id)
       {
           return _cursoRepository.CursosDoUsuarioLogado(id);
       }


       public IEnumerable<Curso> BuscarCursosAutocomplete(string nome)
       {
           return _cursoRepository.BuscarCursosAutocomplete(nome);
       }


       public Curso GetCursoByID(int id)
       {
           return _cursoRepository.GetCursoByID(id);
       }
    }
}
