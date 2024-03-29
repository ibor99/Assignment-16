using Assignment_16;

public class TextElement : ITextElement
{
    private string _text;
    private List<string> _formats;

    public TextElement(string text)
    {
        _text = text;
        _formats = new List<string>();
    }

    public string ApplyFormat()
    {
        return string.Join("", _formats) + _text;
    }

    public void AddFormat(string format)
    {
        _formats.Add(format);
    }

    public void RemoveFormat(string format)
    {
        _formats.Remove(format);
    }
}