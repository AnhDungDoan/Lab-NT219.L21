using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TCP.IPDemo
{
    public class AES
    {
       public static byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public static string EncryptString( string plainText, string key)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(plainText);
            //Encrypt
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.BlockSize = 128;
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(key));
            crypt.IV = IV;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream =
                   new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(bytes, 0, bytes.Length);
                }

                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public static string DecryptString( string cipherText, string key)
        {
            //Decrypt
            byte[] bytes = Convert.FromBase64String(cipherText);
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(key));
            crypt.IV = IV;
            crypt.Padding = PaddingMode.PKCS7;

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                using (CryptoStream cryptoStream =new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedBytes = new byte[bytes.Length];
                    cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                    return Encoding.Unicode.GetString(decryptedBytes);
                }
            }
        }
        //DES
        public static string EncryptData(string strData, string strKey)
        {
            while (strKey.Length < 8)
                strKey += "0";
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            provider.Key = Encoding.ASCII.GetBytes(strKey.Substring(0, 8));
            provider.IV = Encoding.ASCII.GetBytes(strKey.Substring(0, 8));
            byte[] bytes = Encoding.Unicode.GetBytes(strData);

            using (MemoryStream stream = new MemoryStream())
            {
                using (CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    stream2.Write(bytes, 0, bytes.Length);
                }
                return Convert.ToBase64String(stream.ToArray());

            }

        }
        
        public static string DecryptData(string strData, string strKey)
        {
            while (strKey.Length < 8)
                strKey += "0";
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            provider.Padding = PaddingMode.PKCS7;
            provider.Key = Encoding.ASCII.GetBytes(strKey.Substring(0, 8));
            provider.IV = Encoding.ASCII.GetBytes(strKey.Substring(0, 8));

            byte[] bytes = Convert.FromBase64String(strData);
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                using (CryptoStream stream2 = new CryptoStream(stream, provider.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedBytes = new byte[bytes.Length];
                    stream2.Read(decryptedBytes, 0, decryptedBytes.Length);
                    return Encoding.Unicode.GetString(decryptedBytes);

                }
            }    
           
        }


        //TDES
        public static string Encrypt(string source, string key)
        {
            TripleDESCryptoServiceProvider desCryptoProvider = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();

            byte[] byteHash;
            byte[] byteBuff;

            byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
            desCryptoProvider.Key = byteHash;
            desCryptoProvider.Mode = CipherMode.ECB; //CBC, CFB
            byteBuff = Encoding.UTF8.GetBytes(source);

            string encoded =
                Convert.ToBase64String(desCryptoProvider.CreateEncryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            return encoded;
        }
        public static string Decrypt(string encodedText, string key)
        {
            /* byte[] inputArray = Convert.FromBase64String(encodedText);
             TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
             tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
             tripleDES.Mode = CipherMode.ECB;
             tripleDES.Padding = PaddingMode.PKCS7;
             ICryptoTransform cTransform = tripleDES.CreateDecryptor();
             byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
             tripleDES.Clear();
             return UTF8Encoding.UTF8.GetString(resultArray);*/

            TripleDESCryptoServiceProvider desCryptoProvider = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();

            byte[] byteHash;
            byte[] byteBuff;

            byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
            desCryptoProvider.Key = byteHash;
            desCryptoProvider.Mode = CipherMode.ECB; //CBC, CFB
            byteBuff = Convert.FromBase64String(encodedText);

            string plaintext = Encoding.UTF8.GetString(desCryptoProvider.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            return plaintext;
        }
    }
}
