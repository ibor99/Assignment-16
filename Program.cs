// See https://aka.ms/new-console-template for more information
using Assignment_16;

Console.WriteLine("Hello, World!");

ITextElement text = new PlainTextElement("Example text.");

text = new ItalicDecorator(new BoldDecorator(new ColorDecorator(text, "Orange")));

Console.WriteLine(text.ApplyFormat().ToString());

text.RemoveFormat("Bold");

Console.WriteLine(text.ApplyFormat());