packages\NuGet.CommandLine.3.4.4-rtm-final\tools\nuget pack Jal.Settings\Jal.Settings.csproj -Properties "Configuration=Release;Platform=AnyCPU;OutputPath=bin\Release" -Build -IncludeReferencedProjects -OutputDirectory Jal.Settings.Nuget

packages\NuGet.CommandLine.3.4.4-rtm-final\tools\nuget pack Jal.Settings.Installer\Jal.Settings.Installer.csproj -Properties "Configuration=Release;Platform=AnyCPU;OutputPath=bin\Release" -Build -IncludeReferencedProjects -OutputDirectory Jal.Settings.Nuget

packages\NuGet.CommandLine.3.4.4-rtm-final\tools\nuget pack Jal.Settings.LightInject.Installer\Jal.Settings.LightInject.Installer.csproj -Properties "Configuration=Release;Platform=AnyCPU;OutputPath=bin\Release" -Build -IncludeReferencedProjects -OutputDirectory Jal.Settings.Nuget

pause;