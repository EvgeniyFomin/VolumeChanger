using System.ComponentModel;
using System.Configuration.Install;

namespace VolumeChanger.WinService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }
    }
}
