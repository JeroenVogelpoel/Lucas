using DigitalFish.Lucas.Persistence.Models;

namespace DigitalFish.Lucas.Persistence.Repositories.Interfaces
{
    public interface ITemplateRepository
    {
        /// <summary>
        /// Lists known template within this repository
        /// </summary>
        IEnumerable<string> List();

        /// <summary>
        /// Extracts a <see cref="Template"/> by it's identifier
        /// </summary>
        Template Load(string identifier);
    }
}
