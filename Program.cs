using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() 
            {
                 //Fundamentos

                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamnetos", Comentarios.Executar},
                {"VariaveisEContantes- Fundamnetos",VariaveisEConstantes.Executar},
                {"Inferencia - Fundamnetos",Inferencia.Executar},
                {"Interpolação - Fundamnetos",Interpolacao.Executar},
                {"NotacaoPonto - Fundamnetos",NotacaoPonto.Executar},
                {"LendoDados - Fundamnetos",LendoDados.Executar},
                {"FormatandoNumero - Fundamnetos",FormatandoNumero.Executar},
                {"Conversões- Fundamnetos",Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamnetos",OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamnetos",OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamnetos",OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamnetos",OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamnetos",OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamnetos",OperadorTernario.Executar},

                //Estruturas de Controle
                {"Estrutura IF - Estruturas De Controle",EstruturaIf.Executar},
                {"Estrutura IF/ELSE- Estruturas De Controle",EstruturaIfElse.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}