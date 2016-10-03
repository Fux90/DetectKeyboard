using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

using DetectKeyboard.Win32Wrap;
using System.Windows.Forms;
using DetectKeyboard.MessageFilters;

namespace DetectKeyboard
{
    public class Model
    {
        static RawInputFiltering rawInputFiltering;

        // Source: www.pinvoke.net
        // A convenient function for getting all raw input devices.
        // This method will get all devices, including virtual devices
        // For remote desktop and any other device driver that's registered
        // as such a device.
        public static RawInputDeviceList[] GetAllRawDevices()
        {
            uint deviceCount = 0;
            uint dwSize = (uint)Marshal.SizeOf(typeof(RawInputDeviceList));

            // First call the system routine with a null pointer
            // for the array to get the size needed for the list
            uint retValue = Win32MinimalWrap.GetRawInputDeviceList(null, ref deviceCount, dwSize);

            // If anything but zero is returned, the call failed, so return a null list
            if (0 != retValue)
                return null;

            // Now allocate an array of the specified number of entries
            var deviceList = new RawInputDeviceList[deviceCount];

            // Now make the call again, using the array
            retValue = Win32MinimalWrap.GetRawInputDeviceList(deviceList, ref deviceCount, dwSize);

            // Free up the memory we first got the information into as
            // it is no longer needed, since the structures have been 
            // copied to the deviceList array.
            //IntPtr pRawInputDeviceList = Marshal.AllocHGlobal((int)(dwSize * deviceCount));
            //Marshal.FreeHGlobal(pRawInputDeviceList);

            // Finally, return the filled in list
            return deviceList;
        }

        public static string DescriptionFromInputList(RawInputDeviceList[] deviceList)
        {
            var str = new StringBuilder();

            str.AppendLine(String.Format("{0} items found", deviceList.Length));

            for (int i = 0; i < deviceList.Length; i++)
            {
                str.AppendLine(DescriptionFromInputList(deviceList[i]));
            }

            return str.ToString();
        }

        private static string DescriptionFromInputList(RawInputDeviceList deviceList)
        {
            return String.Format("-> {0} [{1}]", deviceList.Type, deviceList.hDevice);
        }

        public static void RegisterKeyboardRawInput()
        {
            var rid = new RawInputDevice[1];

            rid[0].UsagePage = HIDUsagePage.Generic;
            rid[0].Usage = HIDUsage.Keyboard;
            rid[0].Flags = RawInputDeviceFlags.NoLegacy;
            rid[0].WindowHandle = IntPtr.Zero;

            if (Win32MinimalWrap.RegisterRawInputDevices(rid, rid.Length, Marshal.SizeOf(rid[0])) == false) 
            {
                //registration failed. Call GetLastError for the cause of the error
                throw new Exception("Registration failed");
            }
        }

        public static void RegisterCustomFiltering(Form form)
        {
            rawInputFiltering = new RawInputFiltering(form);
            Application.AddMessageFilter(rawInputFiltering);
        }

        public static string ToggleKeyboardInitialization()
        {
            if (rawInputFiltering.Initializing)
            {
                rawInputFiltering.Initializing = false;
                return "Initialize";
            }
            else
            {
                rawInputFiltering.Initializing = true;
                return "Stop Initialization";
            }
        }
    }
}
