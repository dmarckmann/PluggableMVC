[assembly: WebActivator.PostApplicationStartMethod(typeof(PluggableMvc.Host.App_Start.AppStart_PluggableMvc), "Start")]
namespace PluggableMvc.Host.App_Start
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Mvc;
	using PluggableMvc;
	using BoC.Web.Mvc.PrecompiledViews;


	public static class AppStart_PluggableMvc
	{
		public static void Start()
		{
			foreach (var c in DependencyResolver.Current.GetServices<IMvcPlugin>())
			{
				Type t = c.GetType();
				ApplicationPartRegistry.Register(t.Assembly);
			}
		}
	}
}