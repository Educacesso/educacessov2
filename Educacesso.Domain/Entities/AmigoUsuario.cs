using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Domain.Entities
{
   public class AmigoUsuario
    {
        public int AmigoUsuarioId { get; set; }
        public string UserIdentityId { get; set; }
        public int AmigoId { get; set; }

        public virtual UserIdentity UserIdentity { get; set; }
        public virtual Amigo Amigo { get; set; }
    }
}
