using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Domain.Entities
{
   public class Exercicio
    {
        public int ExercicioID { get; set; }
        public string Pergunta_Exer { get; set; }
        public string Resposta_A { get; set; }
        public string Resposta_B { get; set; }
        public string Resposta_C { get; set; }
        public string Resposta_D { get; set; }
        public string Resposta_Correta { get; set; }
        public Curso CursoID { get; set; }
    }
}
