using Educacesso.Domain.Entities;
using Educacesso.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Infra.Repositories.Repositories
{
    public class AmigoRepository : RepositoryBase<Amigo>, IAmigoRepository
    {

        public List<Amigo> ListaAmigosDoUsuario(List<AmigoUsuario> ListaAmigoDoUsuario) // Lista de Amigos, agora preciso exibilas
        {
            List<Amigo> listaAmigo = new List<Amigo>();

            foreach (var item in ListaAmigoDoUsuario)
            {
                Amigo ListaAmigo = new Amigo();
                ListaAmigo = Db.Amigos.Where(a => a.AmigoId == item.AmigoId).First();

                
                listaAmigo.Add(ListaAmigo);
            }
            

            return listaAmigo;
        }

        public int addAmigo(UserIdentity usuario)
        {
          
            Amigo amigo = new Amigo
            {
                NomeUsuarioAmigo = usuario.UserName,
                UserIdentityId = usuario.Id
            };

            
            
           // Db.Entry(usuario).State = EntityState.Modified;
            
            Db.Set<Amigo>().Add(amigo);
            Db.SaveChanges();

            return amigo.AmigoId;
        }
    }
}
