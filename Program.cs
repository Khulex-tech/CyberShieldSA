using System;


namespace CyberShieldSA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set console title
            Console.Title = "CyberShield SA - Cybersecurity Awareness Chatbot";

            // Set default colors
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            // calling method to play welcome audio
            PlayAudio audio = new PlayAudio();
            audio.PlayWelcome();

            // calling the method to display the image
            Console.ForegroundColor = ConsoleColor.Cyan;
            new Logo();

            Console.ResetColor();

            ChatBot bot = new ChatBot();
            bot.StartChat();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPress any key to close the program...");
            Console.ReadKey();
        }
    }
}