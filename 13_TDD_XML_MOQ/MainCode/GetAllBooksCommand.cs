using System.Collections.Generic;
using System.Xml;

namespace MainCode
{
    public class GetAllBooksCommand
    {
        private XmlDocument xmlDocument = null;
        private IMakeList<Book> command = null;

        public GetAllBooksCommand(XmlDocument document, IMakeList<Book> makeListComand)
        {
            this.xmlDocument = document;
            this.command = makeListComand;
        }

        public List<Book> ExecuteGetAllBooks()
        {
            List<Book> list = null;

            if (xmlDocument == null)
            {
                throw new MissingXmlDocumentInXmlCommandException();
            }

            //create the correct filtered node list
            XmlNode foundRecords = xmlDocument.DocumentElement;

            list = this.command.ExecuteMakeListBook(foundRecords);

            return list;
        }
    }
}
