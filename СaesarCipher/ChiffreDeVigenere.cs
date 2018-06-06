using System;
using System.Collections.Generic;

namespace СaesarCipher
{
    /// <summary>
    ///     Статический класс для работы с шифром Вижинера
    /// </summary>
    static class ChiffreDeVigenere
    {
        /// <summary>
        ///     Кодирование алгоритмом Вижинера
        /// </summary>
        /// <param name="input">Исходный текст</param>
        /// <param name="key">Ключ шифрования</param>
        /// <returns></returns>
        public static byte[] CodeVigenere(byte[] input, byte[] key)
        {
            var result = new List<byte>();
            int _keyIndex = 0;

            foreach (var b in input)
            {
                result.Add((byte)((b + key[_keyIndex]) % (byte.MaxValue + 1)));
                _keyIndex++;
                if (_keyIndex == key.Length) _keyIndex = 0;
            }
            return result.ToArray();
        }

        /// <summary>
        ///     Декодирование алгоритмом Вижинера
        /// </summary>
        /// <param name="input">Исходный текст</param>
        /// <param name="key">Ключ шифрования</param>
        /// <returns></returns>
        public static byte[] DecodeVigenere(byte[] input, byte[] key)
        {
            var result = new List<byte>();
            int _keyIndex = 0;

            foreach (var b in input)
            {
                result.Add((byte)((b - key[_keyIndex] + byte.MaxValue + 1) % (byte.MaxValue + 1)));
                _keyIndex++;
                if (_keyIndex == key.Length) _keyIndex = 0;
            }
            return result.ToArray();
        }
    }
}
