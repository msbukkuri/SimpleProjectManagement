using System;
using System.Web.Routing;
using Bottles;
using FubuMVC.Core;
using FubuMVC.StructureMap;
using SimpleProjectManagement.Configuration;
using SimpleProjectManagement.Configuration.Bootstrapping;

namespace SimpleProjectManagement
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            FubuApplication
                .For<SimpleProjectManagementRegistry>()
                .StructureMapObjectFactory(x => x.AddRegistry<CoreRegistry>())
                .Bootstrap();

            PackageRegistry
                .AssertNoFailures();
        }
    }
}