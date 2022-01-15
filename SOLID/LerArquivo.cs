

namespace SOLID
{
    public class LerArquivo
    {
        public string TextoArquivo(string nomeArquivo)
        {
            string diretorioAtual = Environment.CurrentDirectory;
            string diretorioCompleto = string.Format($"{diretorioAtual}..\\..\\..\\..\\{nomeArquivo}");
            return File.ReadAllText(diretorioCompleto);
        }


    }
}
