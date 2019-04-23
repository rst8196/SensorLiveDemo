namespace SensorLiveDemo.Modules
{
    using Prism.Ioc;
    using Prism.Modularity;
    using Views;

    public class SensorMainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<PrimarySensorView>();
            containerRegistry.RegisterForNavigation<SecondarySensorView>();
            containerRegistry.RegisterForNavigation<FallbackSensorView>();
        }
    }
}