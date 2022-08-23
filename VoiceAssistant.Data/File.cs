using System;
using VoiceAssistant.Data.Interface;

namespace VoiceAssistant.Data
{
    public class File : IFile
    {
        const string _pathFile = @"Data/";
        const string _nameFile = "data";
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
