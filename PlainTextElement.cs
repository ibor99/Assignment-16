using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_16
{
    internal class PlainTextElement : ITextElement
    {
        private string _text;
        private List<string> _formatOptions;

        public PlainTextElement(string text)
        {
            _text = text;
            _formatOptions = new List<string>();
        }

        public string ApplyFormat()
        {
            return _formatOptions.Count > 0 ? $"[{string.Join(",", _formatOptions)}] {_text}" : _text;
        }

        public void AddFormat(string format)
        {
            _formatOptions.Add(format);
        }

        public void RemoveFormat(string format)
        {
            _formatOptions.Remove(format);
        }
    }
}
