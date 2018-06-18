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
        string telefone;
        string nome;
        string logradouro;
        int numero;
        string complemento;
        string referencia;
        string observacao;
        /*
        public Cliente(long telefone, string nome, string logradouro, int numero)
        {
            this.telefone = telefone;
            this.nome = nome;
            this.logradouro = logradouro;
            this.numero = numero;
        }
        */
        public String Telefone { get { return telefone; } set { telefone = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Logradouro { get { return logradouro; } set { logradouro = value; } }
        public int Numero { get { return numero; } set { numero = value; } }
        public string Complemento { get { return complemento; } set { complemento = value; } }
        public string Referencia { get { return referencia; } set { referencia = value; } }
        public string Observacao { get { return observacao; } set { observacao = value; } }
    }
}