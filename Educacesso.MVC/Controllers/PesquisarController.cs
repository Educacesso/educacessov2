using AutoMapper;
using Educacesso.Domain.Entities;
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
    public class PesquisarController : Controller
    {
        private readonly ICursoAppService _cursoApp;
        public UserManager<UserIdentity> UserManager { get; private set; }

        public PesquisarController(ICursoAppService cursoApp)
        {
            _cursoApp = cursoApp;
        }

        public PesquisarController(UserManager<UserIdentity> userManager)
        {
            UserManager = userManager;
        }



        //
        // GET: /Pesquisar/
        public ActionResult Index()
        {
           var cursoViewModel = Mapper.Map<IEnumerable<Curso>, IEnumerable<Curso>>(null);
           
            return View(cursoViewModel);
        }

        [HttpPost]
        public ActionResult Index(string searchTerm)
        {


            IEnumerable<Curso> lcursos;


            if (string.IsNullOrEmpty(searchTerm)) 
                lcursos = _cursoApp.GetAll(); 
            else          
                lcursos = _cursoApp.BuscarCursosAutocomplete(searchTerm);
            
            //
            return View(lcursos);
            
        }

       
        public JsonResult GetCursos(string term)
        {
            

            List<string> cursos = _cursoApp.BuscarCursosAutocomplete(term).Distinct().Select(y => y.Nome_Curso).ToList();

            return Json(cursos, JsonRequestBehavior.AllowGet);
        }

    }
}