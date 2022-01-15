using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class ObterEstudantes
    {
        public Estudantes Buscar()
        {
            LerArquivo leitura = new LerArquivo();
            string conteudoArquivo = leitura.TextoArquivo("dados.json");
            Estudantes estudantes = JsonConvert.DeserializeObject<Estudantes>(conteudoArquivo);
            return estudantes;
        }
    }
}
