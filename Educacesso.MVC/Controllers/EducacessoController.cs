using AutoMapper;
using Educacesso.Domain.Entities;
using Educacesso.MVC.ViewModels;
using EducacessoV2.Application.Interfaces;
using Microsoft.AspNet.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Educacesso.MVC.Controllers
{
    public class EducacessoController : Controller
    {
        private readonly ICursoAppService _cursoApp;

        public EducacessoController(ICursoAppService cursoApp)
        {
            _cursoApp = cursoApp;
        }
         public EducacessoController(UserManager<UserIdentity> userManager)
        {
            UserManager = userManager;
        }

        public UserManager<UserIdentity> UserManager { get; private set; }
        //
        // GET: /Educacesso/
        [Authorize]
        public ActionResult Index()
        {
            int qtd = 5;


            ViewBag.QuantidadeCurso = qtd;
            return View();
        }

      

        [HttpPost] 
		
        public ActionResult Index(string inputCurso, string textArea)
        {
            Curso Curso = new Curso
            {
                Nome_Curso = inputCurso,
                Resumo_Curso = textArea,
                UserIdentityId = User.Identity.GetUserId()
               
            };

            _cursoApp.Add(Curso);
            return View();
        }

       
	}
}