using System;
using System.IO;
using System.Text;

namespace LAB9_4HTML
{
    class Header
    {
        public const string Open = "<h1>";
        public const string Close = "</h1>";

        public string CreateHeader(string text)
        {
            string header = String.Concat(Open, text, Close, "\n");
            return header;
        }
    }


    class UnorderedList
    {
        public const string open = "<ul>";
        public const string close = "</ul>";

        public string CreateListItem(string text)
        {
            string Open = "<li>\n";
            string Close = "</li>\n";

            string listItem = String.Concat(Open, text, Close, "\n");
            return listItem;
        }

        public StringBuilder CreateList(string[] listItems)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(open);
            foreach (string item in listItems)
            {
                sb.Append(item);
            }
            sb.Append(close);

            return sb;
        }

    }

    class Paragraph //Paragraph is just extra.
    {
        public const string Open = "<p>";
        public const string Close = "</p>";

        public string CreateParagraph(string text)
        {
            string paragraph = String.Concat(Open, text, Close, "\n");
            return paragraph;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filename = "C://weblogs//9_4Lab.html";
            Header header = new Header();
            UnorderedList list = new UnorderedList();
            Paragraph paragraph = new Paragraph();
            StringBuilder sb = new StringBuilder();
            

            Console.WriteLine("Enter text for HTML header.");
            string headerElement = header.CreateHeader(Console.ReadLine());

            Console.WriteLine("Enter text for HTML paragraph.");
            string paragraphElement = paragraph.CreateParagraph(Console.ReadLine());

            string[] listItems = new string[3];

            for (int i = 0; i < listItems.Length; i++)
            {
                Console.WriteLine("Add another item to the list.");
                listItems[i] = list.CreateListItem(Console.ReadLine());
            }

            StringBuilder listElement = list.CreateList(listItems);
            sb.Append(headerElement);
            sb.Append(paragraphElement);
            sb.Append(listElement.ToString());

            File.AppendAllText(filename, sb.ToString());

        }
    }
}
