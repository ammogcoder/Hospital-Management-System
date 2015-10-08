using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

/// <summary>
/// Summary description for PrintOPDMedicalTestRegistrationInvoiceBL
/// </summary>
public class PrintOPDMedicalTestRegistrationInvoiceBL
{
    public byte[] PrintOPDMedicalTestRegistrationInvoice(string invoiceId, string patientName, 
        string patientId, string testDate, string testTime, List<string> medicalTestList)
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
            phrase.Add(new Chunk("OPD MEDICAL TEST REGISTRATION INVOICE\n\n", FontFactory.GetFont("Arial", 16, Font.BOLD, Color.BLACK)));

            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.SpacingBefore = 50;
            paragraph.SpacingAfter = 30;

            document.Add(table);
            document.Add(paragraph);

            table = new PdfPTable(2);

            phrase = new Phrase();
            phrase.Add(new Chunk("Invoice ID", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);        
            cell.PaddingBottom = 20;
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(invoiceId, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Invoice Date", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
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
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
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
            phrase.Add(new Chunk("Date Of Medical Test", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(testDate, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Time Of Medical Test", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(testTime, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            table.HorizontalAlignment = Element.ALIGN_CENTER;

            document.Add(table);

            paragraph = new Paragraph();
            paragraph.Add(new Chunk("\n"));
            document.Add(paragraph);

            table = new PdfPTable(2);
            widths = new float[] { 2f, 10f };
            table.SetWidths(widths);

            phrase = new Phrase();
            phrase.Add(new Chunk("Sr. No.", FontFactory.GetFont("Arial", 12, Font.BOLD, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            cell.PaddingBottom = 20;
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Medical Test Type", FontFactory.GetFont("Arial", 12, Font.BOLD, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            cell.PaddingBottom = 20;
            table.AddCell(cell);

            for (int i = 0; i < medicalTestList.Count; i++)
            {
                phrase = new Phrase();
                phrase.Add(new Chunk((i+1).ToString(), FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
                cell = new PdfPCell(phrase);
                paragraph = new Paragraph();
                paragraph.Add(phrase);
                paragraph.Alignment = Element.ALIGN_CENTER;
                cell.AddElement(paragraph);
                table.AddCell(cell);

                phrase = new Phrase();
                phrase.Add(new Chunk(medicalTestList.ElementAt(i), FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
                cell = new PdfPCell(phrase);
                paragraph = new Paragraph();
                paragraph.Add(phrase);
                paragraph.Alignment = Element.ALIGN_CENTER;
                cell.AddElement(paragraph);
                cell.PaddingBottom = 10;
                table.AddCell(cell);
            }

            table.HorizontalAlignment = Element.ALIGN_CENTER;

            document.Add(table);

            DrawLine(writer, 25f, document.Top - 750f, document.PageSize.Width - 25f, document.Top - 750f, color);
            DrawLine(writer, 25f, document.Top - 750f, document.PageSize.Width - 25f, document.Top - 750f, color);

            document.Close();
            byte[] bytes = memoryStream.ToArray();
            using (FileStream fs = File.Create(System.Web.HttpContext.Current.Server.MapPath("../Invoice/OPDMedicalTestRegistration/" + invoiceId + ".pdf")))
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