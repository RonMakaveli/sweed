using System;

namespace firstPaste
{
    class Program
    {
        static void Main(string[] args)
        {
            Comerciante obj = new Comerciante();
            obj.nome = "Raffa Moreira";
            obj.idade = 23;
            obj.mensagem();
        }
    }
}