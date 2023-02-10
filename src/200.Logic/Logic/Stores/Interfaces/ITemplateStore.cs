using DigitalFish.Lucas.Persistence.Models;

namespace DigitalFish.Lucas.Logic.Stores.Interfaces
{
    public interface ITemplateStore
    {
        Template Find(string identifier);
    }
}
