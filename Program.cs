using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide the path to the image file.");
            return;
        }

        string imagePath = args[0];

        if (!File.Exists(imagePath))
        {
            Console.WriteLine("The specified file does not exist.");
            return;
        }

        try
        {
            byte[] byteArray = File.ReadAllBytes(imagePath);

            // Convert byte array to hex string
            string hexString = "0x" + BitConverter.ToString(byteArray).Replace("-", "");

            // Print byte array as a hex string
            Console.WriteLine(hexString);

            // Copy hex string to clipboard
            Clipboard.SetText(hexString);

            Console.WriteLine("Byte array copied to clipboard.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
