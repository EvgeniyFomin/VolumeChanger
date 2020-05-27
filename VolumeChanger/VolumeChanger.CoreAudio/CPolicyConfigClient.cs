using VolumeChanger.CoreAudio.Enumerations;
using VolumeChanger.CoreAudio.Internal.Interfaces;

namespace VolumeChanger.CoreAudio
{
    public class CPolicyConfigClient
    {
        private readonly IPolicyConfig _policyConfigClient = new Internal.CPolicyConfigClient() as IPolicyConfig;
       
        public int SetDefaultDevice(string deviceID)
        {
            _policyConfigClient.SetDefaultEndpoint(deviceID, ERole.eConsole);
            _policyConfigClient.SetDefaultEndpoint(deviceID, ERole.eMultimedia);
            _policyConfigClient.SetDefaultEndpoint(deviceID, ERole.eCommunications);

            return 0;
        }
    }
}
