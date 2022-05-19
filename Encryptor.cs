using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


public static class Encrypt
{

    static byte[] KEY = null;
    static byte[] IV = null;
    static byte[] payload = null;
       
    private static byte[] EncryptBytes(IEnumerable<byte> bytes)
    {
        //The ICryptoTransform is created for each call to this method as the MSDN documentation indicates that the public methods may not be thread-safe and so we cannot hold a static reference to an instance
        using (var r = Rijndael.Create())
        {
            using (var encryptor = r.CreateEncryptor(KEY, IV))
            {
                return Transform(bytes, encryptor);
            }
        }
    }
    private static byte[] DecryptBytes(IEnumerable<byte> bytes)
    {
        //The ICryptoTransform is created for each call to this method as the MSDN documentation indicates that the public methods may not be thread-safe and so we cannot hold a static reference to an instance
        using (var r = Rijndael.Create())
        {
            using (var decryptor = r.CreateDecryptor(KEY, IV))
            {
                return Transform(bytes, decryptor);
            }
        }
    }
    private static byte[] Transform(IEnumerable<byte> bytes, ICryptoTransform transform)
    {
        using (var stream = new MemoryStream())
        {
            using (var cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write))
            {
                foreach (var b in bytes)
                    cryptoStream.WriteByte(b);
            }

            return stream.ToArray();
        }
    }
    private static class Encryption_Class
    {
        public static string Encrypt(string key, string data)
        {
            Encoding unicode = Encoding.Unicode;

            return Convert.ToBase64String(Encrypt(unicode.GetBytes(key), unicode.GetBytes(data)));
        }

        public static string Decrypt(string key, string data)
        {
            Encoding unicode = Encoding.Unicode;

            return unicode.GetString(Encrypt(unicode.GetBytes(key), Convert.FromBase64String(data)));
        }

        public static byte[] Encrypt(byte[] key, byte[] data)
        {
            return EncryptOutput(key, data).ToArray();
        }

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



}
