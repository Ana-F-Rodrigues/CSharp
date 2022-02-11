using CsvHelper;
using System;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace CursoCSharp.IO
{
    public class EscreverCSV
    {

        public static void Executar()
        {
            //StrinBuilder = usada para modificar uma cadeia de caracteres sem criar um novo objeto.
            // Descendants = Retorna uma coleção dos elementos descendentes desse documento ou elemento, na ordem do documento.
            // Append = Cria um StreamWriter que acrescenta um texto codificado para UTF-8 a um arquivo existente ou a um novo arquivo, se o arquivo especificado não existe.
            StringBuilder sb = new StringBuilder();
            string delimiter = ",";

            XDocument.Load(@"C:\Users\Ana\Desktop\PLANO 2022\CursoCSharp\IO\Dados.xml").Descendants("Desafio").ToList().ForEach(
              element => 
              sb.Append(element.Attribute("Item").Value + delimiter +
                                    element.Element("Nome").Value + delimiter +
                                    element.Element("Descrição").Value + delimiter +
                                    element.Element("Categoria").Value + delimiter +
                                    element.Element("Observação").Value + "\r\n"));

            StreamWriter sw = new StreamWriter(@"C:\Users\Ana\Desktop\PLANO 2022\CursoCSharp\IO\Dados.csv");
            sw.WriteLine(sb.ToString());
            sw.Close();

        }
    }
}

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