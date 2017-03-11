﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.JeitoCerto
{
    public interface IAssalariado:IFuncionario
    {
        decimal SalarioFixo { get; set; }
        void SairDeFerias();

    }
}
