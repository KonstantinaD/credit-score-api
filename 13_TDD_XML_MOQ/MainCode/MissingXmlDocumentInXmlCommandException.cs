using System;
using System.Runtime.Serialization;

namespace MainCode
{
    public class MissingXmlDocumentInXmlCommandException : Exception, ISerializable
    {
        public MissingXmlDocumentInXmlCommandException()
        {
            
        }
    }
}

