using Educacesso.Domain.Entities;
using Educacesso.Infra.Repositories.EntityConfig;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Infra.Repositories.Contexto
{
    public class EducacessoIdentity : IdentityDbContext<UserIdentity>
    {

        public EducacessoIdentity()
            : base("DbEducacessoV2")
        {

        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserIdentityConfiguration());
        }
    }
}
