using System;

namespace CyberShieldSA
{
    internal class ChatBot
    {
        public void StartChat()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.ResetColor();

            ShowMenu(name);

            string userInput = "";

            // WHILE LOOP for responses
            while (userInput != "exit")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nYou: ");
                userInput = Console.ReadLine().ToLower(); // to remove case sensitivity

                Console.ForegroundColor = ConsoleColor.Green;

                if (ContainsKeyword(userInput, "how are you"))
                {
                    Console.WriteLine("Bot: I am doing great and ready to help you stay safe online.");
                }

                else if (ContainsKeyword(userInput, "password"))
                {
                    Console.WriteLine("Bot: Always use strong passwords with numbers, letters and symbols. Avoid using your name or birthday.");
                }

                else if (ContainsKeyword(userInput, "phishing", "pishing"))
                {
                    Console.WriteLine("Bot: Phishing scams try to trick you into giving personal information through fake emails or websites.");
                }

                else if (ContainsKeyword(userInput, "malware", "virus"))
                {
                    Console.WriteLine("Bot: Malware is harmful software that can steal your data or damage your computer.");
                }

                else if (ContainsKeyword(userInput, "vpn"))
                {
                    Console.WriteLine("Bot: A VPN protects your internet connection by encrypting your data, especially on public networks.");
                }

                else if (ContainsKeyword(userInput, "2fa", "two factor", "authentication"))
                {
                    Console.WriteLine("Bot: Two-Factor Authentication adds an extra layer of security by requiring a second verification step.");
                }

                else if (ContainsKeyword(userInput, "social engineering"))
                {
                    Console.WriteLine("Bot: Social engineering tricks people into giving sensitive information by pretending to be trusted sources.");
                }

                else if (ContainsKeyword(userInput, "wifi", "public wifi"))
                {
                    Console.WriteLine("Bot: Avoid logging into sensitive accounts when using public WiFi because attackers may intercept your data.");
                }

                else if (ContainsKeyword(userInput, "privacy"))
                {
                    Console.WriteLine("Bot: Always check privacy settings on apps and websites to protect your personal information.");
                }

                else if (ContainsKeyword(userInput, "purpose"))
                {
                    Console.WriteLine("Bot: My purpose is to teach people about cybersecurity safety.");
                }

                else if (userInput == "exit")
                {
                    ShowGoodbyeArt();
                    break;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Bot: I didn't understand that. Try asking about passwords, phishing, malware, VPN, WiFi, or privacy.");
                }

                Console.ResetColor();
            }
        }

        // Helper method to detect keywords
        private bool ContainsKeyword(string input, params string[] keywords)
        {
            foreach (string word in keywords)
            {
                if (input.Contains(word))
                {
                    return true;
                }
            }
            return false;
        }

        private void ShowMenu(string name)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(@"
                            ██████████████████████████████████████████████████████████████
                            █                                                            █
                            █                 CYBERSHIELD SA CHATBOT                     █
                            █                                                            █
                            ██████████████████████████████████████████████████████████████
                            █                                                            █
                            █   Welcome " + name + @"!                                            
                            █                                                            █
                            █   You can ask me about:                                    █
                            █                                                            █
                            █   • Password Safety                                         █
                            █   • Phishing Scams                                          █
                            █   • Malware & Viruses                                       █
                            █   • VPN Security                                            █
                            █   • Two-Factor Authentication (2FA)                         █
                            █   • Social Engineering                                      █
                            █   • Public WiFi Safety                                      █
                            █   • Privacy Protection                                      █
                            █                                                            █
                            █   Type 'exit' anytime to close the chatbot                 █
                            █                                                            █
                            ██████████████████████████████████████████████████████████████
");

            Console.ResetColor();
        }

        private void ShowGoodbyeArt()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine(@"

                            ██████████████████████████████████████████████████████████████
                            █                                                            █
                            █                         GOODBYE!                           █
                            █                                                            █
                            █                THANK YOU FOR USING                         █
                            █                  CYBERSHIELD SA                            █
                            █                                                            █
                            █                  STAY SAFE ONLINE                          █
                            █                                                            █
                            ██████████████████████████████████████████████████████████████

");

            Console.ResetColor();
        }
    }
}