packages\NuGet.CommandLine.3.3.0\tools\nuget pack Jal.Settings\Jal.Factory.csproj -Properties "Configuration=Release;Platform=AnyCPU;OutputPath=bin\Release" -Build -IncludeReferencedProjects -OutputDirectory Jal.Settings.Nuget

packages\NuGet.CommandLine.3.3.0\tools\nuget pack Jal.Settings.Installer\Jal.Factory.Installer.csproj -Properties "Configuration=Release;Platform=AnyCPU;OutputPath=bin\Release" -Build -IncludeReferencedProjects -OutputDirectory Jal.Settings.Nuget

pause;