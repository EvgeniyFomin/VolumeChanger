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
using VolumeChanger.CoreAudio.Constants;
using VolumeChanger.CoreAudio.Enumerations;
using VolumeChanger.CoreAudio.Internal.Interfaces;
using VolumeChanger.CoreAudio.Internal.Interfaces.DeviceTopology;
using VolumeChanger.CoreAudio.Internal.Interfaces.EndpointVolume;
using VolumeChanger.CoreAudio.Internal.Interfaces.MMDevice;
using VolumeChanger.CoreAudio.Internal.Interfaces.WASAPI;

namespace VolumeChanger.CoreAudio
{
    public class MmDevice
    {
        #region Variables
        private PropertyStore _propertyStore;
        private AudioMeterInformation _audioMeterInformation;
        private AudioEndpointVolume _audioEndpointVolume;
        private AudioSessionManager2 _audioSessionManager2;
        private DeviceTopology _deviceTopology;

        #endregion

        #region Init
        private void GetPropertyInformation()
        {
            Marshal.ThrowExceptionForHR(ReadDevice.OpenPropertyStore(EStgmAccess.STGM_READ, out IPropertyStore propstore));
            _propertyStore = new PropertyStore(propstore);
        }

        private void GetAudioSessionManager2()
        {
            Marshal.ThrowExceptionForHR(ReadDevice.Activate(ref IIDs.IID_IAudioSessionManager2, CLSCTX.ALL, IntPtr.Zero, out object result));
            _audioSessionManager2 = new AudioSessionManager2(result as IAudioSessionManager2);
        }

        private void GetAudioMeterInformation()
        {
            Marshal.ThrowExceptionForHR(ReadDevice.Activate(ref IIDs.IID_IAudioMeterInformation, CLSCTX.ALL, IntPtr.Zero, out object result));
            _audioMeterInformation = new AudioMeterInformation( result as IAudioMeterInformation);
        }

        private void GetAudioEndpointVolume()
        {
            Marshal.ThrowExceptionForHR(ReadDevice.Activate(ref IIDs.IID_IAudioEndpointVolume, CLSCTX.ALL, IntPtr.Zero, out object result));
            _audioEndpointVolume = new AudioEndpointVolume(result as IAudioEndpointVolume);
        }

        private void GetDeviceTopology()
        {
            Marshal.ThrowExceptionForHR(ReadDevice.Activate(ref IIDs.IID_IDeviceTopology, CLSCTX.ALL, IntPtr.Zero, out object result));
            _deviceTopology = new DeviceTopology(result as IDeviceTopology);
        }

        #endregion

        #region Properties

        public AudioSessionManager2 AudioSessionManager2
        {
            get
            {
                if (_audioSessionManager2 == null) GetAudioSessionManager2();
                return _audioSessionManager2;
            }
        }

        public AudioMeterInformation AudioMeterInformation
        {
            get
            {
                if (_audioMeterInformation == null) GetAudioMeterInformation();
                return _audioMeterInformation;
            }
        }

        public AudioEndpointVolume AudioEndpointVolume
        {
            get
            {
                if (_audioEndpointVolume == null) GetAudioEndpointVolume();
                return _audioEndpointVolume;
            }
        }

        public PropertyStore Properties
        {
            get
            {
                if (_propertyStore == null) GetPropertyInformation();
                return _propertyStore;
            }
        }

        public DeviceTopology DeviceTopology
        {
            get
            {
                if (_deviceTopology == null) GetDeviceTopology();
                return _deviceTopology;
            }
        }

        public string FriendlyName
        {
            get
            {
                if (_propertyStore == null)
                {
                    GetPropertyInformation();
                }

                if(_propertyStore.Contains(PKEY.PKEY_DeviceInterface_FriendlyName))
                {
                    return (string)_propertyStore[PKEY.PKEY_DeviceInterface_FriendlyName].Value;
                }

                return "Unknown";
            }
        }


        public string Id
        {
            get
            {
                Marshal.ThrowExceptionForHR(ReadDevice.GetId(out string result));
                return result;
            }
        }

        public EDataFlow DataFlow
        {
            get
            {
                IMMEndpoint ep = ReadDevice as IMMEndpoint;
                ep.GetDataFlow(out EDataFlow result);
                return result;
            }
        }

        public DEVICE_STATE State
        {
            get
            {
                Marshal.ThrowExceptionForHR(ReadDevice.GetState(out DEVICE_STATE result));
                return result;

            }
        }

        internal IMMDevice ReadDevice { get; }

        public bool Selected
        {
            get
            {
                return (new MMDeviceEnumerator()).GetDefaultAudioEndpoint(DataFlow, ERole.eMultimedia).Id == Id;
            }
            set
            {
                if (value == true)
                {
                    (new CPolicyConfigVistaClient()).SetDefaultDevice(this.Id);
                    //if(System.Environment.OSVersion.Version.Major==6 && System.Environment.OSVersion.Version.Minor==0)
                    //    (new CPolicyConfigVistaClient()).SetDefaultDevie(this.ID);
                    //else
                    //    (new CPolicyConfigClient()).SetDefaultDevie(this.ID);
                }
            }
        }

        #endregion

        #region Constructor
        internal MmDevice(IMMDevice realDevice)
        {
            ReadDevice = realDevice;
        }
        #endregion

    }
}
