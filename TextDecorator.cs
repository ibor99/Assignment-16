using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    public abstract class TextDecorator : ITextElement
    {
        protected ITextElement _textElement;

        public ITextElement TextElement
        {
            get { return _textElement; }
            set { _textElement = value; }
        }

        public TextDecorator(ITextElement textElement)
        {
            _textElement = textElement;
        }

        public abstract string ApplyFormat();
    }
}
