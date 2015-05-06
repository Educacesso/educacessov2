using Educacesso.Domain.Entities;
using Educacesso.Domain.Interfaces.Repositories;
using Educacesso.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Domain.Services
{
   public class AmigoService : ServiceBase<Amigo>, IAmigoService
    {

       private readonly IAmigoRepository _amigoRepository;

       public AmigoService(IAmigoRepository amigoRepository)
           : base(amigoRepository)
       {
           _amigoRepository = amigoRepository;
          
       }

       public List<Amigo> ListaAmigosDoUsuario(List<AmigoUsuario> ListaAmigoDoUsuario)
       {

           return _amigoRepository.ListaAmigosDoUsuario(ListaAmigoDoUsuario);
       }


       public int addAmigo(UserIdentity usuario)
       {
           return _amigoRepository.addAmigo(usuario);
       }
    }
}
