namespace Assignment_16
{
    public class ItalicDecorator : TextDecorator
    {
        public ItalicDecorator(ITextElement textElement) : base(textElement)
        {
        }

        public override string ApplyFormat()
        {
            return "<i>" + _textElement.ApplyFormat() + "</i>";
        }
    }
}
