using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    public interface ITextElement
    {
        string ApplyFormat();

        void AddFormat(string format);

        void RemoveFormat(string format);
    }
}
