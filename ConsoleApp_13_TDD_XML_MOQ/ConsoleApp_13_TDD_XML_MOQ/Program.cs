using System.Collections.Generic;
using System.Xml;
using MainCode;


namespace ConsoleApp_13_TDD_XML_MOQ
{
    class Program
    {
        static void Main()
        {
            string fileLocation = "books.xml";
            GetAllBooksCommandFactory fac = new GetAllBooksCommandFactory(
               fileLocation, new XmlDocument());

            GetAllBooksCommand cmd = fac.GetCommand();
            List<Book> list = cmd.ExecuteGetAllBooks();
        }
    }
}
