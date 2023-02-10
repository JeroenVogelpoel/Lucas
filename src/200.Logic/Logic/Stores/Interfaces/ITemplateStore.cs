using DigitalFish.Lucas.Persistence.Models;

namespace DigitalFish.Lucas.Logic.Stores.Interfaces
{
    public interface ITemplateStore
    {
        /// <summary>
        /// Finds a single <see cref="Template"/> that matches the given identifier
        /// </summary>
        Template Find(string identifier);

        /// <summary>
        /// Lists all template identifiers known to underlying repositories
        /// </summary>
        IEnumerable<string> List();
    }
}
