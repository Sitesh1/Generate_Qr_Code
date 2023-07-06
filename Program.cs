using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
using System.Drawing;


namespace Generate_qr_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate the QR code
            string url = "Name:Sitesh Singh Solanki , Add: Aurangabad Bihar , Mob: 7004207424 "+
               "https://www.youtube.com/@SITESHSINGHSOLANKI";

            Bitmap qrCode = GenerateQRCode(url);

            // Save QR code to a folder
            qrCode.Save(@"D:\image\qr_code.png");

            Console.WriteLine("Qr Code Generated");
            Console.ReadLine();
        }

        static Bitmap GenerateQRCode(string data)
        {
            // Generate QR code using QRCoder library
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            // Convert QR code to bitmap image
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Return the bitmap image
            return qrCodeImage;
            
        }
    }
}

