using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    public class ColorDecorator : TextDecorator
    {
        private readonly string _color;
        public ColorDecorator(ITextElement textElement, string color) : base(textElement) 
        {
            _color = color;
        }

        public override string ApplyFormat()
        {
            return $"{_color} Color " + _textElement.ApplyFormat();
        }
    }
}
