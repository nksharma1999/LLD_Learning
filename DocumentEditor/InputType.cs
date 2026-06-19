class TextElement(string text) : DocumentElement
{
    private string Text { get; set; } = text;

    public string Render()
    {
        return Text;
    }
}

class ImageElement(string imagePath) : DocumentElement
{
    private string ImagePath { get; set; } = imagePath;

    public string Render()
    {
        return $"[Image: {ImagePath} +]";
    }
}

class NewLineElement() : DocumentElement
{
    public string Render()
    {
        return "\n";
    }
}

class TabSpaceElement() : DocumentElement
{
    public string Render()
    {
        return "\t";
    }
}

class BoldElement(string text) : DocumentElement
{
    private string Text { get; set; } = text;

    public string Render()
    {
        return $"**{Text}**";
    }
}

class ItalicElement(string text) : DocumentElement
{
    private string Text { get; set; } = text;

    public string Render()
    {
        return $"*{Text}*";
    }
}

