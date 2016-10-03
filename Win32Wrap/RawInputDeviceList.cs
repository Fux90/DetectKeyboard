using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace DetectKeyboard.Win32Wrap
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RawInputDeviceList
    {
        public IntPtr hDevice;
        public RawInputDeviceType Type;
    }
}
