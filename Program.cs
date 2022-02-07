using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
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
            });

            central.SelecionarEExecutar();
        }
    }
}