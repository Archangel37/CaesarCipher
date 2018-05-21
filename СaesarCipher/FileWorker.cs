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
        ///     Шифрует выбранный файл со сдвигом
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
        ///     Дешифрует выбранный файл со сдвигом
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

    }
}
