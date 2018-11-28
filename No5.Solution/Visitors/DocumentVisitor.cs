using No5.Solution.Texts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public abstract class DocumentVisitor
    {
        public string DynamicVisit(DocumentPart part)
        => Visit((dynamic)part);
        protected abstract string Visit(BoldText text);
        protected abstract string Visit(Hyperlink text);
        protected abstract string Visit(PlainText text);
    }
}
