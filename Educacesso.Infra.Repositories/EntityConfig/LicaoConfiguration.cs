using Educacesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Infra.Repositories.EntityConfig
{
    class LicaoConfiguration : EntityTypeConfiguration<Licao>
    {

        public LicaoConfiguration()
        {
            Property(x => x.Conteudo_Licao).HasMaxLength(7000);
        }
    }
}
