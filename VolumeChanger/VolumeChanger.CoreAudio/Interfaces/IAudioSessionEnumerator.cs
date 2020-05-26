using System.Runtime.InteropServices;
using VolumeChanger.CoreAudio.Constants;

namespace VolumeChanger.CoreAudio.Interfaces
{
    [Guid(ComIIds.AUDIO_SESSION_ENUMERATOR_IID), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionEnumerator
    {
        [PreserveSig]
        int GetCount(out int SessionCount);

        [PreserveSig]
        int GetSession(int SessionCount, out IAudioSessionControl2 Session);
    }
}