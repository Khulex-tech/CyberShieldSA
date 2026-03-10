using System;
using System.Threading;

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

            // ==========================================
            // PLAY WELCOME AUDIO
            // ==========================================
            PlayAudio audio = new PlayAudio();
            audio.PlayWelcome();

            // ==========================================
            // DISPLAY ASCII IMAGE LOGO
            // ==========================================
            Console.ForegroundColor = ConsoleColor.Cyan;
            new Logo();

            Console.ResetColor();

            // Small delay for better user experience
            Thread.Sleep(1500);

            // ==========================================
            // START CHATBOT
            // ==========================================
            ChatBot bot = new ChatBot();
            bot.StartChat();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPress any key to close the program...");
            Console.ReadKey();
        }
    }
}