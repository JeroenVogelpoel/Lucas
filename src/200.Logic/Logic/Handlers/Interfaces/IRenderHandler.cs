using DigitalFish.Lucas.Persistence.Models;

namespace DigitalFish.Lucas.Logic.Handlers.Interfaces
{
    public interface IRenderHandler
    {
        /// <summary>
        /// Determines the renderer(s) to be used and applies them in order.
        /// </summary>
        /// <remarks>
        /// Renderers are determined by the template data if defined,
        /// or implied by the naming of the template. The default formatter is
        /// the <see cref="Renderers.Passthru"/> formatter.
        /// </remarks>
        Template RenderTemplate(Template template);
    }
}
