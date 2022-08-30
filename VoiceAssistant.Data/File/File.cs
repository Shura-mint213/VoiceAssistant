using System;
using System.IO;
using System.Text;

namespace VoiceAssistant.Data.File
{
    public class File
    {
        /// <summary>
        /// Тип файла txt
        /// </summary>
        const string _fileType = ".txt";
        /// <summary>
        /// Запись данных в файл
        /// </summary>
        /// <param name="fullPathToFile">Полный путь к файлу</param>
        /// <param name="data">Данные для запись</param>
        internal static void WriteTextToFile(string fullPathToFile, string data) => System.IO.File.WriteAllText(fullPathToFile, data);
        /// <summary>
        /// Проверка существовании директории
        /// </summary>
        /// <returns>
        /// true если каталог есть, иначе false 
        /// </returns>
        /// <param name="pathDirectory">Путь к директории</param>
        static internal bool CheckDirectory(string pathDirectory)
        {
            if (string.IsNullOrWhiteSpace(pathDirectory))
            {
                throw new AggregateException("Отсутствует путь для директории");
            }
            return System.IO.File.Exists(pathDirectory);
        }
        /// <summary>
        /// Создания файла
        /// </summary>
        /// <param name="pathFile">Путь к директори</param>
        static internal void CreateDirectory(string pathDirectory)
        {
            if (string.IsNullOrWhiteSpace(pathDirectory))
            {
                throw new AggregateException("Отсутствует путь для директории");
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(pathDirectory);
            directoryInfo.Create();
        }
        /// <summary>
        /// Проверка существовании файла
        /// </summary>
        /// <param name="pathFile">Путь к файлу</param>
        /// <returns></returns>
        static internal bool CheckFile(string pathFile)
        {
            if (string.IsNullOrWhiteSpace(pathFile))
            {
                throw new AggregateException("Отсутствует путь для файла");
            }
            return System.IO.File.Exists(pathFile);
        }
        /// <summary>
        /// Создания файла и запись в него ошибки
        /// </summary>
        /// <param name="pathFile">Путь к файлу</param>
        /// <param name="nameFile">Имя файла</param>
        /// <param name="fileText">Текст внутри файла</param>
        static internal void CreateFile(string pathFile, string nameFile, string fileText)
        {
            if (string.IsNullOrWhiteSpace(pathFile) || string.IsNullOrWhiteSpace(nameFile) || string.IsNullOrWhiteSpace(fileText))
            {
                throw new AggregateException("Ошибка в логировании");
            }
            try
            {
                var dateTime = DateTime.Now;
                string path = pathFile + nameFile + _fileType;
                using (FileStream fs = System.IO.File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(fileText);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            } 
            catch (Exception ex)
            {
                 throw new Exception(ex.ToString()); 
            }
            
        }
    }
}
