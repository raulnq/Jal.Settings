# Jal.Settings

Just another library to get the settings of your application

## How to use?

Note: The default implementation work with the App.config and the Web.config files. 

### Default implementation

Resolve a instance of the ISettingsExtractor interface

	var settingsExtractor = SettingsExtractor.Builder.Create;

Get a setting for the config file

    var appName = settingsExtractor.Get<string>("ApplicationName",false, string.Empty);

## Castle Windsor Integration

Setup the Castle Windsor container

    var container = new WindsorContainer();

Install the Jal.Settings.Installer library

    container.Install(new SettingsInstaller());
  
Resolve a instance of the ISettingsExtractor interface

    var settingsExtractor = container.Resolve<ISettingsExtractor>();

Get a setting for the config file

    var appName = settingsExtractor.Get<string>("ApplicationName",false, string.Empty);

## LightInject Integration

Setup the LightInject container

    var container = new ServiceContainer();

Install the Jal.Settings.Installer library

    container.RegisterFrom<SettingsCompositionRoot>();
  
Resolve a instance of the ISettingsExtractor interface

    var settingsExtractor = container.GetInstance<ISettingsExtractor>();

Get a setting for the config file

    var appName = settingsExtractor.Get<string>("ApplicationName",false, string.Empty);