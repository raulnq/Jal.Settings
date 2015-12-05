# Jal.Settings
Just another library to get the settings of your application
## How to use?
Note: The default implementation work with the App.config and the Web.config files. 
Setup the Castle Windsor container

    var container = new WindsorContainer();

Install the Jal.Settings.Installer library

    container.Install(new SettingsInstaller());
  
Resolve a instance of the ISettingsExtractor interface

    var settingsExtractor = container.Resolve<ISettingsExtractor>();

Get a setting for the config file

    var appName = settingsExtractor.Get<string>("ApplicationName",false, string.Empty);
