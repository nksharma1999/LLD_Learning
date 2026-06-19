class DocumentEditorMain
{
    private Document document = new Document();
    private Persistence storage = new FileStorage("document.txt");
    private DocumentEditor? editor = null;

    public void Run()
    {
        editor = new DocumentEditor(document, storage);

        editor.AddText("Hello, World!");
        editor.AddNewLine();
        editor.AddBoldText("This is bold text.");
        editor.AddNewLine();
        editor.AddItalicText("This is italic text.");
        editor.AddNewLine();
        editor.AddImage("image.png");
        editor.AddNewLine();
        editor.AddTabSpace();
        editor.AddText("Indented text.");

        string renderedDocument = editor.RenderDocument();
        Console.WriteLine("Rendered Document:");
        Console.WriteLine(renderedDocument);

        editor.SaveDocument();
    }
}