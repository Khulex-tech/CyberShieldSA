using System;
using System.IO;
using System.Media;

namespace CyberShieldSA
{
    internal class PlayAudio
    {
        public void PlayWelcome()
        {
            // Get project directory
            string projectPath = AppDomain.CurrentDomain.BaseDirectory;

            // Remove bin/debug folder
            string newPath = projectPath.Replace("bin\\Debug\\", "");

            // Combine path with audio file
            string audioPath = Path.Combine(newPath, "assets", "WelcomeAudio.wav");

            try
            {
                SoundPlayer player = new SoundPlayer(audioPath);
                player.PlaySync(); 
            }
            catch
            {
                Console.WriteLine("Audio could not play.");
            }
        }
    }
}