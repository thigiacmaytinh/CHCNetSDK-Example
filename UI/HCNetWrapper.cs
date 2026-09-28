using PreviewDemo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static PreviewDemo.CHCNetSDK;

namespace CameraController
{
    internal class HCNetWrapper
    {
        public static NET_DVR_CAMERAPARAMCFG GetConfig(Int32 m_lRealHandle, int m_lChannel)
        {
            int size = Marshal.SizeOf(typeof(NET_DVR_CAMERAPARAMCFG));
            IntPtr buffer = Marshal.AllocHGlobal(size);

            try
            {
                uint bytesReturned = 0;

                bool result = CHCNetSDK.NET_DVR_GetDVRConfig(
                m_lRealHandle,
                NET_DVR_GET_CCDPARAMCFG,   // 1067
                m_lChannel,
                buffer,
                (uint)size,
                ref bytesReturned);

                if(!result)
                {
                    uint error = NET_DVR_GetLastError();
                    Console.WriteLine($"Get config failed: {error}");
                    throw new InvalidOperationException($"NET_DVR_GetDVRConfig failed with error code {error}.");
                }

                NET_DVR_CAMERAPARAMCFG config = Marshal.PtrToStructure<NET_DVR_CAMERAPARAMCFG>(buffer);

                Console.WriteLine($"Bytes returned: {bytesReturned}");

                return config;
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool MirrorCamera(int lUserID, int lChannel)
        {
            NET_DVR_CAMERAPARAMCFG config = GetConfig(lUserID, lChannel);

            if(config.byMirror == 0)
                config.byMirror = 3;
            else
                config.byMirror = 0;

            int size = Marshal.SizeOf<NET_DVR_CAMERAPARAMCFG>();
            IntPtr buffer = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.StructureToPtr(config, buffer, false);

                return CHCNetSDK.NET_DVR_SetDVRConfig(
                    lUserID,
                    CHCNetSDK.NET_DVR_SET_CCDPARAMCFG, // 1068
                    lChannel,
                    buffer,
                    (uint)size);
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool SetVideoEffect(int lUserID, int lChannel,
            uint brightness, uint contrast, uint saturation, uint hue)
        {
            bool success = NET_DVR_SetVideoEffect(lUserID, lChannel,
                brightness, contrast, saturation, hue);

            return success;
        }
    }
}
