using AutoMapper;
using Educacesso.Domain.Entities;
using Educacesso.MVC.ViewModels;
using EducacessoV2.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Educacesso.MVC.Controllers
{
    public class FazerCursoController : Controller
    {

        private readonly ICursoAppService _cursoApp;
        private readonly ILicaoAppService _licaoApp;

        public FazerCursoController(ICursoAppService cursoApp, ILicaoAppService licaoApp)
        {
            _cursoApp = cursoApp;
            _licaoApp = licaoApp;
        }

        //
        // GET: /FazerCurso/
        public ActionResult Index(int id = 1)
        {
            
            ViewBag.TituloLicao = new SelectList(_licaoApp.LicoesDoCursoSelecionado(id), "LicaoID", "Titulo_Licao");
            var licaoViewModel = Mapper.Map<IEnumerable<Licao>, IEnumerable<LicaoViewModel>>(_licaoApp.GetAll());
			var licaoView = new LicaoViewModel();
            return View(licaoView);
        }

        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public ActionResult Licao(int TituloLicao) // TituloLicao = ID da lição
        {
			
			
			 var licaoSelecionada = Mapper.Map<Licao, LicaoViewModel>(_licaoApp.GetLicaoById(TituloLicao));
            ViewBag.TituloLicao = new SelectList(_licaoApp.LicoesDoCursoSelecionado(licaoSelecionada.CursoID), "LicaoID", "Titulo_Licao");
			


			return View(licaoSelecionada);
        }

     
	}
}