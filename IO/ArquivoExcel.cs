using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CursoCSharp.IO
{
    /// <summary>
    /// DESAFIO: Converter um arquivo XML para formato CSV
    /// 
    /// XML a ser utilizado:
    /// </summary>

    public class LeitorXml
    {
        public static void Executar()
        {
            //XMLReader = fornece acesso somente de encaminhamento e somente leitura a dados XML
            //XMLReader.Create = cria uma instancia de XMLReader
            //IsStartElement = testa se a tag tem conteudo e se é tag de inicio ou vazia
            //leia.Name = propriedade que obtem o nome da tag
            //ReadElementContentAsString = Lê o elemento atual e retorna o conteúdo como um objeto
            using (XmlReader leia = XmlReader.Create(@"C:\Users\Ana\Desktop\PLANO 2022\CursoCSharp\IO\Dados.xml"))
            {
                while(leia.Read())
                {
                    if(leia.IsStartElement())
                    {
                        switch (leia.Name)
                        {
                            case "Nome":
                                Console.WriteLine("Nome: " + leia.ReadElementContentAsString());
                                break;
                            case "Descricao":
                                Console.WriteLine("Descrição: " + leia.ReadElementContentAsString());
                                break;
                            case "Categoria":
                                Console.WriteLine("Categoria: " + leia.ReadElementContentAsString());
                                break;
                            case "Observacao":
                                Console.WriteLine("Observação: " + leia.ReadElementContentAsString());
                                break;
                        }

                    }
                }
                Console.WriteLine("");

                Console.ReadKey();
            }
        } 
    }

    public class EscreverCSV
    {

        public static void Executar()
        {
            // Namespace: System.IO
            // Objetos:
            // File: Fornece métodos estáticos para a criação, cópia, exclusão, deslocamento e abertura de um arquivo, além de ajudar na criação de objetos FileStream.
            // FileInfo: Fornece propriedades e métodos de instância para a criação, cópia, exclusão, deslocamento e abertura de arquivos, além de ajudar na criação de objetos FileStream. Essa classe não pode ser herdada.
            // Directory: Expõe métodos estáticos para criar, mover e enumerar em diretórios e subdiretórios. Essa classe não pode ser herdada.
            // Path: Executa operações em instâncias de String que contêm informações de caminho de arquivo ou diretório. Essas operações são executadas de uma maneira em plataforma cruzada.
            // Stream: Fornece uma exibição genérica de uma sequência de bytes. Esta é uma classe abstrata.
            // StringWriter (escrever o arquivo): Implementa um TextWriter para gravar informações em uma cadeia de caracteres. As informações são armazenadas em um StringBuilder subjacente.
            // StringReader :mplementa um TextReader lido de uma cadeia de caracteres.
            //TextReader: Representa um leitor que pode ler uma série sequencial de caracteres.
            //TextWriter: Representa um gravador que pode gravar uma série sequencial de caracteres.Esta classe é abstrata.
            //FileStream: Fornece um Stream para um arquivo, dando suporte a operações de leitura e gravação síncronas e assíncronas.



        }
    }

}
