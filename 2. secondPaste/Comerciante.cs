using System;

class Comerciante
{

    //Método01 
    public void apresentar()
    {
        Console.WriteLine("Olá!");
    }

    //Método02
    public void apresentar(string nome)
    {
        Console.WriteLine("Olá!" + nome);
    }

    //Método03
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Olá " + nome + ", sua idade é " + idade);
    }
}