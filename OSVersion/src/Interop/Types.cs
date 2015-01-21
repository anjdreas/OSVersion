﻿// ReSharper disable InconsistentNaming

using System;
using System.Runtime.InteropServices;

namespace OSVersionUtils.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal class OSVERSIONINFO
    {
        public int OSVersionInfoSize;
        public int MajorVersion;
        public int MinorVersion;
        public int BuildNumber;
        public int PlatformId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)] public string CSDVersion;

        public OSVERSIONINFO()
        {
            OSVersionInfoSize = Marshal.SizeOf(this);
        }

        private void StopTheCompilerComplaining()
        {
            MajorVersion = 0;
            MinorVersion = 0;
            BuildNumber = 0;
            PlatformId = 0;
            CSDVersion = String.Empty;
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal class OSVERSIONINFOEX
    {
        public int OSVersionInfoSize;
        public int MajorVersion;
        public int MinorVersion;
        public int BuildNumber;
        public int PlatformId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)] public string CSDVersion;
        public Int16 ServicePackMajor;
        public Int16 ServicePackMinor;
        public UInt16 SuiteMask;
        public byte ProductType;
        public byte Reserved;

        public OSVERSIONINFOEX()
        {
            OSVersionInfoSize = Marshal.SizeOf(this);
        }

        private void StopTheCompilerComplaining()
        {
            MajorVersion = 0;
            MinorVersion = 0;
            BuildNumber = 0;
            PlatformId = 0;
            CSDVersion = String.Empty;
            ServicePackMajor = 0;
            ServicePackMinor = 0;
            SuiteMask = 0;
            ProductType = 0;
            Reserved = 0;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct SYSTEM_INFO
    {
        internal readonly _PROCESSOR_INFO_UNION uProcessorInfo;
        public readonly uint dwPageSize;
        public readonly IntPtr lpMinimumApplicationAddress;
        public readonly IntPtr lpMaximumApplicationAddress;
        public readonly IntPtr dwActiveProcessorMask;
        public readonly uint dwNumberOfProcessors;
        public readonly uint dwProcessorType;
        public readonly uint dwAllocationGranularity;
        public readonly ushort dwProcessorLevel;
        public readonly ushort dwProcessorRevision;
    }

    [StructLayout(LayoutKind.Explicit)]
    internal struct _PROCESSOR_INFO_UNION
    {
        [FieldOffset(0)] internal readonly uint dwOemId;
        [FieldOffset(0)] internal readonly ushort wProcessorArchitecture;
        [FieldOffset(2)] internal readonly ushort wReserved;
    }

    //-----------------------------------------------------------------------------
    // Interop constants

    internal class VerPlatformId
    {
        public const Int32 Win32s = 0;
        public const Int32 Win32Windows = 1;
        public const Int32 Win32NT = 2;
        public const Int32 WinCE = 3;

        private VerPlatformId()
        {
        }
    }

    internal class VerSuiteMask
    {
        public const UInt32 VER_SERVER_NT = 0x80000000;
        public const UInt32 VER_WORKSTATION_NT = 0x40000000;
        public const UInt16 VER_SUITE_SMALLBUSINESS = 0x00000001;
        public const UInt16 VER_SUITE_ENTERPRISE = 0x00000002;
        public const UInt16 VER_SUITE_BACKOFFICE = 0x00000004;
        public const UInt16 VER_SUITE_COMMUNICATIONS = 0x00000008;
        public const UInt16 VER_SUITE_TERMINAL = 0x00000010;
        public const UInt16 VER_SUITE_SMALLBUSINESS_RESTRICTED = 0x00000020;
        public const UInt16 VER_SUITE_EMBEDDEDNT = 0x00000040;
        public const UInt16 VER_SUITE_DATACENTER = 0x00000080;
        public const UInt16 VER_SUITE_SINGLEUSERTS = 0x00000100;
        public const UInt16 VER_SUITE_PERSONAL = 0x00000200;
        public const UInt16 VER_SUITE_BLADE = 0x00000400;
        public const UInt16 VER_SUITE_EMBEDDED_RESTRICTED = 0x00000800;

        private VerSuiteMask()
        {
        }
    }

    internal class VerProductType
    {
        public const byte VER_NT_WORKSTATION = 0x00000001;
        public const byte VER_NT_DOMAIN_CONTROLLER = 0x00000002;
        public const byte VER_NT_SERVER = 0x00000003;

        private VerProductType()
        {
        }
    }

    internal class VerArchitecture
    {
        public const ushort INTEL = 0;
        //public const ushort MIPS = 1;
        //public const ushort ALPHA = 2;
        //public const ushort PPC = 3;
        //public const ushort SHX = 4;
        //public const ushort ARM = 5;
        public const ushort IA64 = 6;
        //public const ushort ALPHA64 = 7;
        //public const ushort MSIL = 8;
        public const ushort AMD64 = 9;
        //public const ushort IA32_ON_WIN64 = 10;

        public const ushort UNKNOWN = 0xFFFF;

        private VerArchitecture()
        {
        }
    }
}