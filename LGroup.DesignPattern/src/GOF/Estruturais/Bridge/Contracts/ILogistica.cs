﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Contracts
{
    public interface ILogistica
    {
        void BaixarEstoque(int idProduto, int qtde);

    }
}
