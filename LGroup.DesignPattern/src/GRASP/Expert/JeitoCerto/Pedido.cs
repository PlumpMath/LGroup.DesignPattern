﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert.JeitoCerto
{
    public class Pedido
    {
        public List<ItemPedido> Itens { get; set; }

        public decimal GetTotal()
        {
            var total = 0M;

            foreach (var item in Itens)
            {
                total += item.TotalParcial();
            }

            return total;
        }
    }
}
