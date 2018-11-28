using No5.Solution.Texts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class ToPlainTextVisitor : DocumentVisitor
    {
        protected override string Visit(BoldText text) => "**" + text.Text + "**";

        protected override string Visit(Hyperlink text) => text.Text + " [" + text.Url + "]";

        protected override string Visit(PlainText text) => text.Text;
    }
}
