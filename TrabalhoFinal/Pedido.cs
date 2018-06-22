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
        float total;
        int formaDePagamento;//1 Dinheiro, 2 Débito, 3 Crédito,...

        //Falta no banco de dados e DAO esses dois
        Cliente cliente;
        List<Produto> itens = new List<Produto>();

   

        Boolean Aberto = false;

        public int Nro_pedido { get { return nro_pedido; } set { nro_pedido = value; } }
        public DateTime AberturaPedido { get {return aberturaPedido; } set { aberturaPedido = value; } }
        public DateTime FechamentoPedido { get {return fechamentoPedido; } set { fechamentoPedido = value; } }
        public float Total { get {return total; } set { total = value; } }
        public int FormaDePagamento { get {return formaDePagamento; } set { formaDePagamento = value; } }
        internal Cliente Cliente { get {return cliente; } set { cliente = value; } }

       
    }
}
