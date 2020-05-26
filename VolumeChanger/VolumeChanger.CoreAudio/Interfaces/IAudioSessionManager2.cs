using System.Runtime.InteropServices;
using VolumeChanger.CoreAudio.Constants;

namespace VolumeChanger.CoreAudio.Interfaces
{
    [Guid(ComIIds.AUDIO_SESSION_MANAGER2_IID), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionManager2
    {
        int NotImpl1();
        int NotImpl2();

        [PreserveSig]
        int GetSessionEnumerator(out IAudioSessionEnumerator SessionEnum);

        // the rest is not implemented
    }
}