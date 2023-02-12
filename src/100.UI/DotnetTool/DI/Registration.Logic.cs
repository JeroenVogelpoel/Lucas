using Autofac;
using DigitalFish.Lucas.Logic.Formatters;
using DigitalFish.Lucas.Logic.Formatters.Interfaces;
using DigitalFish.Lucas.Logic.Stores;
using DigitalFish.Lucas.Logic.Stores.Interfaces;

namespace DigitalFish.Lucas.UI.DotnetTool.DI
{
    internal static partial class Registration
    {
        private static void loadLogicDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<TemplateStore>()
                .SingleInstance()
                .As<ITemplateStore>();

            containerBuilder.RegisterType<Passthru>()
                .SingleInstance()
                .As<IFormatter>();
        }
    }
}
