namespace SOLID
{
    public class Estudantes : IImprimivel
    {
        public List<Estudante> students { get; set; }

        public void Imprimir(Impressor impressora)
        {
            impressora.ImprimeTexto("[\n");

            for (int i = 0; i < students.Count; i++)
            {
                students[i].Imprimir(impressora);
                if (i != students.Count - 1)
                    Console.WriteLine(",\n");                    
            }
            Console.WriteLine("\n]");
        }
    }
}
