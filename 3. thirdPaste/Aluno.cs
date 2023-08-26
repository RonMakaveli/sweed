using System;

class Aluno
{
    //Atributos
    public string nome = "";
    public double nota1, nota2;
    //Métodos

    public double media()
    {
        return(nota1+nota2)/2;
    }

    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";
    }

    public void mensagem()
    {
        double obterMedia = media();
        string obterSituacao = situacao(obterMedia);
        Console.WriteLine(nome + " está " + obterSituacao + " com média " + obterMedia);
    }
}