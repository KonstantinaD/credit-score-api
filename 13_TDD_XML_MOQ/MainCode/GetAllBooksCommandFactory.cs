using System.Xml;

namespace MainCode
{
    public class GetAllBooksCommandFactory
    {
        private XmlDocument xmlDocument = null;
        private string fileName = null;

        public GetAllBooksCommandFactory(string filePathAndName, XmlDocument XmlDocument)
        {
            this.fileName = filePathAndName;
            this.xmlDocument = XmlDocument;
        }

        public GetAllBooksCommand GetCommand()
        {
            xmlDocument.Load(fileName);

            return new GetAllBooksCommand(xmlDocument, new MakeListBookCommand());
        }
    }

}
