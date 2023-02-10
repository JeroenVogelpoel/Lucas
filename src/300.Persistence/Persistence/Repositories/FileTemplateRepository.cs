using DigitalFish.Lucas.Persistence.Models;
using DigitalFish.Lucas.Persistence.Repositories.Interfaces;

namespace DigitalFish.Lucas.Persistence.Repositories
{
    public class FileTemplateRepository : ITemplateRepository
    {
        public IEnumerable<string> List()
        {
            throw new NotImplementedException();
        }

        public Template Load(string identifier)
        {
            throw new NotImplementedException();
        }
    }
}
