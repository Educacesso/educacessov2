using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using Educacesso.Infra.Repositories.EntityConfig;
using Educacesso.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
namespace Educacesso.Infra.Repositories.Contexto
{
    public class EducacessoContexto : DbContext
    {
        public EducacessoContexto()
            : base("DbEducacessoV2")
        {
            Database.SetInitializer<EducacessoContexto>(null);
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<AmigoUsuario> AmigoUsuarios { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Licao> Licoes { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }

    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
       

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });

           
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

           

         

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new LicaoConfiguration());
           
            base.OnModelCreating(modelBuilder);


        }

       public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }


     
    }
}
