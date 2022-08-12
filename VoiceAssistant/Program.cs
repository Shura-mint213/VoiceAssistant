using System;
using VoiceAssistant.Core;

namespace VoiceAssistant
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Listen listen = new Listen();
            listen.EvaListen();
            //DateTime dateTime = DateTime.Now;
            //Converts converts = new Converts();
            //string result = converts.GetWordFromDate(dateTime);
            //Console.WriteLine($"hour = {dateTime.Hour} minutes = {dateTime.Minute } \n {converts.GetWordFromDate(dateTime)}");
            //Console.ReadKey();
        }
        
        

    }
}
