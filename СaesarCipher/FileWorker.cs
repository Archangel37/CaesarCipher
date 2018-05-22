using System.IO;
using System.Text;
using System.Windows.Forms;

namespace СaesarCipher
{
    /// <summary>
    ///     Класс для работы с файлами - кодирование-декодирование
    /// </summary>
    static class FileWorker
    {
        /// <summary>
        ///     Открывает диалог выбора файла и передаёт полный путь к файлу с именем
        /// </summary>
        /// <returns></returns>
        private static string PickUpFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
                return openFile.FileName;
            return null;
        }

        /// <summary>
        ///     Шифрует выбранный файл со сдвигом (Цезарь)
        /// </summary>
        /// <param name="shift">Числовой сдвиг</param>
        public static void CodeFile(int shift)
        {
            string path = PickUpFile();

            Worker.ExecuteBW((o, args) => 
            {
                string result = EncoderDecoder.Code(File.ReadAllText(path, Encoding.UTF8), shift);
                File.WriteAllText(path, result, Encoding.UTF8);
            },
            (o, args) => 
            {
                MessageBox.Show("Coding Done!");
            });
        }

        /// <summary>
        ///     Дешифрует выбранный файл со сдвигом (Цезарь)
        /// </summary>
        /// <param name="shift">Числовой сдвиг</param>
        public static void DecodeFile(int shift)
        {
            string path = PickUpFile();

            Worker.ExecuteBW((o, args) =>
            {
                string result = EncoderDecoder.Decode(File.ReadAllText(path, Encoding.UTF8), shift);
                File.WriteAllText(path, result, Encoding.UTF8);
            },
            (o, args) =>
            {
                MessageBox.Show($"Decoding Done!");
            });
        }

        /// <summary>
        ///     Шифрует выбранный файл алгоритмом Вижинера, за основу ключа шифрования - мак-адрес и серийник раздела, где файл
        /// </summary>
        public static void CodeFileVigenere()
        {
            string path = PickUpFile();

            Worker.ExecuteBW((o, args) =>
            {
                string result = ChiffreDeVigenere.CodeVigenere(File.ReadAllText(path, Encoding.UTF8), 
                    KeyGenerator.ReturnCode(path), true);
                File.WriteAllText(path, result, Encoding.UTF8);
            },
            (o, args) =>
            {
                MessageBox.Show("Coding Chiffre De Vigenere Done!");
            });
        }

        /// <summary>
        ///     Дешифрует выбранный файл алгоритмом Вижинера, за основу ключа шифрования - мак-адрес и серийник раздела, где файл
        /// </summary>
        public static void DecodeFileVigenere()
        {
            string path = PickUpFile();

            Worker.ExecuteBW((o, args) =>
            {
                string result = ChiffreDeVigenere.CodeVigenere(File.ReadAllText(path, Encoding.UTF8),
                    KeyGenerator.ReturnCode(path), false);
                File.WriteAllText(path, result, Encoding.UTF8);
            },
            (o, args) =>
            {
                MessageBox.Show($"Decoding Chiffre De Vigenere Done!");
            });
        }

    }
}
