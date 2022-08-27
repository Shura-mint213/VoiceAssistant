using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceAssistant.Data.File
{
    public class LoggingFile
    {
        /// <summary>
        /// Файл с логами
        /// </summary>
        const  string _pathFile = @"Log/";
        /// <summary>
        /// Начало именования файла
        /// </summary>
        const string _nameFile = "log_";
        /// <summary>
        /// Метод записывает переданную информацию об ошибке в текстовый файл
        /// </summary>
        /// <param name="textError">Текст ошибки</param>
        static public void WriteErrorToFile(string textError)
        {
            DateTime dateTime = DateTime.Now;
            string nameFile = _nameFile + dateTime.Year + dateTime.Month + dateTime.Day + dateTime.Hour + dateTime.Minute + dateTime.Second + dateTime.Millisecond;
            if (!File.CheckDirectory(_pathFile))
            {
                File.CreateDirectory(_pathFile);
            }
            File.CreateFile(_pathFile, nameFile, textError);
        }
    }
}
