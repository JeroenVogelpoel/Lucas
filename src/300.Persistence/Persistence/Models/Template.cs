namespace DigitalFish.Lucas.Persistence.Models
{
    public class Template
    {
        public Template(string identifier)
        {
            Identifier = identifier;
        }

        public string Identifier { get; }

        public string Content { get; set; } = string.Empty;

        public TemplateData? Data { get; set; }
    }
}
