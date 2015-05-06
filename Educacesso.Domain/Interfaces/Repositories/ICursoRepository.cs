using Educacesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Domain.Interfaces.Repositories
{
   public interface ICursoRepository : IRepositoryBase<Curso>
    {

       IEnumerable<Curso> CursosDoUsuarioLogado(string id);
       IEnumerable<Curso> BuscarCursosAutocomplete(string nome);
       

       Curso GetCursoByID(int id);
    }
}
