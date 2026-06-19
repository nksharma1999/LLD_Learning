class Document
{
    private List<DocumentElement> elements = new List<DocumentElement>();

    public void AddElement(DocumentElement element)
    {
        elements.Add(element);
    }

    public string Render()
    {
        string result = "";
        foreach (var element in elements)
        {
            result += element.Render();
        }
        return result;
    }
}