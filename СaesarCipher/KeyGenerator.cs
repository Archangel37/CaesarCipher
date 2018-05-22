using System.Linq;
using System.Net.NetworkInformation;
using System.Management;
using System.IO;

namespace СaesarCipher
{
    /// <summary>
    ///     Статический класс для генерации ключа шифрования
    /// </summary>
    static class KeyGenerator
    {
        /// <summary>
        ///     Получение МАК-адресов машины
        /// </summary>
        /// <returns></returns>
        private static string GetMacAddress()
        {
            string macAddresses = string.Empty;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddresses;
        }

        /// <summary>
        ///     Получение "серийника" раздела
        /// </summary>
        /// <param name="strDriveLetter">Буква раздела</param>
        /// <returns></returns>
        private static string GetVolumeSerial(string strDriveLetter = null)
        {
            if (string.IsNullOrWhiteSpace(strDriveLetter)) strDriveLetter = "C";
            ManagementObject disk =
                new ManagementObject("win32_logicaldisk.deviceid=\"" + strDriveLetter + ":\"");
            disk.Get();
            return disk["VolumeSerialNumber"].ToString();
        }

        /// <summary>
        ///     Получение ключа шифрования, основанного на МАК-адресах, "серийнике" раздела, куда попадает файл и времени создания файла
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ReturnCode(string path)
        {
            string HardwarePlusFileCode = GetVolumeSerial(path[0].ToString()) + GetMacAddress()+ File.GetCreationTime(path).ToOADate().ToString();
            var tmp = HardwarePlusFileCode.Where(ch => char.IsLetterOrDigit(ch)).Select(ch => char.IsDigit(ch) ? ch : (ch - 'A').ToString()[0]);
            return string.Join(string.Empty, tmp);
        }
    }
}
