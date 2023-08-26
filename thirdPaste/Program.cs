using System;

namespace thirdPaste
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar Objeto da classe aluno
            Aluno a = new Aluno();
            a.nome = "Robert";
            a.nota1 = 8;
            a.nota2 = 8;
            a.mensagem();
        }
    }
}