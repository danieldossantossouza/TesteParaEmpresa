// See https://aka.ms/new-console-template for more information
using TesteEmpresa;

Console.WriteLine("Hello, World!");


var alunos = descerializar.executar();

for (int i = 0; i < alunos.Length; i++)
{
    var alun = alunos[i];
    var quantNota = alun.notas.Length;
    var soma = alun.notas.Sum();

    var media = soma / quantNota;
    alun.media = media;
    //Console.WriteLine("A média do aluno {0} é {1} ", alun.nome, media);
}

var mediaGeral = alunos.Sum(x => x.media) / alunos.Length;

Console.WriteLine("A meidia geral é {0}. ", mediaGeral.ToString("N2"));

foreach (var alun in alunos.OrderByDescending(x=> x.media)) {

    Console.WriteLine(" {0}: {1} ",alun.nome,alun.media.ToString("N2"));
}







