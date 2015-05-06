using AutoMapper;
using Educacesso.Domain.Entities;
using Educacesso.MVC.ViewModels;
using EducacessoV2.Application.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Educacesso.MVC.Controllers
{
    public class PerfilController : Controller
    {

        private readonly IAmigoAppService _amigoAppService;
        private readonly IAmigoUsuarioAppService _amigoUsuarioAppService;
        private readonly IUserAppService _userAppService;

        public PerfilController(IAmigoAppService amigoAppService, IAmigoUsuarioAppService amigoUsuarioAppService, IUserAppService userAppService)
        {
            _amigoAppService = amigoAppService;
            _amigoUsuarioAppService = amigoUsuarioAppService;
            _userAppService = userAppService;
        }


        public PerfilController(UserManager<UserIdentity> userManager)
        {
            UserManager = userManager;
        }

        public UserManager<UserIdentity> UserManager { get; private set; }

        public ActionResult MeuPerfil()
        {
            var usuarioLogado = _userAppService.GetByID(User.Identity.GetUserId());
            return View(usuarioLogado);
        }


        public ActionResult Index()
        {
            return RedirectToAction("Manage", "Account");
        }
        //
        // GET: /Perfil/
        public ActionResult Seguindo()
        {
          
            //LISTA DE AMIGOS
            List<AmigoUsuario> lamigoUsuario = _amigoUsuarioAppService.ListaDeIdDeAmigos(User.Identity.GetUserId()); //Buscando os amigos do usuario
            List<Amigo> lamigo = _amigoAppService.ListaAmigosDoUsuario(lamigoUsuario); // uma lista de Amigos Do usuario que está logado

           
            return View(lamigo);
        }


        public ActionResult BuscarUsuarios()
        {
            var usuario = _userAppService.GetAll(); // PAGINA ADD AMIGO

            return View(usuario);
        }

        
        public ActionResult Adicionar(string Id)
        {         
            var umAmigo = _userAppService.GetByID(Id);
            int idAmigoAdicionado = _amigoAppService.addAmigo(umAmigo);

            _amigoUsuarioAppService.addAmigo(idAmigoAdicionado, User.Identity.GetUserId());
            return RedirectToAction("Index");
        }
    }
}