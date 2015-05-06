using Educacesso.Domain.Entities;
using EducacessoV2.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Educacesso.Domain.Interfaces.Services;
using Microsoft.AspNet.Identity.EntityFramework;
namespace EducacessoV2.Application.App
{
    public class UserAppService : AppServiceBase<UserIdentity>, IUserAppService
    {

        
        private readonly IUserService _usuarioService;

        public UserAppService(IUserService usuarioService)
            :base(usuarioService)
        {
            _usuarioService = usuarioService;
        }
    }
}
