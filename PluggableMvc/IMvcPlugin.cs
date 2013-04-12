using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace PluggableMvc
{
	public interface IMvcPlugin
	{
		string DisplayName { get; }
		string DefaultControllerName { get; }
		string DefaultActionName { get; }
	}
}
