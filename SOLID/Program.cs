using SOLID;

var obterEstudantes = new ObterEstudantes();
Estudantes estudantes = obterEstudantes.Buscar();
var impressora = new Impressora();

impressora.ImprimeEstudante(estudantes);

