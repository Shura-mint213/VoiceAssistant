using Newtonsoft.Json;
using System;
using System.IO;
using VoiceAssistant.Data.Models;

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
        /// <summary>
        /// Тип файла txt
        /// </summary>
        const string _fileType = ".txt";
        /// <summary>
        /// Запись в файл данные 
        /// </summary>
        /// <param name="data"></param>
        static public void SaveData(string data = null)
        {
            string nameFile = _pathFile + _pathFile;
            if (!File.CheckDirectory(_pathFile))
            {
                File.CreateDirectory(_pathFile);
            }
            if (!File.CheckFile(nameFile))
            {
                File.CreateFile(_pathFile, _nameFile, data);
            }
            else if (!string.IsNullOrWhiteSpace(data))
            {
                string fullPathToFile = _pathFile + _nameFile;
                File.WriteTextToFile(fullPathToFile, data);
            }
        }
        /// <summary>
        /// Запись в файл данных по переданной модели данных
        /// </summary>
        /// <param name="personData">Модель данных, которые нужно сохранить</param>
        static public void SaveData(PersonData personData)
        {
            string json = JsonConvert.SerializeObject(personData);
            SaveData(json);
        }
        /// <summary>
        /// Чтение данных из файла
        /// </summary>
        /// <returns></returns>
        static public PersonData GetData()
        {
            // Проверить существование файла, если его нет создаем
            SaveData();
            string fileText = string.Empty;
            string fullPathFile = _pathFile + _nameFile + _fileType;
            fileText = System.IO.File.ReadAllText(fullPathFile);
            return JsonConvert.DeserializeObject<PersonData>(fileText); 
        }
    }
}
