using DigitalFish.Lucas.Logic.Formatters.Interfaces;
using DigitalFish.Lucas.Persistence.Models;

namespace DigitalFish.Lucas.Logic.Formatters
{
    /// <summary>
    /// This formatter does nothing except passing through data as-is
    /// </summary>
    public class Passthru : IFormatter
    {
        public string Name => "passthru";

        public Template Format(Template input) => input;
    }
}
