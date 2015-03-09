using System.Windows;

namespace GitSlave.Internal
{
    /// <summary>
    /// Interaction logic for BranchPromptWindow.xaml
    /// </summary>
    public partial class BranchPromptWindow : Window
    {
        public BranchPromptWindow()
        {
            InitializeComponent();
        }

        private void OkButton_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
