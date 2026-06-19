class DocumentEditor(Document document, Persistence storage)
{
    private Document Document = document;
    private Persistence Storage = storage;
    private string RenderedDocument="";

    public void AddText(string text)
    {
        Document.AddElement(new TextElement(text));
    }

    public void AddImage(string imagePath)
    {
        Document.AddElement(new ImageElement(imagePath));
    }

    public void AddNewLine()
    {
        Document.AddElement(new NewLineElement());
    }
    public void AddTabSpace()
    {
        Document.AddElement(new TabSpaceElement());
    }
    public void AddBoldText(string text)
    {
        Document.AddElement(new BoldElement(text));
    }
    public void AddItalicText(string text)
    {
        Document.AddElement(new ItalicElement(text));
    }
    public string RenderDocument()
    {
        RenderedDocument = Document.Render();
        return RenderedDocument;
    }

    public void SaveDocument()
    {
        if (RenderedDocument == null)
        {
            RenderedDocument = Document.Render();
        }
        Storage.Save(RenderedDocument);
    }
}