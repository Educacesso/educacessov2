using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Educacesso.MVC.ViewModels
{
    public class CursoViewModel
    {
        [Key]
        public int CursoID { get; set; }

        [Required(ErrorMessage = "Insira o nome do Curso")]
        [MaxLength(150, ErrorMessage = "Maximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome_Curso { get; set; }

        [Required(ErrorMessage = "Insira o resumo do Curso")]
        [MaxLength(150, ErrorMessage = "Maximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Resumo_Curso { get; set; }

        public virtual IEnumerable<LicaoViewModel> Licoes { get; set; }
    }
}