﻿using System;
using System.Speech.Recognition;

namespace VoiceAssistant.Core
{
    public class Listen
    {
        public void EvaListen()
        {
            try 
            {
                using ( SpeechRecognitionEngine recognizer =
                    new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US")))
                {
                    Console.WriteLine("Say");
                    Choices choices = new Choices();
                    choices.Add(new string[] { "red", "sport", "blue", "what time is it" });

                    GrammarBuilder grammar = new GrammarBuilder();
                    grammar.Culture = new System.Globalization.CultureInfo("en-US");
                    grammar.Append(choices);

                    // Create and load a dictation grammar.  
                    recognizer.LoadGrammar(new Grammar(grammar));

                    // Add a handler for the speech recognized event.  
                    recognizer.SpeechRecognized +=
                        new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
                    recognizer.SpeechRecognitionRejected +=
                        new EventHandler<SpeechRecognitionRejectedEventArgs>(ActionUnknownWords);
                    // Configure input to the speech recognizer.  
                    recognizer.SetInputToDefaultAudioDevice();

                    // Start asynchronous, continuous speech recognition.  
                    recognizer.RecognizeAsync(RecognizeMode.Multiple);

                    // Keep the console window open.  
                    while (true)
                    {
                        Console.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        // Handle the SpeechRecognized event.  
        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence > 0.7)
            {
                Console.WriteLine("Recognized text: " + e.Result.Text);
                Speak speak = new Speak();
                speak.EvaSpeak(e.Result.Text);
            }
        }
        static void ActionUnknownWords(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            Console.WriteLine("Recognized text: " + e.Result.Text);
            Speak speak = new Speak();
            speak.EvaSaysDoesNotKnowWord();
        }
    }
}
