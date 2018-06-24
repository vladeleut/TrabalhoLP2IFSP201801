using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    class ItemPedido
    {
        int cod_produto;
        int qtde_produto;

        public int Cod_produto { get => cod_produto; set => cod_produto = value; }
        public int Qtde_produto { get => qtde_produto; set => qtde_produto = value; }
    }
}
