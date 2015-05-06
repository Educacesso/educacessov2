using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Educacesso.MVC.ViewModels
{
    public class UsuarioViewModel
    {
       /* [Key]
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(250, ErrorMessage = "Maximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo email")]
        [MaxLength(250, ErrorMessage = "Maximo {0} Caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um email válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo SENHAA")]
        [MaxLength(150, ErrorMessage = "Maximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Senha { get; set; }*/

        [Key]
        public int IdentityUserId { get; set; }

        public string UserName { get; set; }


      
        
    }
}