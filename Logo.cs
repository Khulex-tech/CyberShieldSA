using System;
using System.Drawing;
using System.IO;

namespace CyberShieldSA
{
    public class Logo
    {
        public Logo()
        {
            // Get project path
            string projectPath = AppDomain.CurrentDomain.BaseDirectory;

            // Remove debug folders
            string newPath = projectPath.Replace("bin\\Debug\\", "")
                                        .Replace("bin\\Release\\", "");

            // Combine with Assets folder and image name
            string fullPath = Path.Combine(newPath, "assets", "CyberShieldSALogo.jpg");

            try
            {
                Bitmap image = new Bitmap(fullPath);

                // Resize image for console
                image = new Bitmap(image, new Size(100, 60));

                for (int height = 0; height < image.Height; height++)
                {
                    for (int width = 0; width < image.Width; width++)
                    {
                        Color pixelColor = image.GetPixel(width, height);

                        int color = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                        char ascii =
                            color > 200 ? '@' :
                            color > 150 ? '*' :
                            color > 100 ? '0' :
                            color > 50 ? '#' :
                            '.';

                        Console.Write(ascii);
                    }

                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Logo image could not be loaded.");
            }
        }
    }
}