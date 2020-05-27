/*
  LICENSE
  -------
  Copyright (C) 2007-2010 Ray Molenkamp

  This source code is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this source code or the software it produces.

  Permission is granted to anyone to use this source code for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this source code must not be misrepresented; you must not
     claim that you wrote the original source code.  If you use this source code
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original source code.
  3. This notice may not be removed or altered from any source distribution.
*/

/* Created by Xavier Flix (2010/11/18) */

using System;
using System.Runtime.InteropServices;
using VolumeChanger.CoreAudio.Internal.Constants;
using VolumeChanger.CoreAudio.Internal.Enumerations;

namespace VolumeChanger.CoreAudio.Internal.Interfaces.WASAPI
{
    [Guid(ComIIds.AUDIO_CAPTURE_CLIENT_IID), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioCaptureClient
    {
        [PreserveSig]
        AUDCLNT_RETURNFLAGS GetBuffer(out byte[] ppData, out AUDCLNT_BUFFERFLAGS pNumFramesToRead, UInt64 pu64DevicePosition, UInt64 pu64QPCPosition);
        [PreserveSig]
        AUDCLNT_RETURNFLAGS ReleaseBuffer(UInt32 NumFramesRead);
        [PreserveSig]
        AUDCLNT_RETURNFLAGS GetNextPacketSize(out UInt32 pNumFramesInNextPacket);
    }
}
