using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    public class CaixaC
    {
        private Boolean isAberto;
        private DateTime abertura;
        private DateTime fechamento;

        public Boolean IsAberto
        {
            get { return isAberto; }
            set { isAberto = value; }
        }

        public DateTime Abertura
        {
            get { return abertura; }
            set { abertura = value; }
        }
        public DateTime Fechamento
        {
            get { return fechamento; }
            set { fechamento = value; }
        }
        public void AbreCaixa()
        {
            if (!isAberto)
            {
                abertura = System.DateTime.Now;
                isAberto = true;
            }
        }

        public void FechaCaixa()
        {
            fechamento = System.DateTime.Now;
            isAberto = false;
            //registrar no banco 
            //passos?
        }






        
        /*
        private float valorTotal;//vamos usar para o valor que está no caixa aberto

        public Boolean IsAberto { get { return isAberto; } set { isAberto = value; } }

        */
    }
}
