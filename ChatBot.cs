using System;

namespace CyberShieldSA
{
    internal class ChatBot
    {
        public void StartChat()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}, I am CyberShield SA.");
            Console.WriteLine("Ask me about cybersecurity.");
            Console.WriteLine("Type 'exit' to quit.");

            string userInput = "";

            // WHILE LOOP for responses
            while (userInput != "exit")
            {
                Console.Write("\nYou: ");
                userInput = Console.ReadLine().ToLower();

                if (userInput.Contains("how are you"))
                {
                    Console.WriteLine("Bot: I am doing great and ready to help you stay safe online.");
                }

                else if (userInput.Contains("password"))
                {
                    Console.WriteLine("Bot: Always use strong passwords with numbers, letters and symbols.");
                }

                else if (userInput.Contains("phishing"))
                {
                    Console.WriteLine("Bot: Phishing emails try to trick you into giving personal information.");
                }

                else if (userInput.Contains("purpose"))
                {
                    Console.WriteLine("Bot: My purpose is to teach people about cybersecurity safety.");
                }

                else if (userInput == "exit")
                {
                    Console.WriteLine("Bot: Goodbye. Stay safe online.");
                }

                else
                {
                    Console.WriteLine("Bot: I didn't understand that. Please ask about cybersecurity.");
                }
            }
        }
    }
}