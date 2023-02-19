using DigitalFish.Lucas.Logic.Renderers.Interfaces;
using DigitalFish.Lucas.Persistence.Models;

namespace DigitalFish.Lucas.Logic.Renderers
{
    /// <summary>
    /// This formatter does nothing except passing through data as-is
    /// </summary>
    public class Passthru : IRenderer
    {
        public string Name => "passthru";

        public Template Render(Template input) => input;
    }
}
