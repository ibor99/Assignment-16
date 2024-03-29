using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    public class TextDecorator : ITextElement
    {
        protected ITextElement _textElement;
        protected string _format;

        public TextDecorator(ITextElement textElement)
        {
            _textElement = textElement;
            _format = "";
        }

        public virtual string ApplyFormat()
        {
            return _format + _textElement.ApplyFormat();
        }

        public virtual void AddFormat(string format)
        {
            _format += format;
        }

        public virtual void RemoveFormat(string format)
        {
            _format = _format.Replace(format, "");
        }
    }
}
