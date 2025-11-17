namespace DynamicFormsApp.Shared
{
    public class DesignerSection
    {
        public string Key { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public bool IsCollapsed { get; set; }
        public List<DesignerRow> Rows { get; set; } = new() { new DesignerRow() };
    }
}
