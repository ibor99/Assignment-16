using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    public class BoldDecorator : TextDecorator
    {
        public BoldDecorator(ITextElement textElement) : base(textElement) { }

        public override string ApplyFormat()
        {
            return "Bold " + _textElement.ApplyFormat();
        }
    }
}
