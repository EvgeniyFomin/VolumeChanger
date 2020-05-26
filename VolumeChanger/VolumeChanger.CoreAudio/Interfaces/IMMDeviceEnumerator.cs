using System.Runtime.InteropServices;
using VolumeChanger.CoreAudio.Constants;
using VolumeChanger.CoreAudio.Enums;

namespace VolumeChanger.CoreAudio.Interfaces
{
    [Guid(ComIIds.IMM_DEVICE_ENUMERATOR_IID), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMMDeviceEnumerator
    {
        int NotImpl1();

        [PreserveSig]
        int GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, out IMMDevice ppDevice);

        // the rest is not implemented
    }
}