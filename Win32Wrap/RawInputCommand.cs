using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DetectKeyboard.Win32Wrap
{
    /// <summary>
    /// Enumeration contanining the command types to issue.
    /// </summary>
    public enum RawInputCommand
    {
        /// <summary>
        /// Get input data.
        /// </summary>
        Input = 0x10000003,
        /// <summary>
        /// Get header data.
        /// </summary>
        Header = 0x10000005
    }
}
