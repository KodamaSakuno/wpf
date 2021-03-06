// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Windows.Threading;
using System.Security;
using System.Security.Permissions;

using System.Windows.Media;
using System.Runtime.InteropServices;
using MS.Win32;

namespace System.Windows.Interop
{
    /// <summary>
    ///     Defines the contract for Win32 window handles.
    /// </summary>
    public interface IWin32Window
    {
        /// <summary>
        ///     Handle to the window.
        /// </summary>
        /// <SecurityNote>
        ///   Critical: This code should not be subclassed by third party code in partial trust
        ///   PublicOK: This has an inheritance demandd
        /// </SecurityNote>
        IntPtr Handle
        {
            [UIPermission(SecurityAction.InheritanceDemand,Window = UIPermissionWindow.AllWindows)]
            get;
        }
    }
}

