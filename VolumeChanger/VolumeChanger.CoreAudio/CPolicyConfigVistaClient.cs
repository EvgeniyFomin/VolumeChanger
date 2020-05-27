using VolumeChanger.CoreAudio.Enumerations;
using VolumeChanger.CoreAudio.Internal.Interfaces;

namespace VolumeChanger.CoreAudio
{
    public class CPolicyConfigVistaClient
    {
        private readonly IPolicyConfigVista _policyConfigVistaClient = new Internal.CPolicyConfigVistaClient() as IPolicyConfigVista;
       
        public int SetDefaultDevice(string deviceID)
        {
            _policyConfigVistaClient.SetDefaultEndpoint(deviceID, ERole.eConsole);
            _policyConfigVistaClient.SetDefaultEndpoint(deviceID, ERole.eMultimedia);
            _policyConfigVistaClient.SetDefaultEndpoint(deviceID, ERole.eCommunications);

            return 0;
        }
    }
}
