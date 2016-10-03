﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DetectKeyboard.Win32Wrap
{
    /// <summary>
    /// Enumeration containing the flags for raw mouse data.
    /// </summary>
    [Flags()]
    public enum RawMouseFlags
        : ushort
    {
        /// <summary>Relative to the last position.</summary>
        MoveRelative = 0,
        /// <summary>Absolute positioning.</summary>
        MoveAbsolute = 1,
        /// <summary>Coordinate data is mapped to a virtual desktop.</summary>
        VirtualDesktop = 2,
        /// <summary>Attributes for the mouse have changed.</summary>
        AttributesChanged = 4
    }
}
