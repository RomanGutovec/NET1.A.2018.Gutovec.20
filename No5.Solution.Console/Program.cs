using System.Collections.Generic;
using No5.Solution.Texts;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var documents = new List<DocumentPart>()
            {
                new BoldText() { Text = "TextBold" },
                new Hyperlink() { Text = "Hyperlink", Url = "https://github.com" },
                new PlainText() { Text = "PlainText" }
            };

            foreach (var item in documents)
            {
                System.Console.WriteLine(item.ToHtml());
                System.Console.WriteLine(item.ToLatex());
                System.Console.WriteLine(item.ToPlainText());
            }

            System.Console.ReadLine();
        }
    }
}