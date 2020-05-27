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

using System;
using System.Runtime.InteropServices;
using VolumeChanger.CoreAudio.Enumerations;
using VolumeChanger.CoreAudio.Internal.Constants;
using VolumeChanger.CoreAudio.Internal.Interfaces.MMDevice;

namespace VolumeChanger.CoreAudio
{
    //Marked as internal, since on its own its no good
    [ComImport, Guid(ComIIds.DEVICE_ENUMERATOR_CID)]
    internal class _MMDeviceEnumerator
    {
    }

    //Small wrapper class
    public class MMDeviceEnumerator 
    {
        private readonly IMMDeviceEnumerator _realEnumerator = new _MMDeviceEnumerator() as IMMDeviceEnumerator;

        public MMDeviceCollection EnumerateAudioEndPoints(EDataFlow dataFlow, DEVICE_STATE dwStateMask)
        {
            Marshal.ThrowExceptionForHR(_realEnumerator.EnumAudioEndpoints(dataFlow, dwStateMask, out IMMDeviceCollection result));
            return new MMDeviceCollection(result);
        }

        public MmDevice GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role)
        {
            Marshal.ThrowExceptionForHR(((IMMDeviceEnumerator)_realEnumerator).GetDefaultAudioEndpoint(dataFlow, role, out IMMDevice _Device));
            return new MmDevice(_Device);
        }

        public void SetDefaultAudioEndpoint(MmDevice device)
        {
            //Marshal.ThrowExceptionForHR(((IMMDeviceEnumerator)_realEnumerator).SetDefaultAudioEndpoint(device.ReadDevice));
            device.Selected = true;
        }

        public MmDevice GetDevice(string ID)
        {
            Marshal.ThrowExceptionForHR(((IMMDeviceEnumerator)_realEnumerator).GetDevice(ID, out IMMDevice _Device));
            return new MmDevice(_Device);
        }

        public MMDeviceEnumerator()
        {
            if (System.Environment.OSVersion.Version.Major < 6)
            {
                throw new NotSupportedException("This functionality is only supported on Windows Vista or newer.");
            }
        }
    }
}
