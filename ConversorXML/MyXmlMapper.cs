using System;
using System.IO;
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

        /// <summary>
        /// Executa o mapeamento de um XML
        /// </summary>
        /// <param name="xmlFilepath">Caminho completo do xml</param>
        public static MyXmlMapper Map(string xmlFilepath)
        {
            var fileInfo = new FileInfo(xmlFilepath);

            if (!fileInfo.Exists)
                throw new InvalidOperationException("O arquivo xml não existe!");

            if(fileInfo.Extension.ToUpperInvariant() != "XML")
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
            var xml = new XmlDocument();
            xml.Load(xmlFile.OpenRead());

            this.RootTag = xml.DocumentElement.Name;

            if (xml.DocumentElement.HasChildNodes)
                this.EntityTag = xml.DocumentElement.FirstChild.Name;

        }
    }

    
}
