using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    public abstract class TextDecorator : ITextElement
    {
        protected readonly ITextElement _textElement;

        public TextDecorator(ITextElement textElement)
        {
            _textElement = textElement;
        }

        public abstract string ApplyFormat();
    }
}
