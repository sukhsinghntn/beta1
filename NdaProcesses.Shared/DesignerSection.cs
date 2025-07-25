using System.Collections.Generic;

namespace DynamicFormsApp.Shared
{
    public class DesignerSection
    {
        public string Title { get; set; } = "New Section";
        public string Instructions { get; set; } = string.Empty;
        public bool Collapsed { get; set; }
        public List<DesignerField> Fields { get; set; } = new();
    }
}
