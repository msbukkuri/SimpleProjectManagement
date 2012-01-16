using StructureMap.Configuration.DSL;

namespace SimpleProjectManagement.Configuration.Bootstrapping
{
    public class CoreRegistry : Registry
    {
        public CoreRegistry()
        {
            Scan(x =>
                     {
                         x.TheCallingAssembly();
                         x.LookForRegistries();
                         x.WithDefaultConventions();
                     });
        }
    }
}