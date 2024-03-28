using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    public class ItalicDecorator : TextDecorator
    {
        public ItalicDecorator(ITextElement textElement) : base(textElement) { }

        public override string ApplyFormat()
        {
            return "Italic " + _textElement.ApplyFormat();
        }
    }
}
