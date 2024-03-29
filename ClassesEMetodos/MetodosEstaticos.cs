﻿using System;


namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica 
    {
        //Significa que o metodo nao pertece ao objeto mas pertence a classe
        //Tem uma unica copia
        public static int Somar (int a, int b) //acesso diretamente sem precisar criar instancia
        {
            return a + b;
        }

        public static int Multiplicar(int a , int b)
        {
            return a * b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine(resultado);

            Console.WriteLine(CalculadoraEstatica.Somar(2,2));
        }
    }
}
