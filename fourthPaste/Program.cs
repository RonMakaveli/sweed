﻿using System; 

namespace fourthPaste
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um Objeto
            Pessoa p = new Pessoa();
            p.peso = 80;
            p.altura = 1.80;
            p.mensagem();
        }
    }
}