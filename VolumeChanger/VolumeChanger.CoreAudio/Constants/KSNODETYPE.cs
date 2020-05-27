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

#if (NET40) 
using System.Linq;
#endif

namespace VolumeChanger.CoreAudio.Constants
{
    public class KSNODETYPE
    {
        public static Guid INPUT_UNDEFINED = new Guid("DFF21BE0-F70F-11D0-B917-00A0C9223196");
        public static Guid MICROPHONE = new Guid("DFF21BE1-F70F-11D0-B917-00A0C9223196");
        public static Guid DESKTOP_MICROPHONE = new Guid("DFF21BE2-F70F-11D0-B917-00A0C9223196");
        public static Guid PERSONAL_MICROPHONE = new Guid("DFF21BE3-F70F-11D0-B917-00A0C9223196");
        public static Guid OMNI_DIRECTIONAL_MICROPHONE = new Guid("DFF21BE4-F70F-11D0-B917-00A0C9223196");
        public static Guid MICROPHONE_ARRAY = new Guid("DFF21BE5-F70F-11D0-B917-00A0C9223196");
        public static Guid PROCESSING_MICROPHONE_ARRAY = new Guid("DFF21BE6-F70F-11D0-B917-00A0C9223196");
        public static Guid OUTPUT_UNDEFINED = new Guid("DFF21CE0-F70F-11D0-B917-00A0C9223196");
        public static Guid SPEAKER = new Guid("DFF21CE1-F70F-11D0-B917-00A0C9223196");
        public static Guid HEADPHONES = new Guid("DFF21CE2-F70F-11D0-B917-00A0C9223196");
        public static Guid HEAD_MOUNTED_DISPLAY_AUDIO = new Guid("DFF21CE3-F70F-11D0-B917-00A0C9223196");
        public static Guid DESKTOP_SPEAKER = new Guid("DFF21CE4-F70F-11D0-B917-00A0C9223196");
        public static Guid ROOM_SPEAKER = new Guid("DFF21CE5-F70F-11D0-B917-00A0C9223196");
        public static Guid COMMUNICATION_SPEAKER = new Guid("DFF21CE6-F70F-11D0-B917-00A0C9223196");
        public static Guid LOW_FREQUENCY_EFFECTS_SPEAKER = new Guid("DFF21CE7-F70F-11D0-B917-00A0C9223196");
        public static Guid BIDIRECTIONAL_UNDEFINED = new Guid("DFF21DE0-F70F-11D0-B917-00A0C9223196");
        public static Guid HANDSET = new Guid("DFF21DE1-F70F-11D0-B917-00A0C9223196");
        public static Guid HEADSET = new Guid("DFF21DE2-F70F-11D0-B917-00A0C9223196");
        public static Guid SPEAKERPHONE_NO_ECHO_REDUCTION = new Guid("DFF21DE3-F70F-11D0-B917-00A0C9223196");
        public static Guid ECHO_SUPPRESSING_SPEAKERPHONE = new Guid("DFF21DE4-F70F-11D0-B917-00A0C9223196");
        public static Guid ECHO_CANCELING_SPEAKERPHONE = new Guid("DFF21DE5-F70F-11D0-B917-00A0C9223196");
        public static Guid TELEPHONY_UNDEFINED = new Guid("DFF21EE0-F70F-11D0-B917-00A0C9223196");
        public static Guid PHONE_LINE = new Guid("DFF21EE1-F70F-11D0-B917-00A0C9223196");
        public static Guid TELEPHONE = new Guid("DFF21EE2-F70F-11D0-B917-00A0C9223196");
        public static Guid DOWN_LINE_PHONE = new Guid("DFF21EE3-F70F-11D0-B917-00A0C9223196");
        public static Guid EXTERNAL_UNDEFINED = new Guid("DFF21FE0-F70F-11D0-B917-00A0C9223196");
        public static Guid ANALOG_CONNECTOR = new Guid("DFF21FE1-F70F-11D0-B917-00A0C9223196");
        public static Guid DIGITAL_AUDIO_INTERFACE = new Guid("DFF21FE2-F70F-11D0-B917-00A0C9223196");
        public static Guid LINE_CONNECTOR = new Guid("DFF21FE3-F70F-11D0-B917-00A0C9223196");
        public static Guid LEGACY_AUDIO_CONNECTOR = new Guid("DFF21FE4-F70F-11D0-B917-00A0C9223196");
        public static Guid SPDIF_INTERFACE = new Guid("DFF21FE5-F70F-11D0-B917-00A0C9223196");
        public static Guid DA_STREAM_1394 = new Guid("DFF21FE6-F70F-11D0-B917-00A0C9223196");
        public static Guid DV_STREAM_1394_SOUNDTRACK = new Guid("DFF21FE7-F70F-11D0-B917-00A0C9223196");
        public static Guid EMBEDDED_UNDEFINED = new Guid("DFF220E0-F70F-11D0-B917-00A0C9223196");
        public static Guid LEVEL_CALIBRATION_NOISE_SOURCE = new Guid("DFF220E1-F70F-11D0-B917-00A0C9223196");
        public static Guid EQUALIZATION_NOISE = new Guid("DFF220E2-F70F-11D0-B917-00A0C9223196");
        public static Guid CD_PLAYER = new Guid("DFF220E3-F70F-11D0-B917-00A0C9223196");
        public static Guid DAT_IO_DIGITAL_AUDIO_TAPE = new Guid("DFF220E4-F70F-11D0-B917-00A0C9223196");
        public static Guid DCC_IO_DIGITAL_COMPACT_CASSETTE = new Guid("DFF220E5-F70F-11D0-B917-00A0C9223196");
        public static Guid MINIDISK = new Guid("DFF220E6-F70F-11D0-B917-00A0C9223196");
        public static Guid ANALOG_TAPE = new Guid("DFF220E7-F70F-11D0-B917-00A0C9223196");
        public static Guid PHONOGRAPH = new Guid("DFF220E8-F70F-11D0-B917-00A0C9223196");
        public static Guid VCR_AUDIO = new Guid("DFF220E9-F70F-11D0-B917-00A0C9223196");
        public static Guid VIDEO_DISC_AUDIO = new Guid("DFF220EA-F70F-11D0-B917-00A0C9223196");
        public static Guid DVD_AUDIO = new Guid("DFF220EB-F70F-11D0-B917-00A0C9223196");
        public static Guid TV_TUNER_AUDIO = new Guid("DFF220EC-F70F-11D0-B917-00A0C9223196");
        public static Guid SATELLITE_RECEIVER_AUDIO = new Guid("DFF220ED-F70F-11D0-B917-00A0C9223196");
        public static Guid CABLE_TUNER_AUDIO = new Guid("DFF220EE-F70F-11D0-B917-00A0C9223196");
        public static Guid DSS_AUDIO = new Guid("DFF220EF-F70F-11D0-B917-00A0C9223196");
        public static Guid RADIO_RECEIVER = new Guid("DFF220F0-F70F-11D0-B917-00A0C9223196");
        public static Guid RADIO_TRANSMITTER = new Guid("DFF220F1-F70F-11D0-B917-00A0C9223196");
        public static Guid MULTITRACK_RECORDER = new Guid("DFF220F2-F70F-11D0-B917-00A0C9223196");
        public static Guid SYNTHESIZER = new Guid("DFF220F3-F70F-11D0-B917-00A0C9223196");
        public static Guid HDMI_INTERFACE = new Guid("D1B9CC2A-F519-417f-91C9-55FA65481001");
        public static Guid DISPLAYPORT_INTERFACE = new Guid("E47E4031-3EA6-418d-8F9B-B73843CCBA97");
        public static Guid MIDI_JACK = new Guid("265E0C3F-FA39-4df3-AB04-BE01B91E299A");
        public static Guid MIDI_ELEMENT = new Guid("01C6FE66-6E48-4c65-AC9B-52DB5D656C7E");
        public static Guid SWSYNTH = new Guid("423274A0-8B81-11D1-A050-0000F8004788");
        public static Guid SWMIDI = new Guid("CB9BEFA0-A251-11D1-A050-0000F8004788");
        public static Guid DRM_DESCRAMBLE = new Guid("FFBB6E3F-CCFE-4D84-90D9-421418B03A8E");
        public static Guid DAC = new Guid("507AE360-C554-11D0-8A2B-00A0C9255AC1");
        public static Guid ADC = new Guid("4D837FE0-C555-11D0-8A2B-00A0C9255AC1");
        public static Guid SRC = new Guid("9DB7B9E0-C555-11D0-8A2B-00A0C9255AC1");
        public static Guid SUPERMIX = new Guid("E573ADC0-C555-11D0-8A2B-00A0C9255AC1");
        public static Guid MUX = new Guid("2CEAF780-C556-11D0-8A2B-00A0C9255AC1");
        public static Guid DEMUX = new Guid("C0EB67D4-E807-11D0-958A-00C04FB925D3");
        public static Guid SUM = new Guid("DA441A60-C556-11D0-8A2B-00A0C9255AC1");
        public static Guid MUTE = new Guid("02B223C0-C557-11D0-8A2B-00A0C9255AC1");
        public static Guid VOLUME = new Guid("3A5ACC00-C557-11D0-8A2B-00A0C9255AC1");
        public static Guid TONE = new Guid("7607E580-C557-11D0-8A2B-00A0C9255AC1");
        public static Guid EQUALIZER = new Guid("9D41B4A0-C557-11D0-8A2B-00A0C9255AC1");
        public static Guid AGC = new Guid("E88C9BA0-C557-11D0-8A2B-00A0C9255AC1");
        public static Guid NOISE_SUPPRESS = new Guid("E07F903F-62FD-4e60-8CDD-DEA7236665B5");
        public static Guid DELAY = new Guid("144981E0-C558-11D0-8A2B-00A0C9255AC1");
        public static Guid LOUDNESS = new Guid("41887440-C558-11D0-8A2B-00A0C9255AC1");
        public static Guid PROLOGIC_DECODER = new Guid("831C2C80-C558-11D0-8A2B-00A0C9255AC1");
        public static Guid STEREO_WIDE = new Guid("A9E69800-C558-11D0-8A2B-00A0C9255AC1");
        public static Guid REVERB = new Guid("EF0328E0-C558-11D0-8A2B-00A0C9255AC1");
        public static Guid CHORUS = new Guid("20173F20-C559-11D0-8A2B-00A0C9255AC1");
        public static Guid EFFECTS_3D = new Guid("55515860-C559-11D0-8A2B-00A0C9255AC1");
        public static Guid PARAMETRIC_EQUALIZER = new Guid("19BB3A6A-CE2B-4442-87EC-6727C3CAB477");
        public static Guid UPDOWN_MIX = new Guid("B7EDC5CF-7B63-4ee2-A100-29EE2CB6B2DE");
        public static Guid DYN_RANGE_COMPRESSOR = new Guid("08C8A6A8-601F-4af8-8793-D905FF4CA97D");
        public static Guid DEV_SPECIFIC = new Guid("941C7AC0-C559-11D0-8A2B-00A0C9255AC1");
        public static Guid PROLOGIC_ENCODER = new Guid("8074C5B2-3C66-11D2-B45A-3078302C2030");
        public static Guid PEAKMETER = new Guid("A085651E-5F0D-4b36-A869-D195D6AB4B9E");
        public static Guid SURROUND_ENCODER = new Guid("8074C5B2-3C66-11D2-B45A-3078302C2030");
        public static Guid VIDEO_STREAMING = new Guid("DFF229E1-F70F-11D0-B917-00A0C9223196");
        public static Guid VIDEO_INPUT_TERMINAL = new Guid("DFF229E2-F70F-11D0-B917-00A0C9223196");
        public static Guid VIDEO_OUTPUT_TERMINAL = new Guid("DFF229E3-F70F-11D0-B917-00A0C9223196");
        public static Guid VIDEO_SELECTOR = new Guid("DFF229E4-F70F-11D0-B917-00A0C9223196");
        public static Guid VIDEO_PROCESSING = new Guid("DFF229E5-F70F-11D0-B917-00A0C9223196");
        public static Guid VIDEO_CAMERA_TERMINAL = new Guid("DFF229E6-F70F-11D0-B917-00A0C9223196");
        public static Guid VIDEO_INPUT_MTT = new Guid("DFF229E7-F70F-11D0-B917-00A0C9223196");
        public static Guid VIDEO_OUTPUT_MTT = new Guid("DFF229E8-F70F-11D0-B917-00A0C9223196");
    }
}
