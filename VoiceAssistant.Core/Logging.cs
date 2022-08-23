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
        const string _pathFile = @"Log/";
        /// <summary>
        /// Начало именования файла
        /// </summary>
        const string _nameFile = "log_";
        /// <summary>
        /// Тип файла txt
        /// </summary>
        const string _fileType = ".txt";

        /// <summary>
        /// Проверка сущесвования файла
        /// </summary>
        /// <returns>
        /// true если каталог есть, иначе false 
        /// </returns>
        static private bool CheckDirectory()
        {
            return System.IO.File.Exists(_pathFile);
        }
        /// <summary>
        /// Создания файла
        /// </summary>
        static private void CreateDirectory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(_pathFile);
            directoryInfo.Create();
        }
        /// <summary>
        /// Создания файла и запись в него ошибки
        /// </summary>
        /// <param name="textError">Ошибка</param>
        static private void CreateFile(string textError)
        {
            var dateTime = DateTime.Now;
            string path = _pathFile + _nameFile + dateTime.Year + dateTime.Month + dateTime.Day + dateTime.Hour + dateTime.Minute + dateTime.Second + dateTime.Millisecond + _fileType;
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(textError);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
        /// <summary>
        /// Метод записывает переданую информацию в текстовый файл
        /// </summary>
        /// <param name="textError">Текст ошибки</param>
        static internal void RecordingFile(string textError)
        {
            if (!CheckDirectory())
            {
                CreateDirectory();
            }
            CreateFile(textError);
        }
    }
}
