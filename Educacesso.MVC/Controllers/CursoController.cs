using AutoMapper;
using Educacesso.Domain.Entities;
using Educacesso.MVC.Models;
using Educacesso.MVC.ViewModels;
using EducacessoV2.Application.Interfaces;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Educacesso.MVC.Controllers
{
    public class CursoController : Controller
    {
          private readonly ICursoAppService _cursoApp;
          private readonly IUserAppService _userApp;
          private readonly ILicaoAppService _licaoApp;
        public CursoController(ICursoAppService cursoApp, IUserAppService userApp)
        {
            _cursoApp = cursoApp;
            _userApp = userApp;
        }
         public CursoController(UserManager<UserIdentity> userManager)
        {
            UserManager = userManager;
        }

        public UserManager<UserIdentity> UserManager { get; private set; }

        //
        // GET: /Curso/
        public ActionResult Index()
        {
            var cursoViewModel = Mapper.Map<IEnumerable<Curso>, IEnumerable<CursoViewModel>>(_cursoApp.CursosDoUsuarioLogado(User.Identity.GetUserId()));
            return View(cursoViewModel);
        }

        //
        // GET: /Curso/Details/5
        public ActionResult Details(string id)
        {
            var curso = _cursoApp.GetByID(id);
            
            var cursoViewModel = Mapper.Map<Curso, CursoViewModel>(curso);
            return View(curso);
        }

        //
        // GET: /Curso/Create
        public ActionResult Create()
        {
            
          
            return View();
        }

        //
        // POST: /Curso/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CursoViewModel curso)
        {

           //var iduser = User.Identity.GetUserId();
          // var usuarioLogado = _userApp.GetByID(iduser);
           
            if (ModelState.IsValid)
            {              
                var cursoDomain = Mapper.Map<CursoViewModel, Curso>(curso);

                cursoDomain.UserIdentityId = User.Identity.GetUserId();
                
               _cursoApp.Add(cursoDomain);
                return RedirectToAction("index");
            }
            return View(curso);
        }

        //
        // GET: /Curso/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Curso/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Curso/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Curso/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
