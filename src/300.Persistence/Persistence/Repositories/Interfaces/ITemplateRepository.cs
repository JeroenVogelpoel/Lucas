using DigitalFish.Lucas.Persistence.Models;

namespace DigitalFish.Lucas.Persistence.Repositories.Interfaces
{
    public interface ITemplateRepository
    {
        Template Load(string identifier);
    }
}
