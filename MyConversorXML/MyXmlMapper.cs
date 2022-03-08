using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace ConversorXML
{
    /// <summary>
    /// Mapeador do arquivo XML
    /// </summary>
    public class MyXmlMapper
    {
        private readonly FileInfo xmlFile;

        private MyXmlMapper(FileInfo xmlFile)
        {
            this.xmlFile = xmlFile;
        }

        /// <summary>
        /// Nó raiz do XML
        /// </summary>
        public string RootTag { get; private set; }

        /// <summary>
        /// Nó da entidade do XML
        /// </summary>
        public string EntityTag { get; private set; }

        public string[] Headers { get; private set; }

        /// <summary>
        /// Executa o mapeamento de um XML
        /// </summary>
        /// <param name="xmlFilepath">Caminho completo do xml</param>
        public static MyXmlMapper Map(string xmlFilepath)
        {
            var fileInfo = new FileInfo(xmlFilepath);

            if (!fileInfo.Exists)
                throw new InvalidOperationException("O arquivo xml não existe!");

            if(fileInfo.Extension.ToUpperInvariant() != ".XML")
                throw new InvalidOperationException("O arquivo informado não é um XML!");

            var mapper = new MyXmlMapper(fileInfo);

            mapper.Load();

            return mapper;
        }

        /// <summary>
        /// Carrega a estrutura do XML no mapeador
        /// </summary>
        private void Load()
        {
            var xml = OpenXmlFile();

            this.RootTag = xml.DocumentElement.Name;

            if (xml.DocumentElement.HasChildNodes)
            {
                var firstElement = xml.DocumentElement.FirstChild;

                this.EntityTag = firstElement.Name;
                this.Headers = ExtractHeaders(firstElement);
            }
        }

        internal XmlDocument OpenXmlFile()
        {
            var xml = new XmlDocument();
            xml.Load(xmlFile.OpenRead());

            return xml;
        }

        private string[] ExtractHeaders(XmlNode firstElement)
        {
            var list = new List<string>();

            foreach (XmlNode item in firstElement.ChildNodes)
                list.Add(item.Name);

            return list.ToArray();
        }
    }

    public class MyXmlToCsvWriter
    {
        private readonly MyXmlMapper mapper;

        public MyXmlToCsvWriter(MyXmlMapper mapper)
        {
            this.mapper = mapper;
        }

        public bool WriteCsvFile(string csvFileName)
        {
            // Passo 1: Verificar existencia do arquivo. Caso exista, deletar o arquivo.
            var file = CheckCsvFileExists(csvFileName);

            // Passo 2: Escrever o cabeçalho na primeira linha do arquivo
            using (var streamWriter = OpenXmlFileAndWriteHeaders(file))
            {
                // Passo 3: Escrever o conteúdo
                WriteContent(streamWriter);
            }

            return true;
        }

        private void WriteContent(StreamWriter csvFileWriter)
        {
            // Passo 1: Abrir arquivo Xml
            var xml = mapper.OpenXmlFile();

            // Passo 2: Ler conteúdo XML e escrever no arquivo Csv
            foreach(XmlElement node in xml.DocumentElement.GetElementsByTagName(mapper.EntityTag))
            {
                WriteContentFromHeaders(csvFileWriter, node);

                csvFileWriter.WriteLine();
            }
        }

        private void WriteContentFromHeaders(StreamWriter csvFileWriter, XmlElement node)
        {
            var firstHeaderRead = false;

            foreach (var header in mapper.Headers)
            {
                if (!firstHeaderRead)
                    firstHeaderRead = true;
                else
                    csvFileWriter.Write(';');

                var childNode = node.GetElementsByTagName(header);

                if (childNode.Count > 0)
                {
                    csvFileWriter.Write(childNode[0].InnerText);
                }
            }
        }

        private StreamWriter OpenXmlFileAndWriteHeaders(FileInfo csvFile)
        {
            var text = String.Join(';', mapper.Headers);

            var stream = new StreamWriter(csvFile.OpenWrite());
            stream.WriteLine(text.ToString());

            return stream;
        }

        private FileInfo CheckCsvFileExists(string csvFileName)
        {
            var file = new FileInfo(csvFileName);

            if (file.Exists)
                file.Delete();

            return file;
        }
    }
}
