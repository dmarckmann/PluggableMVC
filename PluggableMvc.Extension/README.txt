To set this up:

*. Create a new MVCPlugin for your new plugin.
*. Right-click the Index.cshtml view and click 'Run custom tool' (This is needed only once... ) 
*. Install nuget package PluggableMvc from nuget package source \\dev11\Share\Tellus.NuGetPackages.Temp into your new MvcPlugin
*. Build your project
*. Copy dll to bin folder of the host.. .

I am currently working on the host functionality in a nuget package... 

Key to this are NuGet packages: MefContrib.Mvc3, MefContrib
the file: App_Start\AppStart_PluggableMvc.cs
and the file: Views\Shared\_PluggableMvcMenu.cshtml which is rendered in _Layout.cshtml like this:
	@{
		Html.RenderPartial("_PluggableMvcMenu");
	}