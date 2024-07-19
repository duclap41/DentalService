using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalService.QrCode
{
    internal class genQrCode
    {
        public string GenerateRandomQRCodeText()
        {
            Random rand = new Random();
            string lowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";
            string upperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "0123456789";

            string randomText = new string(new char[]
            {
                lowerCaseLetters[rand.Next(lowerCaseLetters.Length)],
                lowerCaseLetters[rand.Next(lowerCaseLetters.Length)],
                lowerCaseLetters[rand.Next(lowerCaseLetters.Length)],
                digits[rand.Next(digits.Length)],
                digits[rand.Next(digits.Length)],
                digits[rand.Next(digits.Length)],
                upperCaseLetters[rand.Next(upperCaseLetters.Length)],
                upperCaseLetters[rand.Next(upperCaseLetters.Length)],
                upperCaseLetters[rand.Next(upperCaseLetters.Length)]
            });

            return randomText;
        }

        //Generate QR code
        public string GenerateQRCodeImage(int size, string directoryPath)
        {
            QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
            string genText = GenerateRandomQRCodeText();
            QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeGenerator.CreateQrCode(genText, QRCodeGenerator.ECCLevel.Q));
            Image image = qrCode.GetGraphic(size, Color.Black, Color.White, false);

            // save
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string fileName = $"{genText}.jpg";
            string filePath = Path.Combine(directoryPath, fileName);
            image.Save(filePath, ImageFormat.Png);

            qrCodeGenerator.Dispose();
            qrCode.Dispose();

            return genText;
        }
    }
}
