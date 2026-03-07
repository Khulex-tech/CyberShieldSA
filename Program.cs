using System;

namespace CyberShieldSA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Playing welcome audio
            PlayAudio audio = new PlayAudio();
            audio.PlayWelcome();

            //Displaying the ASCII image
            new Logo();
            


            // Starting the chatbot
            ChatBot bot = new ChatBot();
            bot.StartChat();
        }
    }
}