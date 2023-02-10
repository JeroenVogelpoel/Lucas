using Autofac;
using DigitalFish.Lucas.Logic.Stores;
using DigitalFish.Lucas.Logic.Stores.Interfaces;

namespace DigitalFish.Lucas.UI.DotnetTool.DI
{
    internal static partial class Registration
    {
        private static void loadLogicDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<TemplateStore>()
                .As<ITemplateStore>();
        }
    }
}
