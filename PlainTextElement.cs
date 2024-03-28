using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    internal class PlainTextElement : ITextElement
    {
        private readonly string _text;

        public PlainTextElement(string text)
        {
            _text = text;
        }

        public string ApplyFormat()
        {
            return _text;
        }
    }
}
