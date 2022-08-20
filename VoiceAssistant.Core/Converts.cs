using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoiceAssistant.Core.Enums;

namespace VoiceAssistant.Core
{
    public class Converts
    {
        const string _stirngWordFromIntForm = "{0}-{1}";
        const string _stringSayTime = "{0}. {1}";
        private string GetWordFromInt(int time)
        {
            
            string result = string.Empty;
            try
            {
                if (time < 21)
                {
                    result = Enum.GetName(typeof(TimeEnum), time);
                }
                else if (time % 10 > 0)
                {
                    string onePart = Enum.GetName(typeof(TimeEnum), time / 10 * 10);  
                    string twoPart =  Enum.GetName(typeof(TimeEnum), time % 10);
                    result = string.Format(_stirngWordFromIntForm, onePart, twoPart);
                }
                else
                {
                    result += Enum.GetName(typeof(TimeEnum), time % 10);
                }
            }
            catch (Exception ex)
            {
                Logging.ErrorRecording(ex.ToString());
            }
            return result;
        }
        public string GetWordFromTime(DateTime date)
        {
            string result = string.Empty;
            try
            {
                string hour = GetWordFromInt(date.Hour);
                string minutes = GetWordFromInt(date.Minute);
                result = string.Format(_stringSayTime, hour, minutes);
            } catch (Exception ex)
            {
                Logging.ErrorRecording(ex.ToString());
            }
            return result;
        }
    }
}
