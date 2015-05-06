using Educacesso.Domain.Entities;
using Educacesso.Domain.Interfaces.Repositories;
using Educacesso.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Domain.Services
{
    class ExercicioService : ServiceBase<Exercicio>, IExercicioService
    {

        private readonly IExercicioRepository _exercicioRepository;

        public ExercicioService(IExercicioRepository exercicioRepository)
            : base(exercicioRepository)
        {
            _exercicioRepository = exercicioRepository;
        }
    }
}
