using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public static class DocumentsExtensions
    {
        public static string ToHtml(this DocumentPart part)
        {
            var visitor = new ToHtmlVisitor();
            
            return visitor.DynamicVisit(part);
        }

        public static string ToLatex(this DocumentPart part)
        {
            var visitor = new ToLaTeXVisitor();

            return visitor.DynamicVisit(part);
        }

        public static string ToPlainText(this DocumentPart part)
        {
            var visitor = new ToPlainTextVisitor();

            return visitor.DynamicVisit(part);
        }
    }
}
