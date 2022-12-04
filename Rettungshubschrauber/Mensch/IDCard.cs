using System.Security.Cryptography;
using System;
using System.IO;
using Microsoft.VisualBasic;

namespace Rettungshubschrauber.Mensch;

public class IDCard : IIDCard
{
    protected DateTime expirationDate;
    protected int pin;
    protected byte[] encrypted;

    public IDCard()
    {
        Random random = new Random();
        pin = random.Next(1000,9999);
        expirationDate = new DateTime(random.Next(2023, 2026), random.Next(1, 12), random.Next(1, 28));
        using (Aes myAes = Aes.Create())
        {
            byte[] encrypted = EncryptStringToBytes_Aes(pin.ToString(), myAes.Key, myAes.IV);
        }
    }

    public IDCard(int pin)
    {
        this.pin = pin;
        Random random = new Random();
        expirationDate = new DateTime(random.Next(2023, 2026), random.Next(1, 12), random.Next(1, 28));
        using (Aes myAes = Aes.Create())
        {
            byte[] encrypted = EncryptStringToBytes_Aes(pin.ToString(), myAes.Key, myAes.IV);
        }
    }

    static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
    {
        if (plainText == null || plainText.Length <= 0)
            throw new ArgumentNullException("plainText");
        if (Key == null || Key.Length <= 0)
            throw new ArgumentNullException("Key");
        if (IV == null || IV.Length <= 0)
            throw new ArgumentNullException("IV");
        byte[] encrypted;

        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Key;
            aesAlg.IV = IV;

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    encrypted = msEncrypt.ToArray();
                }
            }
        }

        return encrypted;
    }

    static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
    {
        if (cipherText == null || cipherText.Length <= 0)
            throw new ArgumentNullException("cipherText");
        if (Key == null || Key.Length <= 0)
            throw new ArgumentNullException("Key");
        if (IV == null || IV.Length <= 0)
            throw new ArgumentNullException("IV");

        string plaintext = null;

        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Key;
            aesAlg.IV = IV;

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
        }

        return plaintext;
    }
}