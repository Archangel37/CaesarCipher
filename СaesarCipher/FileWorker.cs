using System.IO;
using System.Text;
using System.Windows.Forms;

namespace СaesarCipher
{
    /// <summary>
    ///     Класс для работы с файлами - кодирование-декодирование
    /// </summary>
    internal static class FileWorker
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
                (o, args) => { MessageBox.Show("Coding Done!"); });
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
                (o, args) => { MessageBox.Show("Decoding Done!"); });
        }

        /// <summary>
        ///     Шифрует выбранный файл алгоритмом Вижинера, за основу ключа шифрования - мак-адрес и серийник раздела, где файл
        /// </summary>
        public static void CodeFileVigenere(byte[] key)
        {
            string path = PickUpFile();
            if (path == null) return;
            Worker.ExecuteBW((o, args) =>
                {
                    byte[] array = File.ReadAllBytes(path);
                    File.WriteAllBytes(path, ChiffreDeVigenere.CodeVigenere(array, key, true));
                },
                (o, args) => { MessageBox.Show("Coding Chiffre De Vigenere Done!"); });
        }

        /// <summary>
        ///     Дешифрует выбранный файл алгоритмом Вижинера, за основу ключа шифрования - мак-адрес и серийник раздела, где файл
        /// </summary>
        public static void DecodeFileVigenere(byte[] key)
        {
            string path = PickUpFile();
            if(path == null) return;
            Worker.ExecuteBW((o, args) =>
                {
                    byte[] array = File.ReadAllBytes(path);
                    File.WriteAllBytes(path, ChiffreDeVigenere.CodeVigenere(array, key, false));
                },
                (o, args) => { MessageBox.Show("Decoding Chiffre De Vigenere Done!"); });
        }
    }
}