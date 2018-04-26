using System.Collections.Generic;
using System.Linq;

namespace СaesarCipher
{
    class EncoderDecoder
    {
        /// <summary>
        ///     Лист с необходимыми алфавитами, можно добавить и символы и всё прочее
        /// </summary>
        private readonly List<string> Alphabets = new List<string>
        {
            "abcdefghijklmnopqrstuvwxyz",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            "абвгдеёжзийклмнопрстуфхцчшщъыьэюя",
            "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"
        };

        /// <summary>
        ///     Кодирование при помощи алгоритма Цезаря
        /// </summary>
        /// <param name="input">Любой текст ("открытый текст")</param>
        /// <param name="shift">Сдвиг - любое целое число от int.MinValue до int.MaxValue</param>
        /// <returns></returns>
        public string Code(string input, int shift)
        {
            string Result = string.Empty;
            foreach (char ch in input)
            {
                if (Alphabets.Any(alph => alph.Contains(ch)))
                {
                    string temp_alph = Alphabets.First(alph => alph.Contains(ch));
                    int index = (temp_alph.IndexOf(ch) + shift) % temp_alph.Length >= 0 ?
                                (temp_alph.IndexOf(ch) + shift) % temp_alph.Length
                                : temp_alph.Length + (temp_alph.IndexOf(ch) + shift) % temp_alph.Length;
                    Result += temp_alph[index].ToString();
                }
                else Result += ch;
            }
            return Result;
        }

        /// <summary>
        ///     Расшифровка закодированного, по факту шифровка, но с противоположным сдвигом
        /// </summary>
        /// <param name="input">Любой шифр-текст ("шифр-текст")</param>
        /// <param name="shift">Сдвиг - любое целое число от int.MinValue до int.MaxValue - для дешифрации должен быть заранее определён</param>
        /// <returns></returns>
        public string Decode(string input, int shift)
        {
            return Code(input,-shift);
        }
    }
}
