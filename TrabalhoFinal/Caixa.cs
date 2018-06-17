using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    public class Caixa
    {
        private static CaixaC caixa = null;
        public static CaixaC getInstance()
        {
            if(caixa == null)
            {
                caixa = new CaixaC();
            }
            return caixa;
        }
    }
}
