using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace InoxWind.CommonClass
{
    public class QueryStringHelper
    {
        private static readonly string key = "Inox-developed-via-vijay"; // Must be 16, 24, or 32 bytes long

        public static string Encrypt(string plainText)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.GenerateIV();

                var iv = aes.IV;
                using (var ms = new MemoryStream())
                {
                    ms.Write(iv, 0, iv.Length);
                    using (var cryptoStream = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (var writer = new StreamWriter(cryptoStream))
                        {
                            writer.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }
        public static Dictionary<string, object> Decrypt(string cipherText)
        {
            Dictionary<string, object> QeryStringParam = new Dictionary<string, object>();
            var fullCipher = Convert.FromBase64String(cipherText);
            using (var aes = Aes.Create())
            {
                var iv = new byte[16];
                Array.Copy(fullCipher, 0, iv, 0, iv.Length);
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                using (var ms = new MemoryStream(fullCipher, iv.Length, fullCipher.Length - iv.Length))
                {
                    using (var cryptoStream = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (var reader = new StreamReader(cryptoStream))
                        {
                            string plainText = reader.ReadToEnd();
                            string[] split = plainText.Split('&');
                            if (split.Length > 0)
                            {
                                foreach (string str in split)
                                {
                                    QeryStringParam.Add(str.Split('=')[0], str.Split('=')[1]);
                                }

                            }
                        }
                    }
                }
            }
            return QeryStringParam;
        }
    }
}