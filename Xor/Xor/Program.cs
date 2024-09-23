using System;
using static System.Console;

namespace XorCipher
{
    public static class Program
    {
        // Function to handle encryption
        static string EncryptDecrypt(string text, string key)
        {
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                result[i] = (char)(text[i] ^ key[i % key.Length]); // XOR each character with the key
            }

            return new string(result);
        }

        // main function
        public static void Main()
        {
            // Variables
            var option = 0;
            string key, text;

            WriteLine("*** XOR CIPHER ***");
            WriteLine("1. Encrypt text");
            WriteLine("2. Decrypt text");

            option = Convert.ToInt32(ReadLine());

            switch (option)
            {
                case 1:
                    WriteLine("*** Encryption ***");
                    WriteLine("Enter string of Text:");
                    text = ReadLine();
                    WriteLine("Enter Key:");
                    key = ReadLine();

                    // Perform encryption
                    string encryptedText = EncryptDecrypt(text, key);
                    WriteLine($"Encrypted text: {encryptedText}");
                    break;

                case 2:
                    WriteLine("*** Decryption ***");
                    WriteLine("Enter encrypted Text:");
                    text = ReadLine();
                    WriteLine("Enter Key:");
                    key = ReadLine();

                    // Perform decryption (XOR decryption is the same as encryption)
                    string decryptedText = EncryptDecrypt(text, key);
                    WriteLine($"Decrypted text: {decryptedText}");
                    break;

                default:
                    WriteLine("\nInvalid option");
                    break;
            }
        }
    }
}