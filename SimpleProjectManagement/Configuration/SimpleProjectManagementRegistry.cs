using FubuMVC.Core;
using FubuMVC.Spark;
using SimpleProjectManagement.Features;

namespace SimpleProjectManagement.Configuration
{
    public class SimpleProjectManagementRegistry : FubuRegistry
    {
        public SimpleProjectManagementRegistry()
        {
            // This line turns on the basic diagnostics and request tracing
            IncludeDiagnostics(true);


            Applies.
                ToThisAssembly();

            this.UseSpark();

            ApplyHandlerConventions(typeof(FeaturesMarker));

            // All public methods from concrete classes ending in "Controller"
            // in this assembly are assumed to be action methods
            //Actions.IncludeClassesSuffixedWithController();

            // Policies
            //Routes
            //    .IgnoreControllerNamesEntirely()
            //    .IgnoreMethodSuffix("Html")
            //    .RootAtAssemblyNamespace();

            // Match views to action methods by matching
            // on model type, view name, and namespace
            Views.TryToAttachWithDefaultConventions();

            Routes.HomeIs<GetHandler>(x => x.Execute(new DashboardRequestModel()));
        }
    }
}