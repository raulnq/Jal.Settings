using Castle.Windsor;
using Microsoft.Extensions.Configuration;

namespace Jal.Settings.Configuration.Installer
{
    public static class WindsorContainerExtensions
    {
        public static void AddSettings(this IWindsorContainer container, IConfiguration configuration)
        {
            container.Install(new SettingsInstaller(configuration));
        }
    }
}