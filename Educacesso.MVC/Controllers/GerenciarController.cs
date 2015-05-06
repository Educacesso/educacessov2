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
    public class GerenciarController : Controller
    {
        private readonly ICursoAppService _cursoApp;
        private readonly ILicaoAppService _licaoApp;
        private readonly IUserAppService _userApp;


        public GerenciarController(ICursoAppService cursoApp, ILicaoAppService licaoApp, IUserAppService userApp)
        {
            _cursoApp = cursoApp;
            _licaoApp = licaoApp;
            _userApp = userApp;

        }


        //
        // GET: /Gerenciar/
        public ActionResult MeusCursos()
        {
            var cursoViewModel = Mapper.Map<IEnumerable<Curso>, IEnumerable<CursoViewModel>>(_cursoApp.CursosDoUsuarioLogado(User.Identity.GetUserId()));

            return View(cursoViewModel);
        }

        /* [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult MeusCursos(int curso)
         {
            int cursoID = curso;

             return RedirectToAction("NovaLicao", cursoID);
         }*/


        public ActionResult NovaLicao(int cursoId)
        {


            var cursoViewModel = Mapper.Map<IEnumerable<Curso>, IEnumerable<CursoViewModel>>(_cursoApp.CursosDoUsuarioLogado(User.Identity.GetUserId()));

            foreach (var item in cursoViewModel)
            {
                if (item.CursoID == cursoId)
                {
                   
                    return View();
                }
            }

            return RedirectToAction("MeusCursos");
        }



            [HttpPost]
            [ValidateInput(false)]
            public ActionResult NovaLicao(LicaoViewModel novaLicao, int cursoId)
            {
                if(ModelState.IsValid)
                {
                    var licaoDomain = Mapper.Map<LicaoViewModel, Licao>(novaLicao);
                    licaoDomain.CursoID = cursoId;
                    _licaoApp.Add(licaoDomain);
                    return RedirectToAction("Index", "Educacesso");
                
                }

                return View(novaLicao);
            }




    }
}