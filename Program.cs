// See https://aka.ms/new-console-template for more information
using Assignment_16;



ITextElement textElement = new TextElement("Hello, world!");
FormattedText formattedText = new FormattedText(textElement);

formattedText.AddDecorator(new BoldDecorator(formattedText.TextElement));
formattedText.AddDecorator(new ItalicDecorator(formattedText.TextElement));
formattedText.AddDecorator(new UnderlineDecorator(formattedText.TextElement));
formattedText.AddDecorator(new ColorDecorator(formattedText.TextElement, "red"));

Console.WriteLine(formattedText.ApplyFormat()); // Outputs: <span style="color: red;"><u><i><b>Hello, world!</b></i></u></span>

formattedText.RemoveDecorator(typeof(ItalicDecorator));

Console.WriteLine(formattedText.ApplyFormat()); // Outputs: <span style="color: red;"><u><b>Hello, world!</b></u></span>

formattedText.RemoveDecorator(typeof(ColorDecorator));

Console.WriteLine(formattedText.ApplyFormat()); // Outputs: <u><b>Hello, world!</b></u>