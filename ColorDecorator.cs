namespace Assignment_16;

public class ColorDecorator : TextDecorator
{
    private string _color;

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public ColorDecorator(ITextElement textElement, string color) : base(textElement)
    {
        _color = color;
    }

    public override string ApplyFormat()
    {
        return $"<span style=\"color: {_color};\">" + _textElement.ApplyFormat() + "</span>";
    }
}
