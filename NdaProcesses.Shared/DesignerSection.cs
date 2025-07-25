namespace DynamicFormsApp.Shared
{
    public class DesignerSection
    {
        public string Title { get; set; } = "Section";
        public string Instructions { get; set; } = string.Empty;
        public bool IsCollapsed { get; set; }
        public List<DesignerRow> Rows { get; set; } = new() { new DesignerRow() };
    }
}
