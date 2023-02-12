using DigitalFish.Lucas.Persistence.Models;

namespace DigitalFish.Lucas.Logic.Formatters.Interfaces
{
    public interface IFormatter
    {
        string Name { get; }

        Template Format(Template input);
    }
}
