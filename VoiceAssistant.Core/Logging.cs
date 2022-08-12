using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceAssistant.Core
{
    internal class Logging
    {
        /// <summary>
        /// Файл с логами
        /// </summary>
        const string _pathLogFile = @"Log";
        /// <summary>
        /// Проверка сущесвования файла
        /// </summary>
        internal bool CheckFile()
        {
            return File.Exists(_pathLogFile)? true : false ;
        }
        /// <summary>
        /// Создания файла
        /// </summary>
        internal void CreateFile()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(_pathLogFile);
            directoryInfo.Create();
        }

    }
}
