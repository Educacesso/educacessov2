using Educacesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Infra.Repositories.EntityConfig
{
   public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {

       public UsuarioConfiguration()
       {
           HasKey(x => x.UsuarioID);

           Property(x => x.Nome).IsRequired().HasMaxLength(250);
           Property(x => x.Email).IsRequired().HasMaxLength(250);
           Property(x => x.Senha).IsRequired().HasMaxLength(150);
       }
    }
}
