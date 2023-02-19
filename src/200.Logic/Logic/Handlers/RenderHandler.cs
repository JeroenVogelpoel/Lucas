using DigitalFish.Lucas.Logic.Renderers;
using DigitalFish.Lucas.Logic.Renderers.Interfaces;
using DigitalFish.Lucas.Logic.Handlers.Interfaces;
using DigitalFish.Lucas.Persistence.Models;

namespace DigitalFish.Lucas.Logic.Handlers
{
    public class RenderHandler : IRenderHandler
    {
        private readonly IEnumerable<IRenderer> _renderers;

        public RenderHandler(
            IEnumerable<IRenderer> renderers)
        {
            _renderers = renderers;
        }

        /// <inheritdoc/>
        public Template RenderTemplate(Template template)
        {
            if (template == null)
                throw new ArgumentNullException(nameof(template));

            //TODO: Apply formatter logic here
            return _renderers
                .First()
                .Render(template);
        }
    }
}
