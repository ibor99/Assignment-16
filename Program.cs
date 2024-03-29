// See https://aka.ms/new-console-template for more information
using Assignment_16;


ITextElement textElement = new TextElement("Hello, world!");
textElement.AddFormat("Bold ");
textElement.AddFormat("Italic ");

Console.WriteLine(textElement.ApplyFormat()); // Outputs: Bold Italic Hello, world!

textElement.RemoveFormat("Italic ");

Console.WriteLine(textElement.ApplyFormat()); // Outputs: Bold Hello, world!

ITextElement plainTextElement = new PlainTextElement("Hello, world!");

Console.WriteLine(plainTextElement.ApplyFormat()); // Outputs: Hello, world!

ITextElement decoratedPlainTextElement = new TextDecorator(plainTextElement);
decoratedPlainTextElement.AddFormat("Bold ");

Console.WriteLine(decoratedPlainTextElement.ApplyFormat()); // Outputs: Bold Hello, world!