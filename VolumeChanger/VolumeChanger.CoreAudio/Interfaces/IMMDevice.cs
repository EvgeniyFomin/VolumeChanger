using System;
using System.Runtime.InteropServices;
using VolumeChanger.CoreAudio.Constants;

namespace VolumeChanger.CoreAudio.Interfaces
{
    [Guid(ComIIds.IMM_DEVICE_IID), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMMDevice
    {
        [PreserveSig]
        int Activate(ref Guid iid, int dwClsCtx, IntPtr pActivationParams, [MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);

        // the rest is not implemented
    }
}