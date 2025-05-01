namespace LTP.Static.Models
{
    public class MenuItem
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public double[] Price { get; set; } = Array.Empty<double>();
    }
}
