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
        ///     Кодирование-декодирование алгоритмом Вижинера
        /// </summary>
        /// <param name="input">Исходный текст</param>
        /// <param name="key">Ключ шифрования</param>
        /// <param name="code">Кодируем/декодируем, true - для кодирования</param>
        /// <returns></returns>
        public static byte[] CodeVigenere(byte[] input, byte[] key, bool code)
        {
            List<byte> result = new List<byte>();
            int _keyIndex = 0;

            foreach (var b in input)
            {
                byte temp = code
                    ? (byte) ((b + key[_keyIndex]) % byte.MaxValue)
                    : (byte) Math.Abs((b - key[_keyIndex]) % byte.MaxValue);
                result.Add(temp);
            }
            return result.ToArray();
        }
    }
}
