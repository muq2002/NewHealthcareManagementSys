using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagement.Config
{
    class HTMLDocument
    {
        public static void createHtmltoPdf(string htmlDoc)
        {
            if (File.Exists("buffer.html")) File.Delete("buffer.html");

            File.WriteAllText("buffer.html", htmlDoc);

            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            if (File.Exists("export.pdf")) File.Delete("export.pdf");

            htmlToPdf.GeneratePdfFromFile("buffer.html", null, "export.pdf");
        }
    }
}