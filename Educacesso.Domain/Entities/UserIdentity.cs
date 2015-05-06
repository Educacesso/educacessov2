

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Domain.Entities
{
   public class UserIdentity : IdentityUser
    {
      
        public virtual IEnumerable<Curso> Cursos { get; set; }
        public virtual IEnumerable<AmigoUsuario> Amigos {get; set;}

       
        public int QtdSeguidores  { get; set; } 
     
    }
}
