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

        public virtual string ApplyFormat()
        {
            return _textElement.ApplyFormat();
        }

        public virtual void AddFormat(string format)
        {
            _textElement.AddFormat(format);
        }

        public virtual void RemoveFormat(string format) 
        {
            _textElement.RemoveFormat(format);
        }
    }
}
