﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}! Bem-vindo ao mundo C#!");
        }
    }
}
