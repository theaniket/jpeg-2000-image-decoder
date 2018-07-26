using CSJ2K.Util;
using System;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // from byte array
            byte[] imageDataInBinary = File.ReadAllBytes(@"C:\Users\aniketchadha\Pictures\v.jp2");
            MemoryStream memoryStreamObject = new MemoryStream();
            memoryStreamObject.Write(imageDataInBinary, 0, imageDataInBinary.Length);
            BitmapImageCreator.Register();

            // from file
            CSJ2K.Util.PortableImage portableImageObject = CSJ2K.J2kImage.FromFile(@"D:\Jpeg2k.Samples-master\Jpeg2k.Samples-master\Samples\Sample Data\balloon.j2c");
            try
            {
                var img = portableImageObject.As<System.Drawing.Image>();
                img.Save(@"C:\Users\aniketchadha\Pictures\balloon2.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }

        }
    }
}
