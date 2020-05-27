using System.ServiceProcess;
using System.Threading;
using VolumeChanger.CoreAudio;
using VolumeChanger.CoreAudio.Enumerations;

namespace VolumeChanger.WinService
{
    public partial class VolumeService : ServiceBase
    {
        private readonly MmDevice _device;
        public int Value { get; set; }

        public VolumeService()
        {
            InitializeComponent();
            var devEnum = new MMDeviceEnumerator();
            _device = devEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
            this.Value = (int)(_device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
            _device.AudioEndpointVolume.OnVolumeNotification += AudioEndpointVolume_OnVolumeNotification;
        }

        protected override void OnStart(string[] args)
        {
#if DEBUG
            System.Diagnostics.Debugger.Launch();
#endif
            Thread.Sleep(5000);
            _device.AudioEndpointVolume.Mute = true;
        }

        private void AudioEndpointVolume_OnVolumeNotification(AudioVolumeNotificationData data)
        {
            this.Value = (int)(data.MasterVolume * 100);
        }

        protected override void OnStop()
        {
        }
    }
}
