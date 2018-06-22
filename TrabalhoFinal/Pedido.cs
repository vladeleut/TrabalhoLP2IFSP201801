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
        DateTime aberturaPedido;
        DateTime fechamentoPedido;
        Cliente cliente;
        float total;
        int formaDePagamento;//1 Dinheiro, 2 Débito, 3 Crédito,...
        List<Produto> itens = new List<Produto>();

   

        Boolean Aberto = false;
        
        //fazer get/set
    }
}
