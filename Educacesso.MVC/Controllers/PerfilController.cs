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






        #region Actions
        public ActionResult MeuPerfil()
        {
            var usuarioLogado = _userAppService.GetByID(User.Identity.GetUserId());
            return View(usuarioLogado);
        }


        public ActionResult Index()
        {
            return RedirectToAction("Manage", "Account");
        }
       
        public ActionResult Seguindo()
        {
          
            //LISTA DE AMIGOS
            List<AmigoUsuario> lamigoUsuario = _amigoUsuarioAppService.ListaDeIdDeAmigos(User.Identity.GetUserId()); //Buscando os amigos do usuario
            List<Amigo> lamigo = _amigoAppService.ListaAmigosDoUsuario(lamigoUsuario); // uma lista de Amigos Do usuario que está logado

            List<UserIdentity> listaSeguindo = new List<UserIdentity>();
            foreach (var item in lamigo)
            {
             var users =  _userAppService.GetByID(item.UserIdentityId);
                listaSeguindo.Add(users);
            }
           
            return View(listaSeguindo);
        }


        public ActionResult BuscarUsuarios()
        {
            var usuario = _userAppService.GetAll(); // PAGINA ADD AMIGO, Exibe uma lista de usuarios para seguir
            List<UserIdentity> list = usuario.ToList();

            List<AmigoUsuario> lamigoUsuario = _amigoUsuarioAppService.ListaDeIdDeAmigos(User.Identity.GetUserId()); //Buscando os amigos do usuario
            List<Amigo> lamigo = _amigoAppService.ListaAmigosDoUsuario(lamigoUsuario);

            #region remover da lista amigos que o usuario já segue
            foreach (var usuarios in usuario)
            {
                foreach (var meusAmigos in lamigo)
                {
                    if (usuarios.Id == meusAmigos.UserIdentityId || usuarios.Id == User.Identity.GetUserId())
                    {
                        list.Remove(usuarios);
                    }
                }

            }
            #endregion

            return View(list);
        }

        
        public ActionResult Adicionar(string Id)
        {         
            var umAmigo = _userAppService.GetByID(Id);
            int idAmigoAdicionado = _amigoAppService.addAmigo(umAmigo);

			umAmigo.QtdSeguidores += 1;
			_userAppService.Update(umAmigo);
            _amigoUsuarioAppService.addAmigo(idAmigoAdicionado, User.Identity.GetUserId());
            return RedirectToAction("Index");
        }

        #endregion


    }
}