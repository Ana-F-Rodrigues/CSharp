using System;
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
            var conversor = ConversorXML.MyXmlMapper.Map(@"C:\Users\Ana\Desktop\PLANO 2022\CursoCSharp\IO\Dados.xml");

            Console.WriteLine(conversor.RootTag);
        }

        public static void ExecutarAntigo()
        { 
            //XMLReader = fornece acesso somente de encaminhamento e somente leitura a dados XML
            //XMLReader.Create = cria uma instancia de XMLReader
            //IsStartElement = testa se a tag tem conteudo e se é tag de inicio ou vazia
            //leia.Name = propriedade que obtem o nome da tag
            //ReadElementContentAsString = Lê o elemento atual e retorna o conteúdo como um objeto
            using (XmlReader leia = XmlReader.Create(@"C:\Users\Ana\Desktop\PLANO 2022\CursoCSharp\IO\Dados.xml"))
            {
                while (leia.Read())
                {
                    if (leia.IsStartElement())
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

    

}
