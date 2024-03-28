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
            AddFormat("Italic");
            return base.ApplyFormat();
        }

        public override void RemoveFormat(string format)
        {
            if (format == "Italic")
            {
                base.RemoveFormat(format);
            }
        }
    }
}
