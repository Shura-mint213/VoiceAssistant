using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceAssistant.Data.Interface
{
    public interface IFile
    {
        public void CreateFile();
        public void CheckFile();
        public string ReadingFile();
        public void WritingFile();
    }
}
