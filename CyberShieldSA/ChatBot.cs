using System;
using System.Collections.Generic;

using System.Threading;



namespace CyberShieldSA

{

    public class ChatBot

    {

        // Store conversation history 

        List<string> history = new List<string>();



        // Random generator for tips and follow-up prompts 

        Random rand = new Random();



        public void StartChat()

        {

            Console.ForegroundColor = ConsoleColor.Cyan;



            Console.Write("Enter your name: ");

            string name = Console.ReadLine();



            if (string.IsNullOrWhiteSpace(name))

                name = "User";



            Console.ResetColor();



            ShowMenu(name);



            string userInput = "";



            // LOOP for responses 

            while (userInput != "exit")

            {

                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("\nYou: ");

                userInput = Console.ReadLine();



                // Handle empty input 

                if (string.IsNullOrWhiteSpace(userInput))

                {

                    TypeResponse("Bot: Please type something so I can help you.", ConsoleColor.Yellow);

                    continue;

                }



                userInput = userInput.ToLower();



                // Save user input 

                history.Add("User: " + userInput);



                ShowTypingIndicator();



                // Sentiment check before keyword matching 

                if (ContainsKeyword(userInput, "thank", "thanks", "appreciate"))

                {

                    TypeResponse("Bot: You're welcome! Stay safe out there.", ConsoleColor.Green);

                    history.Add("Bot: You're welcome! Stay safe out there.");

                }



                else if (ContainsKeyword(userInput, "frustrated", "useless", "stupid", "hate"))

                {

                    TypeResponse("Bot: I'm sorry if I wasn't helpful. Try asking about passwords, phishing, malware or VPN.", ConsoleColor.Yellow);

                    history.Add("Bot: I'm sorry if I wasn't helpful.");

                }



                else if (ContainsKeyword(userInput, "how are you"))

                {

                    string response = "Bot: I am doing great and ready to help you stay safe online.";

                    TypeResponse(response, ConsoleColor.Green);

                    history.Add(response);

                }



                else if (ContainsKeyword(userInput, "password"))

                {

                    string response = "Bot: Always use strong passwords with numbers, letters and symbols. Avoid using your name or birthday.";

                    TypeResponse(response, ConsoleColor.Green);

                    history.Add(response);

                    SuggestFollowUp("Would you like to know about two-factor authentication to strengthen your account security?");

                }



                else if (ContainsKeyword(userInput, "phishing", "pishing"))

                {

                    string response = "Bot: Phishing scams try to trick you into giving personal information through fake emails or websites.";

                    TypeResponse(response, ConsoleColor.Green);

                    history.Add(response);

                    SuggestFollowUp("You might also want to ask about social engineering, which uses similar tricks.");

                }



                else if (ContainsKeyword(userInput, "malware", "virus"))

                {

                    string response = "Bot: Malware is harmful software that can steal your data or damage your computer.";

                    TypeResponse(response, ConsoleColor.Green);

                    history.Add(response);

                    SuggestFollowUp("Ask me about VPNs for an extra layer of protection against threats.");

                }



                else if (ContainsKeyword(userInput, "vpn"))

                {

                    string response = "Bot: A VPN protects your internet connection by encrypting your data, especially on public networks.";

                    TypeResponse(response, ConsoleColor.Green);

                    history.Add(response);

                    SuggestFollowUp("Speaking of public networks, ask me about public WiFi safety.");

                }



                else if (ContainsKeyword(userInput, "2fa", "two factor", "authentication"))

                {

                    string response = "Bot: Two-Factor Authentication adds an extra layer of security by requiring a second verification step.";

                    TypeResponse(response, ConsoleColor.Green);

                    history.Add(response);

                    SuggestFollowUp("Pair 2FA with a strong password for maximum protection. Ask me about passwords.");

                }



                else if (ContainsKeyword(userInput, "social engineering"))

                {

                    string response = "Bot: Social engineering tricks people into giving sensitive information by pretending to be trusted sources.";

                    TypeResponse(response, ConsoleColor.Green);

                    history.Add(response);

                    SuggestFollowUp("Phishing is a common form of social engineering. Ask me about it.");

                }



                else if (ContainsKeyword(userInput, "wifi", "public wifi"))

                {

                    string response = "Bot: Avoid logging into sensitive accounts when using public WiFi because attackers may intercept your data.";

                    TypeResponse(response, ConsoleColor.Green);

                    history.Add(response);

                    SuggestFollowUp("A VPN can keep you safer on public WiFi. Ask me about VPNs.");

                }



                else if (ContainsKeyword(userInput, "privacy"))

                {

                    string response = "Bot: Always check privacy settings on apps and websites to protect your personal information.";

                    TypeResponse(response, ConsoleColor.Green);

                    history.Add(response);

                }



                else if (ContainsKeyword(userInput, "purpose"))

                {

                    string response = "Bot: My purpose is to teach people about cybersecurity safety.";

                    TypeResponse(response, ConsoleColor.Green);

                    history.Add(response);

                }



                // tips 

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



                    string tip = "Bot: " + tips[rand.Next(tips.Length)];

                    TypeResponse(tip, ConsoleColor.Green);

                    history.Add(tip);

                }



                // show history 

                else if (ContainsKeyword(userInput, "history"))

                {

                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.WriteLine("\nConversation History:\n");



                    foreach (string msg in history)

                    {

                        Console.WriteLine(msg);

                    }



                    Console.ResetColor();

                }



                // exit commands 

                else if (ContainsKeyword(userInput, "exit", "quit", "bye", "sharp", "close"))

                {

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine("\nBot: Ending the session now. Thank you for using CyberShield SA.");

                    ShowGoodbyeArt();

                    break;

                }



                else

                {

                    string response = "Bot: I didn't understand that. Try asking about passwords, phishing, malware, VPN, WiFi, privacy, tips or history.";

                    TypeResponse(response, ConsoleColor.Yellow);

                    history.Add(response);

                }



                Console.ResetColor();

            }

        }



        // Simulates the bot typing before showing a response 

        private void ShowTypingIndicator()

        {

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Write("\nBot is typing");



            for (int i = 0; i < 3; i++)

            {

                Thread.Sleep(300);

                Console.Write(".");

            }



            Thread.Sleep(300);

            Console.Write("\r                    \r");

            Console.ResetColor();

        }



        // Prints text one character at a time to simulate typing 

        private void TypeResponse(string message, ConsoleColor color)

        {

            Console.ForegroundColor = color;



            foreach (char c in message)

            {

                Console.Write(c);

                Thread.Sleep(18);

            }



            Console.WriteLine();

            Console.ResetColor();

        }



        // Suggests a related topic after answering 

        private void SuggestFollowUp(string suggestion)

        {

            Thread.Sleep(400);

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Tip: " + suggestion);

            Console.ResetColor();

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

        }//End of method 

    }//end of class 

}//end of namespace 