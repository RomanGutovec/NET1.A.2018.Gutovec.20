using No5.Solution.Texts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class ToLaTeXVisitor : DocumentVisitor
    {
        protected override string Visit(BoldText text) => "\\textbf{" + text.Text + "}";

        protected override string Visit(Hyperlink text) => "\\href{" + text.Url + "}{" + text.Text + "}";

        protected override string Visit(PlainText text) => text.Text;
    }
}
