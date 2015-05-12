using Educacesso.Domain.Entities;
using Educacesso.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Infra.Repositories.Repositories
{
   public class UserRepository : RepositoryBase<UserIdentity>, IUserRepository
    {

    }
}
