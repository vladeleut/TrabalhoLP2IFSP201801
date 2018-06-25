using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    class Produto
    {
        int codigo;
        string nome;
        string tipo;
        string preco;
        float qtde; //usamos na lista de itens do pedido

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Tipo { get {return tipo; } set { tipo = value; } }
        public string Preco { get { return preco; } set { preco = value; } }
        public float Qtde { get { return qtde; } set { qtde = value; } }
    }
}
