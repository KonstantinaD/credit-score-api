using System.Xml;
using System.Collections.Generic;

namespace MainCode
{
    public interface IMakeList<T>
    {
        List<T> ExecuteMakeListBook(XmlNode records);
    }

}
