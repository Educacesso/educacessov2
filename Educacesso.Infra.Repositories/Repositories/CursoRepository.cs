using Educacesso.Domain.Entities;
using Educacesso.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Infra.Repositories.Repositories
{
    public class CursoRepository : RepositoryBase<Curso>, ICursoRepository
    {
        public IEnumerable<Curso> CursosDoUsuarioLogado(string id)
        {
            return Db.Cursos.Where(c => c.UserIdentityId == id);
        }



        public IEnumerable<Curso> BuscarCursosAutocomplete(string nome)
        {
            return Db.Cursos.Where(x => x.Nome_Curso.StartsWith(nome)).ToList();
        }


        public Curso GetCursoByID(int id)
        {
         /*var lista =  Db.Cursos.Join(Db.Licoes, c => c.CursoID, l => l.CursoID == id, (c, l) => 
                new { c.Nome_Curso, c.Resumo_Curso, l.Titulo_Licao, l.Conteudo_Licao })
                .ToList();*/
           
            return Db.Cursos.Where(c => c.CursoID == id).First();
        }
    }
}
