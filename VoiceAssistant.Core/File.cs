using System;
using VoiceAssistant.Data.Interface;

namespace VoiceAssistant.Core
{
    internal class File : IFile
    {
        private static string _pathFile;
        private static string _nameFile;
        public  File(string pathFile, string nameFile)
        {
            _pathFile = pathFile;
            _nameFile = nameFile;
        }
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
        public void CheckFile()
        {
            
        }

        public void CreateFile()
        {

        }

        public string ReadingFile()
        {
            throw new NotImplementedException();
        }

        public void WritingFile()
        {
            throw new NotImplementedException();
        }
    }
}
