﻿using Detetive.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detetive.Business.Business.Interfaces
{
    public interface IAnotacaoLocalBusiness
    {
        AnotacaoLocal Adicionar(int idLocal, int idJogadorSala);
    }
}
