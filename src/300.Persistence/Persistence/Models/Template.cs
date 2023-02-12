namespace DigitalFish.Lucas.Persistence.Models
{
    public record Template(
        string Identifier,
        string outputName,
        string RawContent)
    {
        public dynamic? Data { get; set; }
    }
}
