using Educacesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Infra.Repositories.EntityConfig
{
    public class UserIdentityConfiguration : EntityTypeConfiguration<UserIdentity>
    {

        public UserIdentityConfiguration()
        {
           
            Property(x => x.QtdSeguidores).IsOptional();
        }
    }
}
