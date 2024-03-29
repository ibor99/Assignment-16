using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_16
{
    public class PlainTextElement : ITextElement
    {
        private string _text;

        public PlainTextElement(string text)
        {
            _text = text;
        }

        public string ApplyFormat()
        {
            return _text;
        }

        public void AddFormat(string format)
        {
            // Do nothing, as plain text elements cannot have formats
        }

        public void RemoveFormat(string format)
        {
            // Do nothing, as plain text elements cannot have formats
        }
    }

}
