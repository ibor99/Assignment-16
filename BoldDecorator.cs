namespace Assignment_16
{
    public class BoldDecorator : TextDecorator
    {
        public BoldDecorator(ITextElement textElement) : base(textElement)
        {
        }

        public override string ApplyFormat()
        {
            return "<b>" + _textElement.ApplyFormat() + "</b>";
        }
    }
}
