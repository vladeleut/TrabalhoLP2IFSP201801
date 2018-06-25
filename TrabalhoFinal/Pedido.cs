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
        String formaPagto;
        int cliente; //pesquisar no banco o cliente e recuperar dados via cruzamento de tabelas
        String nomeCliente;
        String situacao;
        String bairroCliente;
        String tempo;

        //List<Produto> itens = new List<Produto>();

        public int Nro_pedido { get { return nro_pedido; } set { nro_pedido = value; } }
        public DateTime AberturaPedido { get {return aberturaPedido; } set { aberturaPedido = value; } }
        public DateTime FechamentoPedido { get {return fechamentoPedido; } set { fechamentoPedido = value; } }
        public String FormaPagto { get {return formaPagto; } set { formaPagto = value; } }
        public int Cliente { get { return cliente; } set { cliente = value; } }
        public String NomeCliente { get { return nomeCliente; } set { nomeCliente = value; } }
        public String Situacao { get {return situacao; } set { situacao = value; } }
        //public List<Produto> Itens { get { return Itens; } set { Itens = value; } }
        public String BairroCliente { get { return bairroCliente; } set { bairroCliente = value; } }
        public String Tempo { get { return tempo; } set { tempo = value; } }

    }
}
