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
            var xml = new XmlDocument();
            xml.Load(@"");

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
