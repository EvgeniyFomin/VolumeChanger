using System.ServiceProcess;

namespace VolumeChanger.WinService
{
    public partial class VolumeService : ServiceBase
    {
        public VolumeService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
