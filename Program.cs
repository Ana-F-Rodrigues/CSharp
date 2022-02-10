using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.OrientacaoObjetos;
using CursoCSharp.IO;

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
                {"Estrutura IF/ELSE/IF - Estruturas De Controle",EstruturaIfElseIf.Executar},
                {"Estrutura SWITCH - Estruturas De Controle",EstruturaSwitch.Executar},
                {"Estrutura WHILE - Estruturas De Controle",EstruturaWhile.Executar},
                {"Estrutura DO WHILE - Estruturas De Controle",EstruturaDoWhile.Executar},
                {"Estrutura FOR - Estruturas De Controle",EstruturaFor.Executar},
                {"Estrutura FOREACH - Estruturas De Controle",EstruturaForeach.Executar},
                {"Usando BREAK - Estruturas De Controle",UsandoBreak.Executar},
                {"Usando CONTINUE- Estruturas De Controle",UsandoContinue.Executar},

                //Classes e Metodos
                {"Membros - Classes e Metodos",Membros.Executar},

                //Orientação a Objeto
                {"Digito Verificador - Orientação a Objetos",DigitoVerificador.Executar},
                {"ArquivoExcel - Orientação a Objetos",LeitorXml.Executar},
                {"ArquivoExcel - Orientação a Objetos",EscreverCSV.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}