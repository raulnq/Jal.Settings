# Jal.Factory [![Build status](https://ci.appveyor.com/api/projects/status/fad3odko6ba8coa5/branch/master?svg=true)](https://ci.appveyor.com/project/raulnq/jal-settings/branch/master) [![NuGet](https://img.shields.io/nuget/v/Jal.Settings.svg)](https://www.nuget.org/packages/Jal.Settings)
# Jal.Settings

Just another library to get the settings of your application

## How to use?

Note: The default implementation work with the App.config and the Web.config files. 

### Default implementation

Resolve a instance of the ISettingsExtractor interface

	var settingsExtractor = SettingsExtractor.Builder.Create;

Get a setting for the config file

    var appName = settingsExtractor.Get<string>("ApplicationName",false, string.Empty);

## Castle Windsor Integration [![NuGet](https://img.shields.io/nuget/v/Jal.Settings.Installer.svg)](https://www.nuget.org/packages/Jal.Settings.Installer)

Setup the Castle Windsor container

    var container = new WindsorContainer();

Install the Jal.Settings.Installer library

    container.Install(new SettingsInstaller());
  
Resolve a instance of the ISettingsExtractor interface

    var settingsExtractor = container.Resolve<ISettingsExtractor>();

Get a setting for the config file

    var appName = settingsExtractor.Get<string>("ApplicationName",false, string.Empty);

## LightInject Integration [![NuGet](https://img.shields.io/nuget/v/Jal.Settings.LightInject.Installer.svg)](https://www.nuget.org/packages/Jal.Settings.LightInject.Installer)

Setup the LightInject container

    var container = new ServiceContainer();

Install the Jal.Settings.Installer library

    container.RegisterFrom<SettingsCompositionRoot>();
  
Resolve a instance of the ISettingsExtractor interface

    var settingsExtractor = container.GetInstance<ISettingsExtractor>();

Get a setting for the config file

    var appName = settingsExtractor.Get<string>("ApplicationName",false, string.Empty);