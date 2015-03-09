/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:GitSlave"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using System.Reflection;
using Autofac;
using Microsoft.Practices.ServiceLocation;

namespace GitSlave.Internal.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    internal sealed class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());
            
            var container = containerBuilder.Build();
            ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(container));
        }

        public GitSlaveMainWindowViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<GitSlaveMainWindowViewModel>();
            }
        }

        public static void Cleanup()
        {
        }
    }
}