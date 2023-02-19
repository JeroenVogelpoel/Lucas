using DigitalFish.Lucas.Persistence.Models;

namespace DigitalFish.Lucas.Logic.Renderers.Interfaces
{
    public interface IRenderer
    {
        string Name { get; }

        Template Render(Template input);
    }
}
