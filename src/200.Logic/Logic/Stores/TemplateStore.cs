using DigitalFish.Lucas.Logic.Stores.Interfaces;
using DigitalFish.Lucas.Persistence.Models;
using DigitalFish.Lucas.Persistence.Repositories.Interfaces;

namespace DigitalFish.Lucas.Logic.Stores
{
    public class TemplateStore : ITemplateStore
    {
        private readonly IEnumerable<ITemplateRepository> _templateRepositories;

        public TemplateStore(
            IEnumerable<ITemplateRepository> templateRepositories)
        {
            _templateRepositories = templateRepositories;
        }

        public Template Find(string identifier)
        {
            return new Template(identifier);
        }
    }
}
