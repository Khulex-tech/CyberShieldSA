using System;
using System.Collections.Generic;

namespace CyberShieldSA
{
    internal class ChatBot
    {
        // Store conversation history
        List<string> history = new List<string>();

        // Random generator for tips
        Random rand = new Random();

        public void StartChat()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.ResetColor();

            ShowMenu(name);

            string userInput = "";

            // LOOP for responses
            while (userInput != "exit")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nYou: ");
                userInput = Console.ReadLine().ToLower();

                // Save user input
                history.Add("User: " + userInput);

                Console.ForegroundColor = ConsoleColor.Green;

                if (ContainsKeyword(userInput, "how are you"))
                {
                    string response = "Bot: I am doing great and ready to help you stay safe online.";
                    Console.WriteLine(response);
                    history.Add(response);
                }

                else if (ContainsKeyword(userInput, "password"))
                {
                    string response = "Bot: Always use strong passwords with numbers, letters and symbols. Avoid using your name or birthday.";
                    Console.WriteLine(response);
                    history.Add(response);
                }

                else if (ContainsKeyword(userInput, "phishing", "pishing"))
                {
                    string response = "Bot: Phishing scams try to trick you into giving personal information through fake emails or websites.";
                    Console.WriteLine(response);
                    history.Add(response);
                }

                else if (ContainsKeyword(userInput, "malware", "virus"))
                {
                    string response = "Bot: Malware is harmful software that can steal your data or damage your computer.";
                    Console.WriteLine(response);
                    history.Add(response);
                }

                else if (ContainsKeyword(userInput, "vpn"))
                {
                    string response = "Bot: A VPN protects your internet connection by encrypting your data, especially on public networks.";
                    Console.WriteLine(response);
                    history.Add(response);
                }

                else if (ContainsKeyword(userInput, "2fa", "two factor", "authentication"))
                {
                    string response = "Bot: Two-Factor Authentication adds an extra layer of security by requiring a second verification step.";
                    Console.WriteLine(response);
                    history.Add(response);
                }

                else if (ContainsKeyword(userInput, "social engineering"))
                {
                    string response = "Bot: Social engineering tricks people into giving sensitive information by pretending to be trusted sources.";
                    Console.WriteLine(response);
                    history.Add(response);
                }

                else if (ContainsKeyword(userInput, "wifi", "public wifi"))
                {
                    string response = "Bot: Avoid logging into sensitive accounts when using public WiFi because attackers may intercept your data.";
                    Console.WriteLine(response);
                    history.Add(response);
                }

                else if (ContainsKeyword(userInput, "privacy"))
                {
                    string response = "Bot: Always check privacy settings on apps and websites to protect your personal information.";
                    Console.WriteLine(response);
                    history.Add(response);
                }

                else if (ContainsKeyword(userInput, "purpose"))
                {
                    string response = "Bot: My purpose is to teach people about cybersecurity safety.";
                    Console.WriteLine(response);
                    history.Add(response);
                }

                // CYBERSECURITY TIPS
                else if (ContainsKeyword(userInput, "tip", "tips"))
                {
                    string[] tips =
                    {
                        "Use strong passwords with symbols and numbers.",
                        "Enable two factor authentication whenever possible.",
                        "Never click suspicious email links.",
                        "Update your software regularly.",
                        "Avoid logging into accounts on public WiFi.",
                        "Install antivirus software on your computer."
                    };

                    string tip = tips[rand.Next(tips.Length)];

                    Console.WriteLine("Bot: " + tip);
                    history.Add("Bot: " + tip);
                }

                // SHOW HISTORY
                else if (ContainsKeyword(userInput, "history"))
                {
                    Console.WriteLine("\nConversation History:\n");

                    foreach (string msg in history)
                    {
                        Console.WriteLine(msg);
                    }
                }

                // EXIT COMMANDS
                else if (ContainsKeyword(userInput, "exit", "quit", "bye", "sharp", "close"))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine("\nBot: Ending the session now. Thank you for using CyberShield SA.");

                    ShowGoodbyeArt();
                    break;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    string response = "Bot: I didn't understand that. Try asking about passwords, phishing, malware, VPN, WiFi, privacy, tips or history.";

                    Console.WriteLine(response);
                    history.Add(response);
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
                        █   Extra Commands:                                          █
                        █   • tip  - get a cybersecurity tip                          █
                        █   • history - see conversation history                      █
                        █                                                            █
                        █   Type 'exit, bye, quit, sharp or close'                   █
                        █   anytime to close the chatbot                             █
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