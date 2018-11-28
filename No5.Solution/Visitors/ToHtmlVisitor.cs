using No5.Solution.Texts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class ToHtmlVisitor : DocumentVisitor
    {
        protected override string Visit(BoldText text) => "<b>" + text.Text + "</b>";
  
        protected override string Visit(PlainText text) => text.Text;
    
        protected override string Visit(Hyperlink text) => "<a href=\"" + text.Url + "\">" + text.Text + "</a>";
    }
}
