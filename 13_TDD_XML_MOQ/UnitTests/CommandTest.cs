using System;
using NUnit.Framework;
using System.Xml;
using MainCode;
using System.Collections.Generic;
using Moq;

namespace UnitTests
{
    [TestFixture]
    public class CommandTest
    {
        [TestCase("title", "Expected title")]
        public void Test_FillBookFieldCommand_Given_NodeWithTitle_Returns_BookWithTitle(string testName, string expectedTitle)
        {  //arrange
            string namespaceURI = String.Empty;
            XmlDocument doc = new XmlDocument();
            XmlNode testNode = doc.CreateNode(XmlNodeType.Element, testName, namespaceURI);
            testNode.InnerText = expectedTitle;

            //act
            var cmd = new FillBookFieldCommand();
            var actual = cmd.ExecuteFillBookField(testNode, new Book());

            //assert
            Assert.IsInstanceOf<Book>(actual);
            Assert.AreEqual(expectedTitle, actual.Title);
        }

        [TestCase("author", "Expected author")]
        public void Test_FillBookFieldCommand_Given_NodeWithAuthor_Returns_BookWithAuthor
      (string testAuthor, string expectedAuthor)
        {
            //arrange
            string namespaceURI = String.Empty;
            XmlDocument doc = new XmlDocument();
            XmlNode testNode = doc.CreateNode(XmlNodeType.Element, testAuthor, namespaceURI);
            testNode.InnerText = expectedAuthor;

            //act
            var cmd = new FillBookFieldCommand();
            var actual = cmd.ExecuteFillBookField(testNode, new Book());

            //assert
            Assert.IsInstanceOf<Book>(actual);
            Assert.AreEqual(expectedAuthor, actual.Author);
        }

        [Test]
        public void Test_MakeBookCommand_Given_CompleteBookNode_Returns_Book_With_AllProperties()
        {
            //arrange
            string expectedTitle = "Expected Title";
            string expectedAuthor = "Expected Author";
            //build a test document containing a node 
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(String.Format(
               "<books><book><title>{0}</title><author>{1}</author></book></books>",
               expectedTitle, expectedAuthor));
            XmlNode rootNode = xmlDocument.DocumentElement;
            XmlNode testNode = rootNode.SelectSingleNode(
            String.Format(@"/books/book[title='{0}']", expectedTitle));

            //act
            var cmd = new MakeBookCommand();
            var actual = cmd.ExecuteMakeBook(testNode, new Book());

            //assert
            Assert.IsInstanceOf<Book>(actual);
            Assert.AreEqual(expectedTitle, actual.Title);
            Assert.AreEqual(expectedAuthor, actual.Author);
        }

        [Test]
        public void Test_MakeListBookCommand_Given_NodeSet_Returns_ListBook()
        {
            //arrange
            //build a test node 
            string expectedTitle = "Expected Title";
            string expectedAuthor = "Expected Author";
            int expectedListCount = 1;
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(String.Format(
               "<books><book><title>{0}</title><author>{1}</author></book></books>",
               expectedTitle, expectedAuthor));

            XmlNode rootNode = xmlDocument.DocumentElement;
            XmlNode testNode = rootNode.SelectSingleNode(String.Format(@"/books"));

            //act
            var cmd = new MakeListBookCommand();
            var actual = cmd.ExecuteMakeListBook(testNode);

            //assert
            Assert.IsInstanceOf<List<Book>>(actual);
            Assert.AreEqual(expectedListCount, actual.Count);
            Assert.AreEqual(expectedTitle, actual[0].Title);
        }

        [Test]
        public void Test_Performs_MakeListBookCommand_Execute_WithCorrectArgument()
        {
            //arrange
            string namespaceURI = String.Empty;
            string expectedTitle = "Expected Title";
            string expectedAuthor = "Expected Author";
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(String.Format(
               "<books><book><title>{0}</title><author>{1}</author></book></books>",
               expectedTitle, expectedAuthor));

            //needed for the mock setup
            XmlElement rootElement = xmlDocument.DocumentElement;
            XmlNode testNode = rootElement.SelectSingleNode(String.Format(@"/books"));

            Mock<IMakeList<Book>> mockMakeListBookCommand = new Mock<IMakeList<Book>>();
            mockMakeListBookCommand.Setup(c => c.ExecuteMakeListBook(testNode));
            GetAllBooksCommand cmd = new GetAllBooksCommand(xmlDocument,
               mockMakeListBookCommand.Object);

            //act
            var actual = cmd.ExecuteGetAllBooks();

            //assert - prove
            mockMakeListBookCommand.Verify(c => c.ExecuteMakeListBook(testNode), Times.Once());
        }

        [Test]
        public void GetAllBooksCommand_When_NoXmlDocumentProvided_Throws_MissingXmlDocumentInXMLCommandException()
        {
            //Arrange
            int exceptions = 0;

            //Act
            try
            {
                GetAllBooksCommand cmd = new GetAllBooksCommand(null, new MakeListBookCommand());
                var actual = cmd.ExecuteGetAllBooks();
            }
            catch (MissingXmlDocumentInXmlCommandException) { exceptions++; }

            //Assert
            Assert.AreEqual(1, exceptions);
        }

        [Test]
        public void GetAllBooksCommandFactory_Returns_Type_GetAllBooksCommand()
        {
            //arrange
            string testFileName = It.IsAny<string>();
            Mock<XmlDocument> mockXMLDocument = new Mock<XmlDocument>();

            //act
            GetAllBooksCommandFactory fac = new GetAllBooksCommandFactory(testFileName, mockXMLDocument.Object);
            var actual = fac.GetCommand();

            //assert
            Assert.IsInstanceOf<GetAllBooksCommand>(actual);
        }

        [Test]
        public void GetAllBooksCommandFactory_Loads_XMLDocument_Using_FilePath()
        {
            //arrange
            string testFileName = It.IsAny<string>();
            Mock<XmlDocument> mockXMLDocument = new Mock<XmlDocument>();
            mockXMLDocument.Setup(d => d.Load(testFileName));

            //act
            GetAllBooksCommandFactory fac = new GetAllBooksCommandFactory(testFileName,
               mockXMLDocument.Object);
            var actual = fac.GetCommand();

            //assert
            mockXMLDocument.Verify(d => d.Load(testFileName), Times.Once());
        }

        [TestCase("price", "Expected price")]
        public void Test_FillBookFieldCommand_Given_NodeWithPrice_Returns_BookWithPrice
      (string testPrice, string expectedPrice)
        {
            //arrange
            string namespaceURI = String.Empty;
            XmlDocument doc = new XmlDocument();
            XmlNode testNode = doc.CreateNode(XmlNodeType.Element, testPrice, namespaceURI);
            testNode.InnerText = expectedPrice;

            //act
            var cmd = new FillBookFieldCommand();
            var actual = cmd.ExecuteFillBookField(testNode, new Book());

            //assert
            Assert.IsInstanceOf<Book>(actual);
            Assert.AreEqual(expectedPrice, actual.Price);
        }

        [TestCase("imageurl", "Expected imageurl")]
        public void Test_FillBookFieldCommand_Given_NodeWithImageUrl_Returns_BookWithImageUrl
              (string testUrl, string expectedUrl)
        {
            //arrange
            string namespaceURI = String.Empty;
            XmlDocument doc = new XmlDocument();
            XmlNode testNode = doc.CreateNode(XmlNodeType.Element, testUrl, namespaceURI);
            testNode.InnerText = expectedUrl;

            //act
            var cmd = new FillBookFieldCommand();
            var actual = cmd.ExecuteFillBookField(testNode, new Book());

            //assert
            Assert.IsInstanceOf<Book>(actual);
            Assert.AreEqual(expectedUrl, actual.ImageUrl);
        }

        [TestCase("publicationdate", "Expected publicationdate")]
        public void Test_FillBookFieldCommand_Given_NodeWithPublicationDate_Returns_BookWithPublicationDate
              (string testPublicationDate, string expectedPublicationDate)
        {
            //arrange
            string namespaceURI = String.Empty;
            XmlDocument doc = new XmlDocument();
            XmlNode testNode = doc.CreateNode(XmlNodeType.Element, testPublicationDate, namespaceURI);
            testNode.InnerText = expectedPublicationDate;

            //act
            var cmd = new FillBookFieldCommand();
            var actual = cmd.ExecuteFillBookField(testNode, new Book());

            //assert
            Assert.IsInstanceOf<Book>(actual);
            Assert.AreEqual(expectedPublicationDate, actual.PublicationDate);
        }

        [TestCase("publisher", "Expected publisher")]
        public void Test_FillBookFieldCommand_Given_NodeWithPublisher_Returns_BookWithPublisher
                     (string testPublisher, string expectedPublisher)
        {
            //arrange
            string namespaceURI = String.Empty;
            XmlDocument doc = new XmlDocument();
            XmlNode testNode = doc.CreateNode(XmlNodeType.Element, testPublisher, namespaceURI);
            testNode.InnerText = expectedPublisher;

            //act
            var cmd = new FillBookFieldCommand();
            var actual = cmd.ExecuteFillBookField(testNode, new Book());

            //assert
            Assert.IsInstanceOf<Book>(actual);
            Assert.AreEqual(expectedPublisher, actual.Publisher);
        }

        [TestCase("other", null)]
        public void Test_FillBookFieldCommand_Given_NodeWithinDefaultCase_Returns_Null
                     (string testDefaultCase, string expectedDefaultCase)
        {
            //arrange
            string namespaceURI = String.Empty;
            XmlDocument doc = new XmlDocument();
            XmlNode testNode = doc.CreateNode(XmlNodeType.Element, testDefaultCase, namespaceURI);
            testNode.InnerText = expectedDefaultCase;

            //act
            var cmd = new FillBookFieldCommand();
            var actual = cmd.ExecuteFillBookField(testNode, new Book());

            //assert
            Assert.IsInstanceOf<Book>(actual);
            Assert.AreEqual(expectedDefaultCase, null);
        }
    }
}
   