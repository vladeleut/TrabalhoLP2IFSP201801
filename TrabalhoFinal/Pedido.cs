using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    class Pedido
    {
        int nro_pedido;
        DateTime data;
        DateTime hora_inicio;
        Cliente cliente;
        List<Produto> itens = new List<Produto>();
        Boolean Aberto = false;
        public int Nro_pedido { get => nro_pedido; set => nro_pedido = value; }
    }
}
