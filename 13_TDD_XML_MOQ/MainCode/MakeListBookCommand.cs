using System.Collections.Generic;
using System.Xml;

namespace MainCode
{
    public class MakeListBookCommand : IMakeList<Book>
    {
        public List<Book> ExecuteMakeListBook(XmlNode records)
        {
            List<Book> list = null;

            if (records.ChildNodes.Count > 0)
            {
                list = new List<Book>();
                MakeBookCommand cmd = new MakeBookCommand();

                foreach (XmlNode node in records.ChildNodes)
                {
                    list.Add(cmd.ExecuteMakeBook(node, new Book()));
                }
            }

            return list;
        }
    }
}
