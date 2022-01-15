using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Impressora : Impressor
    {
        public void ImprimeTexto(string texto)
        {
            Console.Write(texto);
        }

        public void ImprimeEstudante(IImprimivel objetoImprimivel)
        {
            objetoImprimivel.Imprimir(this);
           
        }
    }
}
