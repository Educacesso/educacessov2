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
    public class ListaCursosController : Controller
    {

		private readonly ICursoAppService _cursoApp;

		public ListaCursosController(ICursoAppService cursoApp)
		{
			_cursoApp = cursoApp;
		}

        //
        // GET: /ListaCursos/
        public ActionResult Index(string Id)
        {
			var cursoViewModel = Mapper.Map<IEnumerable<Curso>, IEnumerable<CursoViewModel>>(_cursoApp.CursosDoUsuarioLogado(Id));
            return View(cursoViewModel);
        }
	}
}