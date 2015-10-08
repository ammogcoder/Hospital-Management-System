using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

/// <summary>
/// Summary description for PrintIPDRegistrationReportBL
/// </summary>
public class PrintIPDRegistrationReportBL
{
    public byte[] PrintIPDRegistrationReport(string reportId, string patientName, 
        string patientId, string patientGeneralHealth, string patientRegularMedications,
        string patientAllergyStatus, string patientAllergies, string patientPastSurgeryStatus,
        string patientSurgery1, string patientSurgery1Date, string patientSurgery2,
        string patientSurgery2Date, string patientSurgery3, string patientSurgery3Date,
        string patientMedicalInsuranceStatus, string patientMedicalInsuranceProvider,
        string patientMedicalInsurancePolicyNumber, string patientHeight,
        string patientWeight, string patientAttendingDoctor, string patientAdmissionWard,
        string patientWardNumber, string patientDateOfAdmit, string patientTimeOfAdmit,
        string patientRemark)
    {
        Document document = new Document(PageSize.A4);
        Font NormalFont = FontFactory.GetFont("Arial", 12, Font.NORMAL, Color.BLACK);
        using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
        {
            PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
            PdfPTable table = null;
            Phrase phrase = null;
            PdfPCell cell = null;
            Paragraph paragraph = null;
            Color color = null;

            document.Open();

            table = new PdfPTable(2);
            float[] widths = new float[] { 5f, 10f };
            table.SetWidths(widths);

            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(System.Web.HttpContext.Current.Server.MapPath("../images/logo.png"));
            image.ScaleAbsolute(80, 80);
            cell = new PdfPCell(image);
            
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("ABC Hospital\n\n", FontFactory.GetFont("Arial", 18, Font.BOLD, Color.RED)));
            phrase.Add(new Chunk("123, Bodakdev\n", FontFactory.GetFont("Arial", 9, Font.NORMAL, Color.BLACK)));
            phrase.Add(new Chunk("Ahmedabad 380015\n", FontFactory.GetFont("Arial", 9, Font.NORMAL, Color.BLACK)));
            phrase.Add(new Chunk("INDIA\n", FontFactory.GetFont("Arial", 9, Font.NORMAL, Color.BLACK)));
            phrase.Add(new Chunk("Ph:- 9543289345\n", FontFactory.GetFont("Arial", 9, Font.NORMAL, Color.BLACK)));
            phrase.Add(new Chunk("Website:- http://www.abchospital.com\n", FontFactory.GetFont("Arial", 9, Font.NORMAL, Color.BLACK)));

            cell = new PdfPCell(phrase);
            
            table.AddCell(cell);

            color = new Color(System.Drawing.ColorTranslator.FromHtml("#000000"));
            DrawLine(writer, 25f, document.Top - 110f, document.PageSize.Width - 25f, document.Top - 110f, color);
            DrawLine(writer, 25f, document.Top - 110f, document.PageSize.Width - 25f, document.Top - 110f, color);

            phrase = new Phrase();
            phrase.Add(new Chunk("IPD REGISTRATION REPORT\n\n", FontFactory.GetFont("Arial", 16, Font.BOLD, Color.BLACK)));

            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.SpacingBefore = 50;
            paragraph.SpacingAfter = 30;

            document.Add(table);
            document.Add(paragraph);

            table = new PdfPTable(2);

            phrase = new Phrase();
            phrase.Add(new Chunk("Report ID", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(reportId, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Report Date", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(DateTime.Now.ToString(), FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Patient Name", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            cell.PaddingBottom = 20;
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientName, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Patient ID", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientId, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Patient General Health", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientGeneralHealth, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Regular Medications", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientRegularMedications, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Allergy Status", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientAllergyStatus, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Allergies", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientAllergies, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Allergy Status", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientAllergyStatus, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Major Surgeries Status", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientPastSurgeryStatus, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Surgery 1", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientSurgery1, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Surgery 1 Date", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientSurgery1Date, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Surgery 2", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientSurgery2Date, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Surgery 3", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientSurgery3, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Surgery 3 Date", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientSurgery3Date, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Medical Insurance Status", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientMedicalInsuranceStatus, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Insurance Provider", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientMedicalInsuranceProvider, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Medical Insurance Policy Number", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientMedicalInsurancePolicyNumber, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Patient Height (ft.)", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientHeight, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Patient Weight (kg)", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientWeight, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Attending Doctor", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientAttendingDoctor, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Patient Admission Ward", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientAdmissionWard, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Patient Admission Ward Number", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientWardNumber, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Date Of Admit", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientDateOfAdmit, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Time Of Admit", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(patientTimeOfAdmit, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            table.HorizontalAlignment = Element.ALIGN_CENTER;

            document.Add(table);

            DrawLine(writer, 25f, document.Top - 750f, document.PageSize.Width - 25f, document.Top - 750f, color);
            DrawLine(writer, 25f, document.Top - 750f, document.PageSize.Width - 25f, document.Top - 750f, color);

            document.Close();
            byte[] bytes = memoryStream.ToArray();
            using (FileStream fs = File.Create(System.Web.HttpContext.Current.Server.MapPath("../Reports/IPDRegistration/" + reportId + ".pdf")))
            {
                fs.Write(bytes, 0, (int)bytes.Length);
            }
            memoryStream.Close();
            return bytes;
        }
    }

    private static void DrawLine(PdfWriter writer, float x1, float y1, float x2, float y2, Color color)
    {
        PdfContentByte contentByte = writer.DirectContent;
        contentByte.SetColorStroke(color);
        contentByte.MoveTo(x1, y1);
        contentByte.LineTo(x2, y2);
        contentByte.Stroke();
    }
}