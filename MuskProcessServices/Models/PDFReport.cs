using System.Collections.Generic;
using System.IO;
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
            PdfPCell cell = null;

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

            // Site Inspection Summary Table
            addSiteInspectionSummaryTable(document, siteInspectionId, table, cell);

            // Interventions Table (TO DO)
            addInterventionsTable(document, siteInspectionId, table, cell);

            // Conclude 
            document.Close();
            writer.Close();
            fs.Close();
        }

        private static void addSiteInspectionSummaryTable(Document document, int siteInspectionId, PdfPTable table, PdfPCell cell)
        {
            //  Getting site inspection data - full names, site name, etc
            SiteInspection selectedSite = SiteInspection.getSiteInspection(siteInspectionId);
            MuskSite site = MuskSite.getSite(selectedSite.SiteId);
            User completedBy = User.getUser(selectedSite.CompletedBy);
            User inspector = User.getUser(selectedSite.Inspector);
            User supervisor = User.getUser(selectedSite.Supervisor);

            //Site Inspection summary details table
            table = new PdfPTable(6);
            table.TotalWidth = 550f;
            table.LockedWidth = true;

            //  1st row
            table.AddCell(HeaderCell("Site:"));
            table.AddCell(ValueCell(site.Name));
            table.AddCell(HeaderCell("Completed By:"));
            table.AddCell(ValueCell(completedBy.Firstname + " " + completedBy.Surname));
            table.AddCell(HeaderCell("Date:"));
            table.AddCell(ValueCell(".............."));

            //  2nd row
            table.AddCell(HeaderCell("Work Area:"));
            table.AddCell(ValueCell(selectedSite.WorkArea));
            table.AddCell(HeaderCell("Job Description:"));
            cell = ValueCell(selectedSite.JobDescription);
            cell.Colspan = 3;
            table.AddCell(cell);

            //  3rd row
            table.AddCell(HeaderCell("Supervisor:"));
            table.AddCell(ValueCell(supervisor.Firstname + " " + supervisor.Surname));
            table.AddCell(HeaderCell("Inspector:"));
            table.AddCell(ValueCell(inspector.Firstname + " " + inspector.Surname));
            table.AddCell(HeaderCell("Type:"));
            table.AddCell(ValueCell(selectedSite.Type));

            // Creating some space before displaying the table
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph(" "));
            document.Add(table);
        }

        private static void addInterventionsTable(Document document, int siteInspectionId, PdfPTable table, PdfPCell cell)
        {
            // Get Headers and their SubHeaders
            List<Header> headers = Header.getHeaders();
            List<SubHeader> subHeaders = SubHeader.getSubHeaders();
            List<Intervention> interventions = Intervention.getInterventions(siteInspectionId);

            // Tables headers
            table = new PdfPTable(5);
            table.TotalWidth = 550f;
            table.LockedWidth = true;

            table.AddCell(HeaderCell(""));
            table.AddCell(HeaderCell("Interventions"));
            table.AddCell(HeaderCell("Comment"));
            table.AddCell(HeaderCell("Completed"));
            table.AddCell(HeaderCell("Action Taken"));

            Dictionary<string, int> interventionsBySection = new Dictionary<string, int>();

            foreach (Header header in headers)
            {

                cell = HeaderCell(header.Title);
                cell.Colspan = 5;
                table.AddCell(cell);

                for (int i = 0; i < subHeaders.Count; i++)
                {
                    if (subHeaders[i].HeaderId == header.HeaderId)
                    {
                        bool encountered = false;
                        table.AddCell(ValueCell($"{i + 1}. {subHeaders[i].SubTitle}"));

                        for (int j = 0; j < interventions.Count; j++)
                        {

                            if (interventions[j].SubHeaderID == subHeaders[i].SubHeaderId)
                            {
                                interventionsBySection[header.Title] += interventions[j].Count;

                                encountered = true;
                                string boolToWord = interventions[j].Completed ? "Yes" : "No";

                                table.AddCell(ValueCell($"{interventions[j].Count}", true));
                                table.AddCell(ValueCell($"{interventions[j].Comment}"));
                                table.AddCell(ValueCell($"{boolToWord}", true));
                                table.AddCell(ValueCell($"{interventions[j].ActionTaken}"));
                            }
                        }

                        if (!encountered)
                        {
                            table.AddCell(ValueCell("0", true));
                            table.AddCell(ValueCell(""));
                            table.AddCell(ValueCell("", true));
                            table.AddCell(ValueCell(""));
                        }
                    }
                }

            }

            // Creating some space before displaying the table
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph(" "));
            document.Add(table);
        }


        // Methods for styling Header cell and Value cell, in order to distinguish
        private static PdfPCell HeaderCell(string title)
        {
            PdfPCell cell = new PdfPCell(new Phrase(title, FontFactory.GetFont("Arial", 12, Font.BOLD, BaseColor.BLACK)));
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.PaddingBottom = 7f;
            cell.PaddingTop = 7f;
            return cell;
        }
        private static PdfPCell ValueCell(string value, bool isHorizontalAlignmentCenter = false)
        {
            PdfPCell cell = new PdfPCell(new Phrase(value, FontFactory.GetFont("Arial", 10, Font.NORMAL, BaseColor.BLACK)));
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.HorizontalAlignment = isHorizontalAlignmentCenter ? Element.ALIGN_CENTER : Element.ALIGN_LEFT;
            cell.PaddingBottom = 7f;
            cell.PaddingTop = 7f;
            return cell;
        }
    }
}
