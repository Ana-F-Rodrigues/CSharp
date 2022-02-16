using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;

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
                {"Membros - Classes e Métodos",Membros.Executar},
                {"Construtores - Classes e Métodos",Construtores.Executar},
                {"Metodos com Retorno - Classes e Métodos",MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes e Métodos",MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Métodos",AtributosEstaticos.Executar},
                {"Desafio Atributos - Classes e Métodos",DesafioAtributo.Executar},
                {"Params- Classes e Métodos",Params.Executar},
                {"Parametros Nomeados - Classes e Métodos",ParametrosNomeados.Executar},
                {"GetSet - Classes e Métodos",GetSet.Executar},
                {"Props - Classes e Métodos",Props.Executar},
                {"Readonly - Classes e Métodos",Readonly.Executar},
                {"Enum - Classes e Métodos",ExemploEnum.Executar},
                {"Struct - Classes e Métodos",ExemploStruct.Executar},
                {"Struct x Classes - Classes e Métodos",StructVsClasse.Executar},
                {"Valor x Referencia x Classes - Classes e Métodos",ValorVsReferencia.Executar},
                {"Parametros por Referencia - Classes e Métodos",ParametrosPorReferencia.Executar},
                {"Parametro Padrão - Classes e Métodos",ParametroPadra.Executar},
                
                //Coleçoes
                
                {"Array - Coleções",Colecoes.Array.Executar},
                {"Lis - Coleções",ColecoesList.Executar},
                {"Array List - Coleções",ColecoesArrayList.Executar},
                {"ColeçoesSet - Coleções",ColecoesSet.Executar},
                {"Coleçoes Fila- Coleções",ColecoesQueue.Executar},
                {"Igualdade - Coleções",Igualdade.Executar},
                {"Stack - Coleções",ColecaoStack.Executar},
                {"Dictionary - Coleções",ColecaoDictionary.Executar},
               
                 // Orientação a Objeto
                 {"Herança- OO",Heranca.Executar},
                 {"Construtor This- OO",ConstrutorThis.Executar},
                 {"Encapsulamento - OO",OO.Encapsulamento.Executar},
                 {"Polimorfismo - OO",Polimorfismo.Executar},
                 {"Classe Abstract - OO",Abstract.Executar},
                 {"Interfaces- OO",Interface.Executar},
                 {"Sealed- OO",Sealed.Executar},
                 
                 //Metodos e Funçoes
                 {"Exemplo Lambda- Metodos e Funçoes",ExemploLambda.Executar},
                 {"Lambda Como Delegates - Metodos e Funçoes",LambdasDelegate.Executar},
                 {"Usando Delegates - Metodos e Funçoes",UsandoDelegate.Executar},
                 {"Delegates Como Função Anonima - Metodos e Funçoes",DelegateFunAnonima.Executar},
                 {"Delegates Como Parametros - Metodos e Funçoes",DelegatesComoParametros.Executar},
                 {"Metodos de Extensão - Metodos e Funçoes",MetodosDeExtensao.Executar},
                 
                
                //EXCEÇOES
                {"Primeira Exceção - Exceções",PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceções",ExcecoesPersonalizadas.Executar},
               
                //API
                {"Primeiro Arquivo - Usando API",PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Usando API",LendoArquivos.Executar},
                {"Exemplo FileInfo - Usando API",ExemploFileInfo.Executar},
                {"Diretorios - Usando API",Diretorios.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}