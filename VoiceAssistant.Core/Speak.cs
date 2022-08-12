using System;
using System.Globalization;
using System.Speech.Synthesis;


namespace VoiceAssistant.Core
{
    public class Speak
    {
        const string _unknownWords = "I do not understand you";
        const string _stringTimeForm = "Now is the time. {0}";
        public void EvaSpeak(string lineToSay)
        {
            try
            {
                if (lineToSay == "what time is it")
                {
                    DateTime dateTime = DateTime.Now;
                    Converts converts = new Converts();
                    string stringWordFromTime = converts.GetWordFromTime(dateTime);
                    lineToSay = string.Format(_stringTimeForm, stringWordFromTime);
                    
                }
                Console.WriteLine("Speak " + lineToSay);
                SpeechSynthesizer synth = new SpeechSynthesizer();
                //PromptBuilder speakText = new PromptBuilder();//VoiceGender.Female, VoiceAge.Teen, 20);
                //speakText.StartVoice(VoiceGender.Female, VoiceAge.Teen);
                
                //speakText.AppendText(lineToSay);
                // Configure the audio output.   
                synth.SetOutputToDefaultAudioDevice();
                synth.SpeakAsync(lineToSay);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void EvaSaysDoesNotKnowWord()
        {
            Console.WriteLine(_unknownWords);
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();
            synth.SpeakAsync(_unknownWords);
        }
        
    }
}
