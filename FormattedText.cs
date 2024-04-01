namespace Assignment_16;

public class FormattedText
{
    private ITextElement _textElement;
    private LinkedList<TextDecorator> _decorators = new LinkedList<TextDecorator>();

    public ITextElement TextElement
    {
        get { return _textElement; }
        set { _textElement = value; }
    }

    public FormattedText(ITextElement textElement)
    {
        _textElement = textElement;
    }

    public void AddDecorator(TextDecorator decorator)
    {
        decorator.TextElement = _decorators.Count > 0 ? _decorators.Last.Value.TextElement : _textElement;
        _decorators.AddLast(decorator);
    }

    public void RemoveDecorator(Type decoratorType)
    {
        var node = _decorators.First;
        while(node != null)
        {
            if(node.Value.GetType() == decoratorType)
            {
                if(node.Next != null)
                {
                    node.Next.Value.TextElement = node.Value.TextElement;
                }
                _decorators.Remove(node);
                break;
            }
            node = node.Next;
        }
        if (_decorators.Count > 0)
        {
            _decorators.Last.Value.TextElement = _textElement;
        }
    }

    public string ApplyFormat()
    {
        string result = _textElement.ApplyFormat();
        foreach (var decorator in _decorators)
        {
            decorator.TextElement = new TextElement(result);
            result = decorator.ApplyFormat();
        }
        return result;
    }
}
