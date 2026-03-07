using System;
using System.Drawing;
using System.IO;
using System.Security.Policy;

namespace CyberShieldSA
{
    public class Logo
    {

        public Logo()
        {
            // Getting project directory
            string projectPath = AppDomain.CurrentDomain.BaseDirectory;

            // Remove debug folder
            string newProjectPath = projectPath.Replace("bin\\Debug\\", "");

            // Combine path with image file
            string fullPath = Path.Combine(newProjectPath, "CyberShieldSALogo.jpg");

            try
            {
                // Load image
                Bitmap image = new Bitmap(fullPath);

                // Resize image for console
                image = new Bitmap(image, new Size(100, 80));

                // Outer loop for the height
                for (int height = 0; height < image.Height; height++)
                {
                    // Inner loop for the width
                    for (int width = 0; width < image.Width; width++)
                    {
                        // Get pixel color
                        Color pixelColor = image.GetPixel(width, height);

                        // Convert color to grayscale value
                        int color = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                        // Convert grayscale to ASCII character
                        char asciiDesign =
                            color > 200 ? '.' :
                            color > 150 ? '*' :
                            color > 100 ? '0' :
                            color > 50 ? '#' :
                            '@';

                        // Print ASCII character
                        Console.Write(asciiDesign);
                    }

                    // Move to next line
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Image could not be loaded.");
            }
        }
    }
}