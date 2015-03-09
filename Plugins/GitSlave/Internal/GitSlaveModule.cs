using Autofac;
using GitSlave.Internal.ViewModel;

namespace GitSlave.Internal
{
    internal sealed class GitSlaveModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).Where(type => type.IsAssignableTo<IGitSlaveCommand>()).AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<GitSlaveMainWindowViewModel>().AsSelf().SingleInstance();
        }
    }
}