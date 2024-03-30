using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthcareManagement.Config
{
    class HTMLDocument
    {
        public static void createHtmltoPdf(string htmlDoc)
        {
            string HTMLFile = Application.StartupPath + @"\data\buffer.html";
            string PDFfile = Application.StartupPath + @"\data\export.pdf";
            if (File.Exists(HTMLFile)) File.Delete(HTMLFile);

            File.WriteAllText(HTMLFile, htmlDoc);

            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            if (File.Exists(PDFfile)) File.Delete(PDFfile);

            htmlToPdf.GeneratePdfFromFile(HTMLFile, null, PDFfile);
        }
    }
}