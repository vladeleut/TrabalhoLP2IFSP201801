//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TrabalhoFinal
{
    class Cliente
    {
        int codigo;
        string telefone;
        string nome;
        string logradouro;
        string bairro;
        string complemento = " ";
        string referencia = " ";
        string observacao = " ";
        
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public String Telefone { get { return telefone; } set { telefone = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Logradouro { get { return logradouro; } set { logradouro = value; } }
        public string Complemento { get { return complemento; } set { complemento = value; } }
        public string Referencia { get { return referencia; } set { referencia = value; } }
        public string Observacao { get { return observacao; } set { observacao = value; } }
        public string  Bairro { get { return bairro; } set { bairro = value; } }
    }
}