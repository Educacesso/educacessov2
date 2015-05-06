using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Educacesso.Domain.Entities
{
   public class Curso
    {

        public int CursoID { get; set; }

        public string UserIdentityId { get; set; }
        public virtual UserIdentity UserIdentity { get; set; }
        public string Nome_Curso { get; set; }
        public string Resumo_Curso { get; set; }
        public virtual IEnumerable<Licao> Licoes { get; set; }
       // public DateTime DataCadastro { get; set; }
        //public int Views_Curso { get; set; }

       // public IdentityUser Id { get; set; }
     

      
    }
}
