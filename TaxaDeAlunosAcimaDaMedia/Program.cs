
List<List<int>> amostraDeNotas = new List<List<int>>()
{
    {
        new List<int> { 50, 50, 70, 80, 100}
    },
    {
        new List<int> { 70, 90, 80}
    },
    {
        new List<int> { 50, 60, 55, 58, 52}
    },
    {
        new List<int> { 20, 100, 70, 30, 40, 15, 85}
    }
};

int numeroDeAmostras = amostraDeNotas.Count();

Console.WriteLine($"O numero de amotras de notas que recebemos foi de {numeroDeAmostras}\n\n");

Console.WriteLine("Vamos calcular as notas acima das medias dentro de cada amostra\n\n");
Thread.Sleep(2000);

foreach (var amostra in amostraDeNotas)
{
    Console.WriteLine($"A amostra de notas atual é: " + string.Join(", ", amostra) + ("\n"));
    Thread.Sleep(3000);

    double mediaDaAmostra = amostra.Average();
    Console.WriteLine($"A média de notas dessa amostra é {mediaDaAmostra:F2}\n");
    Thread.Sleep(3000);

    int notasAcimaMedia = amostra.Count(nota => nota > mediaDaAmostra);

    Console.WriteLine($"O numero de notas acima da media dessa amostra é de: {notasAcimaMedia}\n");
    Thread.Sleep(3000);

    double percentualAcimaDaMedia = (double)notasAcimaMedia / amostra.Count * 100;

    Console.WriteLine($"O percentual de notas dessa amostra que são acima da media dela é de: {percentualAcimaDaMedia:F3}%\n");
    Thread.Sleep(3000);


    Console.WriteLine("Para continuar aperte qualquer tecla...\n\n");
    Console.ReadKey();

    Console.WriteLine("====================================\n\n");
}

Console.WriteLine("Acabaram as amostras. A Aplicação encerrará");
Console.WriteLine("\n Tchau...");
Thread.Sleep(2000);
