using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Educacesso.MVC.ViewModels
{
    public class ExercicioViewModel
    {

        [Key]
        public int ExercicioID { get; set; }

        [Required(ErrorMessage = "Insira a pergunta")]
        [MaxLength(150, ErrorMessage = "Maximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Pergunta_Exer { get; set; }
    }
}