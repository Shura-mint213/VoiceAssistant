using System;
using System.Speech.Synthesis;


namespace VoiceAssistant.Core
{
    public class Speak
    {
        const string _unknownWords = "I am sorry, I do not understand you";
        public void EvaSpeak(string lineToSay)
        {
            try
            {
                Console.WriteLine("Speak " + lineToSay);
                SpeechSynthesizer synth = new SpeechSynthesizer();

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
