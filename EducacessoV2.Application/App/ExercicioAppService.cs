using Educacesso.Domain.Entities;
using Educacesso.Domain.Interfaces.Services;
using EducacessoV2.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacessoV2.Application.App
{
    public class ExercicioAppService : AppServiceBase<Exercicio>, IExercicioAppService
    {
        
        private readonly IExercicioService _exercicioService;

        public ExercicioAppService(IExercicioService exercicioService)
            :base(exercicioService)
        {
            _exercicioService = exercicioService;
        }
    }
}
