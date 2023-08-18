using System;

class Amigo
{
    public string nome {get; set;}
    public int dia {get; set;}
    public int mes {get; set;}
    public int ano {get; set;}
}

internal class Program
{
    static void Main(string[] args)
    {   
        //Limpa alertas do console quando a compilação é bem sucedida.
        Console.Clear();

        //Construção do amigo 1, 2 e 3
        Amigo amigo1 = new Amigo();
        Amigo amigo2 = new Amigo();
        Amigo amigo3 = new Amigo();

        //Atribuição de dados - Amigo 1
        Console.Write("Digite o nome do seu primeiro amigo: ");
        amigo1.nome = Console.ReadLine();

        Console.Write("Digite o dia de nascimento do seu primeiro amigo: ");
        string diaString1 = Console.ReadLine();
        amigo1.dia = int.Parse(diaString1);

        Console.Write("Digite o mês de nascimento do seu primeiro amigo: ");
        string mesString1 = Console.ReadLine();
        amigo1.mes = int.Parse(mesString1);

        Console.Write("Digite o ano de nascimento do seu primeiro amigo: ");
        string anoString1 = Console.ReadLine();
        amigo1.ano = int.Parse(anoString1);
        Console.WriteLine();

        //Atribuição de dados - Amigo 2
        Console.Write("Digite o nome do seu segundo amigo: ");
        amigo2.nome = Console.ReadLine();

        Console.Write("Digite o dia de nascimento do seu segundo amigo: ");
        string diaString2 = Console.ReadLine();
        amigo2.dia = int.Parse(diaString2);

        Console.Write("Digite o mês de nascimento do seu segundo amigo: ");
        string mesString2 = Console.ReadLine();
        amigo2.mes = int.Parse(mesString2);

        Console.Write("Digite o ano de nascimento do seu segundo amigo: ");
        string anoString2 = Console.ReadLine();
        amigo2.ano = int.Parse(anoString2);
        Console.WriteLine();

        //Atribuição de dados - Amigo 2
        Console.Write("Digite o nome do seu terceiro amigo: ");
        amigo2.nome = Console.ReadLine();

        Console.Write("Digite o dia de nascimento do seu terceiro amigo: ");
        string diaString3 = Console.ReadLine();
        amigo3.dia = int.Parse(diaString3);

        Console.Write("Digite o mês de nascimento do seu terceiro amigo: ");
        string mesString3 = Console.ReadLine();
        amigo3.mes = int.Parse(mesString3);

        Console.Write("Digite o ano de nascimento do seu terceiro amigo: ");
        string anoString3 = Console.ReadLine();
        amigo3.ano = int.Parse(anoString3);
        Console.WriteLine();

        var aniversario1 = new DateOnly(amigo1.ano, amigo1.mes, amigo1.dia);
        var aniversario2 = new DateOnly(amigo2.ano, amigo2.mes, amigo2.dia);
        var aniversario3 = new DateOnly(amigo3.ano, amigo3.mes, amigo3.dia);

        Console.WriteLine($"A data de aniversário do primeiro amigo é {aniversario1}");
        Console.WriteLine($"A data de aniversário do segundo amigo é {aniversario2}");
        Console.WriteLine($"A data de aniversário do terceiro amigo é {aniversario3}");
    }
}