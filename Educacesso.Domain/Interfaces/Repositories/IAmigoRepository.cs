﻿using Educacesso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacesso.Domain.Interfaces.Repositories
{
    public interface IAmigoRepository : IRepositoryBase<Amigo>
    {

        List<Amigo> ListaAmigosDoUsuario(List<AmigoUsuario> ListaAmigoDoUsuario);
        int addAmigo(UserIdentity usuario);
    }
}
