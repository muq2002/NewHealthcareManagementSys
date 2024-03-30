﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace HealthcareManagement.Config
{
    class QRCodeConfig
    {
        static BarcodeWriter writer = new BarcodeWriter();

        public static void createQRPatientImage(string text)
        {
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = new ZXing.Common.EncodingOptions
            {
                Width = 300,
                Height = 300,
                Margin = 0
            };
            Bitmap qrCodeImage = writer.Write(text);


            string imagePath = "qr_code.png";
            if (File.Exists(imagePath))File.Delete(imagePath);
            qrCodeImage.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
