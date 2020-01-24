using System;
using System.Xml;

namespace MainCode
{
    public class FillBookFieldCommand
    {
        public Book ExecuteFillBookField(XmlNode node, Book book)
        {
            switch (node.Name)
            {
                case "title":
                    book.Title = node.InnerText;
                    break;
                case "author":
                    book.Author = node.InnerText;
                    break;
                case "price":
                    book.Price = node.InnerText;
                    break;
                case "imageurl":
                    book.ImageUrl = node.InnerText;
                    break;
                case "publicationdate":
                    book.PublicationDate = node.InnerText;
                    break;
                case "publisher":
                    book.Publisher = node.InnerText;
                    break;
                default:
                    break;
            }

            return book;
        }
    }

}
