using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace MuskProcessServices.Models
{
    class PDFReport
    {
        public static void generatePDF(int siteInspectionId)
        {
            //  Attributes
            PdfPTable table = null;
            Phrase phrase = null;
            PdfPCell cell = null;
            BaseColor color = null;

            //  Getting the full path to the folder where we store our reports
            string reportsFolder = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\", "./Reports"));

            System.IO.FileStream fs = new FileStream(reportsFolder + "\\" + $"SiteInspection_{siteInspectionId}.pdf", FileMode.OpenOrCreate);


            //  Creating an instance of the document which represents the PDF file
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            //  Meta information
            document.AddAuthor("JEMP");
            document.AddKeywords("Site Inspection generated report from DB");
            document.AddSubject("A summary report of the site inspection and listed interventions");
            document.AddTitle($"Site Inspection_{siteInspectionId} report");

            // Open document to include changes
            document.Open();

            // Title of document
            Font titleFont = FontFactory.GetFont("Arial", 15, Font.BOLD);
            Paragraph title = new Paragraph("Health, Safety, Quality and Environmental Site Inspection", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            // Site Inspection Summary Table (TO DO)

            // Interventions Table (TO DO)

            // Conclude 
            document.Close();
            writer.Close();
            fs.Close();
        }
    }
}
