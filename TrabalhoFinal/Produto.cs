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

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Preco { get => preco; set => preco = value; }
    }
}
