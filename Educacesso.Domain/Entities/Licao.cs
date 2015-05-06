using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Domain.Entities
{
    public class Licao
    {

        public int LicaoID { get; set; }
        public string Titulo_Licao { get; set; }
        public string Conteudo_Licao { get; set; }
        public int CursoID { get; set; }
        public virtual Curso Curso { get; set; }


      //   public IEnumerable<Curso> Cursos {get; set;}
        
    }
}
