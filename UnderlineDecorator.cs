using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    public class UnderlineDecorator : TextDecorator
    {
        public UnderlineDecorator(ITextElement textElement) : base(textElement) { }

        public override string ApplyFormat()
        {
            AddFormat("Underline");
            return base.ApplyFormat();
        }

        public override void RemoveFormat(string format)
        {
            if(format == "Underline")
            {
                base.RemoveFormat(format);
            }
        }

    }
}
