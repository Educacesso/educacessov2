using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Domain.Entities
{
   public class Amigo
    {
       
        public int AmigoId { get; set; }
        public string UserIdentityId { get; set; }
        public UserIdentity UserIdentity { get; set; }
        public virtual ICollection<AmigoUsuario> AmigoUsuarios {get; set;}

        public string NomeUsuarioAmigo { get; set; }
    }
}
