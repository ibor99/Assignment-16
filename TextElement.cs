using Assignment_16;

public class TextElement : ITextElement
{
    private string _text;

    public TextElement(string text)
    {
        _text = text;
    }

    public virtual string ApplyFormat()
    {
        return _text;
    }
}