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

        //Atribuição de dados - Amigo 3
        Console.Write("Digite o nome do seu terceiro amigo: ");
        amigo3.nome = Console.ReadLine();

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

        //Cria as datas dos aniversários de cada amigo
        var aniversario1 = new DateTime(amigo1.ano, amigo1.mes, amigo1.dia);
        var aniversario2 = new DateTime(amigo2.ano, amigo2.mes, amigo2.dia);
        var aniversario3 = new DateTime(amigo3.ano, amigo3.mes, amigo3.dia);

        //Realiza a comparação entre as datas.
        //Retorna um int maior, igual ou menos que 0.
        int comparacao1 = DateTime.Compare(aniversario1, aniversario2);
        int comparacao2 = DateTime.Compare(aniversario2, aniversario3);
        int comparacao3 = DateTime.Compare(aniversario1, aniversario3);
        //comparacao1 < 0 = Amigo 1 mais velho do que Amigo 2
        //comparacao1 > 0 = Amigo 2 mais velho do que Amigo 1
        //comparacao2 < 0 = Amigo 2 mais velho do que Amigo 3
        //comparacao2 > 0 = Amigo 3 mais velho do que Amigo 2
        //comparacao3 < 0 = Amigo 1 mais velho do que Amigo 3
        //comparacao3 > 0 = Amigo 3 mais velho do que Amigo 1

        if (comparacao1 < 0 && comparacao3 < 0){
            Console.WriteLine($"{amigo1.nome} é o mais velho.");
        } else if (comparacao1 > 0 && comparacao2 < 0) {
            Console.WriteLine($"{amigo2.nome} é o mais velho.");
        } else if (comparacao2 > 0 && comparacao3 > 0){
            Console.WriteLine($"{amigo3.nome} é o mais velho.");
        } else if (comparacao1 == 0 && comparacao2 == 0 && comparacao3 == 0){
            Console.WriteLine($"Todos os seus amigos tem idade iguais!");
        }
    }
}