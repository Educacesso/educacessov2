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
    public class UserService : ServiceBase<UserIdentity>, IUserService
    {

        private readonly IUserRepository _usuarioRepository;

        public UserService(IUserRepository usuarioRepository)
            : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
    }
}
