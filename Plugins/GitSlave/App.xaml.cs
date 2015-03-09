using Autofac;
using GitSlave.Internal.ViewModel;
using GitUIPluginInterfaces;

namespace GitSlave
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App 
    {
        public App(IGitUICommands gitUiCommands)
        {
            InitializeComponent();

            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterInstance(gitUiCommands).AsImplementedInterfaces();

            Resources.Add("ViewModelLocator", new ViewModelLocator(containerBuilder));
        }
    }
}
