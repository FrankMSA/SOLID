using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Estudante : IImprimivel
    {
        public string name { get; set; }
        public string course { get; set; }
        public bool scholarshipHolder { get; set; }
        public double integratedProjectAverageScore { get; set; }
        public Endereco endereco { get; set; }

        public void Imprimir(Impressor impressora)
        {
            impressora.ImprimeTexto($"'Nome: {name} | Curso: {course} | Média das notas do Projeto Integrado: " +
                $"{integratedProjectAverageScore}' ");
            if (endereco != null)
                endereco.Imprimir(impressora);
        }
        
        public class Endereco : IImprimivel
        {
            public string Rua { get; set; }

            public int Numero { get; set; }

            public void Imprimir (Impressor impressora)
            {
                impressora.ImprimeTexto($"'Rua: {Rua} | Número: {Numero} '\n");
            }
        }
    }
}

