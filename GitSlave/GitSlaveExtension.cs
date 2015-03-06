using GitSlave.Internal;
using GitUIPluginInterfaces;

namespace GitSlave
{
    public class GitSlaveExtension : GitPluginBase, IGitPluginForRepository
    {
        public override string Description
        {
            get { return "GitSlave Extension"; }
        }

        public override bool Execute(GitUIBaseEventArgs gitUiCommands)
        {
            return new BranchPromptWindow().ShowDialog() ?? false;
            //gitUiCommands.GitUICommands.StartCommandLineProcessDialog(gitUiCommands.OwnerForm, "gits branch")
        }
    }
}
