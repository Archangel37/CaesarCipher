using System.Collections.Generic;
using System.Linq;

namespace СaesarCipher
{
    static class EncoderDecoder
    {
        /// <summary>
        ///     Лист с необходимыми алфавитами, можно добавить и символы и всё прочее
        /// </summary>
        private static List<string> Alphabets = new List<string>
        {
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"
        };

        /// <summary>
        ///     Добавление нижнего регистра к уже имеющимся алфавитам
        /// </summary>
        private static void AddLowersToAlphabet()
        {
            if (Alphabets.Contains(Alphabets[0].ToLower()) || Alphabets.Contains(Alphabets[1].ToLower())) return;
            int counter = Alphabets.Count;
            for (int i = 0; i < counter; i++)
            {
                Alphabets.Add(Alphabets[i].ToLower());
            }
        }

        /// <summary>
        ///     Кодирование при помощи алгоритма Цезаря
        /// </summary>
        /// <param name="input">Любой текст ("открытый текст")</param>
        /// <param name="shift">Сдвиг - любое целое число от int.MinValue до int.MaxValue</param>
        /// <returns></returns>
        public static string Code(string input, int shift)
        {
            string Result = string.Empty;
            AddLowersToAlphabet();

            foreach (char ch in input)
            {
                if (Alphabets.Any(alph => alph.Contains(ch)))
                {
                    string temp_alph = Alphabets.First(alph => alph.Contains(ch));
                    int index = (temp_alph.IndexOf(ch) + shift) % temp_alph.Length >= 0 ?
                                (temp_alph.IndexOf(ch) + shift) % temp_alph.Length
                                : temp_alph.Length + (temp_alph.IndexOf(ch) + shift) % temp_alph.Length;
                    Result += temp_alph[index];
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
        public static string Decode(string input, int shift)
        {
            return Code(input,-shift);
        }
    }
}
