using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Educacesso.MVC.ViewModels
{
    public class LicaoViewModel
    {

        [Key]
        public int LicaoID { get; set; }

        [Required(ErrorMessage = "Insira o Titulo da Licao")]
        [MaxLength(150, ErrorMessage = "Maximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Titulo_Licao { get; set; }

        [Required(ErrorMessage = "Insira o Conteudo da Licao")]
        [MaxLength(150, ErrorMessage = "Maximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Conteudo_Licao { get; set; }

        public int CursoID { get; set; }
        public virtual CursoViewModel Curso { get; set; }
    }

}