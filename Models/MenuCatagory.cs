namespace LTP.Static.Models
{
    public class MenuCatagory
    {
        public required string Name { get; set; }
        public string Subtitle { get; set; } = "";
        public string OptionName { get; set; } = "";
        public string[] Options { get; set; } = [];
        public string[] Sizes { get; set; } = [];
        public MenuItem[] Items { get; set; } = [];
    }
}
