using System;

class Amigo
{
    public string nome {get; set;}
    public int dia {get; set;}
    public int mes {get; set;}
    public int ano {get; set;}

    public var aniversario = new DateTime(ano, mes, dia);
}

internal class Program
{
    static void Main(string[] args)
    {   
        //Construção do amigo 1
        Amigo amigo1 = new Amigo();

        Console.Write("Digite o nome do seu primeiro amigo: ");
        string nome1 = Console.ReadLine();
        amigo1.nome = nome1;
        Console.WriteLine($"O nome captado foi {amigo1.nome}");

        Console.Write("Digite o dia de nascimento do seu primeiro amigo: ");
        string diaString1 = Console.ReadLine();
        amigo1.dia = int.Parse(diaString1);
        Console.WriteLine($"O dia captado foi {amigo1.dia}");

        Console.Write("Digite o mês de nascimento do seu primeiro amigo: ");
        string mesString1 = Console.ReadLine();
        amigo1.mes = int.Parse(mesString1);
        Console.WriteLine($"O mês captado foi {amigo1.mes}");

        Console.Write("Digite o ano de nascimento do seu primeiro amigo: ");
        string anoString1 = Console.ReadLine();
        amigo1.ano = int.Parse(anoString1);
        Console.WriteLine($"O ano captado foi {amigo1.ano}");

        
        
        //var dia1 = int.Parse(diaString1);
        //var mes1 = int.Parse(mesString1);
        //var ano1 = int.Parse(anoString1);      
    }
}