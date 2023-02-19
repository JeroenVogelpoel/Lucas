namespace DigitalFish.Lucas.Persistence.Models
{
    public class TemplateData
    {
        public string? Target { get; set; }

        public IEnumerable<string>? Renderers { get; set; }

        public dynamic? CustomData { get; set; }
    }
}
