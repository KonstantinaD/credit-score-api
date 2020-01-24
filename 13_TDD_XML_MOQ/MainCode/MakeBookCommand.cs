using System.Xml;

namespace MainCode
{
    public class MakeBookCommand
    {
        public Book ExecuteMakeBook(XmlNode completeRecord, Book book)
        {
            FillBookFieldCommand cmd = new FillBookFieldCommand();

            foreach (XmlNode node in completeRecord.ChildNodes)
            {
                cmd.ExecuteFillBookField(node, book);
            }

            return book;
        }
    }
}
