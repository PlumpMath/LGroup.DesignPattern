﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubistutionPeinciple.JeitoCerto
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }

        public abstract string GetDocumento();
    }
}
