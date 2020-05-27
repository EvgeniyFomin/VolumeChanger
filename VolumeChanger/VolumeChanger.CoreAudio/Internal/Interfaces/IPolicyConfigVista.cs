using System.Runtime.InteropServices;
using VolumeChanger.CoreAudio.Enumerations;
using VolumeChanger.CoreAudio.Internal.Constants;

// http://eretik.omegahg.com/download/PolicyConfig.h
// http://social.microsoft.com/Forums/en-US/Offtopic/thread/9ebd7ad6-a460-4a28-9de9-2af63fd4a13e/

namespace VolumeChanger.CoreAudio.Internal.Interfaces
{
    [Guid(ComIIds.POLICY_CONFIG_VISTA_IID), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IPolicyConfigVista
    {
        [PreserveSig]
        int GetMixFormat();
        [PreserveSig]
        int GetDeviceFormat();
        [PreserveSig]
        int SetDeviceFormat();
        [PreserveSig]
        int GetProcessingPeriod();
        [PreserveSig]
        int SetProcessingPeriod();
        [PreserveSig]
        int GetShareMode();
        [PreserveSig]
        int SetShareMode();
        [PreserveSig]
        int GetPropertyValue();
        [PreserveSig]
        int SetPropertyValue();
        [PreserveSig]
        int SetDefaultEndpoint([MarshalAs(UnmanagedType.LPWStr)] string wszDeviceId, ERole eRole);
        [PreserveSig]
        int SetEndpointVisibility();
    }
}
