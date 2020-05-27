using System;
using System.Runtime.InteropServices;
using VolumeChanger.CoreAudio.Enumerations;

namespace VolumeChanger.CoreAudio.Interfaces
{
    public interface IAudioSessionControl
    {
        void FireDisplayNameChanged([MarshalAs(UnmanagedType.LPWStr)] string NewDisplayName, Guid EventContext);

        void FireOnIconPathChanged([MarshalAs(UnmanagedType.LPWStr)] string NewIconPath, Guid EventContext);

        void FireSimpleVolumeChanged(float NewVolume, bool newMute, Guid EventContext);

        void FireChannelVolumeChanged(uint ChannelCount, IntPtr NewChannelVolumeArray, uint ChangedChannel, Guid EventContext);

        void FireStateChanged(AudioSessionState NewState);

        void FireSessionDisconnected(AudioSessionDisconnectReason DisconnectReason);
    }
}