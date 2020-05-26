using System;
using System.Runtime.InteropServices;
using VolumeChanger.CoreAudio.Constants;

namespace VolumeChanger.CoreAudio.Interfaces
{
    [Guid(ComIIds.AUDIO_ENDPOINT_VOLUME_CALLBACK_IID), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioEndpointVolumeCallback
    {
        [PreserveSig]
        int OnNotify([In] IntPtr notificationData);
    }
}