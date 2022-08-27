using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceAssistant.Data.File
{
    public class DataFile
    {
        /// <summary>
        /// Файл с логами
        /// </summary>
        const string _pathFile = @"Data/";
        /// <summary>
        /// Начало именования файла
        /// </summary>
        const string _nameFile = "PersonalData";
        static public void WriteToFile(string data)
        {
            DateTime dateTime = DateTime.Now;
            string nameFile = _pathFile + _pathFile;
            if (!File.CheckDirectory(_pathFile))
            {
                File.CreateDirectory(_pathFile);
            }
            if (!File.CheckFile(nameFile))
            {
                File.CreateFile(_pathFile, _nameFile, data);
            }
            else
            {

            }
        }
    }
}
