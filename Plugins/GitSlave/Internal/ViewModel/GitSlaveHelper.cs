using GitUIPluginInterfaces;

namespace GitSlave.Internal.ViewModel
{
    internal class GitSlaveHelper
    {
        private const string GitSlaveCommandName = "gits";
        private readonly IGitUICommands _gitUiCommands;

        public GitSlaveHelper(IGitUICommands gitUiCommands)
        {
            _gitUiCommands = gitUiCommands;
        }

        public bool IsInstalled()
        {
            return _gitUiCommands.GitModule.RunCmdResult(GitSlaveCommandName, string.Empty).ExitCode != 0;
        }
    }
}