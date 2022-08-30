using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoiceAssistant.Data.Models;

namespace VoiceAssistant.Data
{
    public class ConverterData
    {
        public T ConvertJsonToPersonData<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
