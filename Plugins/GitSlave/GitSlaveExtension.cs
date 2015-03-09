using System;
using System.Windows;
using GitSlave.Internal;
using GitUIPluginInterfaces;

namespace GitSlave
{
    public class GitSlaveExtension : GitPluginBase, IGitPluginForRepository
    {
        private App _application;

        public override string Description
        {
            get { return "GitSlave Extension"; }
        }

        public override void Register(IGitUICommands gitUiCommands)
        {
            CreateApplication(gitUiCommands);
            base.Register(gitUiCommands);
        }

        private void CreateApplication(IGitUICommands gitUiCommands)
        {
            if (_application == null)
            {
                _application = new App(gitUiCommands) {ShutdownMode = ShutdownMode.OnExplicitShutdown};
            }
        }

        public override void Unregister(IGitUICommands gitUiCommands)
        {
            if (_application != null)
            {
                _application.Shutdown();
            }

            _application = null;
        }

        public override bool Execute(GitUIBaseEventArgs gitUiCommands)
        {
            return new GitSlaveMainWindow().ShowDialog() ?? false;
        }
    }
}
