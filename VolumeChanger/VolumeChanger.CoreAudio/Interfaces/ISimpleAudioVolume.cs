using System;
using System.Runtime.InteropServices;
using VolumeChanger.CoreAudio.Constants;

namespace VolumeChanger.CoreAudio.Interfaces
{
    [Guid(ComIIds.SIMPLE_AUDIO_VOLUME_IID), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ISimpleAudioVolume
    {
        [PreserveSig]
        int SetMasterVolume(float fLevel, ref Guid EventContext);

        [PreserveSig]
        int GetMasterVolume(out float pfLevel);

        [PreserveSig]
        int SetMute(bool bMute, ref Guid EventContext);

        [PreserveSig]
        int GetMute(out bool pbMute);
    }
}