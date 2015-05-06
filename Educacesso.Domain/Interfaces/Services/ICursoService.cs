using Educacesso.Domain.Entities;
using Educacesso.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Domain.Interfaces.Services
{
    public interface ICursoService : IServiceBase<Curso>
    {

        IEnumerable<Curso> CursosDoUsuarioLogado(string id);
        IEnumerable<Curso> BuscarCursosAutocomplete(string nome);

        Curso GetCursoByID(int id);
    }
}
