using System.Collections.Generic;
using System.Linq;

namespace СaesarCipher
{
    /// <summary>
    ///     Статический класс для работы с шифром Вижинера
    /// </summary>
    static class ChiffreDeVigenere
    {
        /// <summary>
        ///     Используемые алфавиты
        /// </summary>
        private static List<string> Alphabets = new List<string>
        {
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            "abcdefghijklmnopqrstuvwxyz",
            "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ",
            "абвгдеёжзийклмнопрстуфхцчшщъыьэюя",
            "0123456789",
            "!@#$%^&*()\"№;%:?<>,./'\\-+`~=_{}[]|"
        };

        /// <summary>
        ///     Кодирование-декодирование алгоритмом Вижинера
        /// </summary>
        /// <param name="input">Исходный текст</param>
        /// <param name="key">Ключ шифрования</param>
        /// <param name="code">Кодируем/декодируем, true - для кодирования</param>
        /// <returns></returns>
        public static string CodeVigenere(string input, string key, bool code)
        {
            string result = string.Empty;
            int _keyIndex = 0;

            foreach (var ch in input)
            {
                if (Alphabets.Any(alph => alph.Contains(ch)))
                {
                    int shift = int.Parse(key[_keyIndex].ToString());
                    //кодер-декодер, разница в знаке сдвига
                    shift = code ? shift : -shift;
                    string temp_alph = Alphabets.First(alph => alph.Contains(ch));
                    int index = (temp_alph.IndexOf(ch) + shift) % temp_alph.Length >= 0 ?
                                (temp_alph.IndexOf(ch) + shift) % temp_alph.Length
                                : temp_alph.Length + (temp_alph.IndexOf(ch) + shift) % temp_alph.Length;
                    result += temp_alph[index];

                    _keyIndex++;
                    if (_keyIndex == key.Length) _keyIndex = 0;
                }
                else
                    result += ch;
            }
            return result;
        }
    }
}
