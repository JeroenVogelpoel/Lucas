namespace DigitalFish.Lucas.Persistence.Models
{
    public class Template
    {
        public string Identifier { get; set; } = string.Empty;

        public string OutputName { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public dynamic? Data { get; set; }
    }
}
