using MaterialDesignSample.MainModule.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using Autofac;
using Prism.Autofac;

namespace MaterialDesignSample.MainModule
{
    public class MainModule : IModule
    {
        private IRegionManager _regionManager;
        private ContainerBuilder _builder;

        public MainModule(ContainerBuilder builder, IRegionManager regionManager)
        {
            _builder = builder;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
        }
    }
}