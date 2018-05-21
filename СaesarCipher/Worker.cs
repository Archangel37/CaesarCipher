using System.ComponentModel;

namespace СaesarCipher
{
    static class Worker
    {
        /// <summary>
        ///     Запускает процесс с помощью бэкграунд воркера 
        /// </summary>
        /// <param name="doWork">Что нужно сделать</param>
        /// <param name="runWorkerCompleted">что нужно сделать по окончании doWork</param>
        ///     Класс придумывал сам, взято не из интернета, возможны косяки, плюс такое не работает с прогрессом
        public static void ExecuteBW(DoWorkEventHandler doWork, RunWorkerCompletedEventHandler runWorkerCompleted = null)
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += doWork;
            backgroundWorker.RunWorkerCompleted += runWorkerCompleted;
            backgroundWorker.RunWorkerAsync();
        }
    }
}
