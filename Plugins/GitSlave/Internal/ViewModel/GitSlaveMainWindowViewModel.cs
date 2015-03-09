using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GitUIPluginInterfaces;

namespace GitSlave.Internal.ViewModel
{
    internal sealed class GitSlaveMainWindowViewModel : ViewModelBase
    {
        private readonly IGitUICommands _gitUiCommands;
        private readonly GitSlaveHelper _gitSlaveHelper;

        public RelayCommand PullAllCommand { get; private set; }
        
        public GitSlaveMainWindowViewModel(IGitUICommands gitUiCommands, GitSlaveHelper gitSlaveHelper)
        {
            _gitUiCommands = gitUiCommands;
            _gitSlaveHelper = gitSlaveHelper;
            PullAllCommand = new RelayCommand(PullAll);
        }

        private void PullAll()
        {
            
        }
    }
}