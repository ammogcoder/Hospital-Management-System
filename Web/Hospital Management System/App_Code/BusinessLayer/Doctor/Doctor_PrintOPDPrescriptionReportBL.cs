using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

/// <summary>
/// Summary description for PrintOPDPrescriptionReportBL
/// </summary>
public class Doctor_PrintOPDPrescriptionReportBL
{
	public byte[] Doctor_PrintOPDPrescriptionReport(string reportId, string appointmentToken, 
        string doctorName, string appointmentDate, string appointmentTime, string patientId, 
        string patientName, List<Doctor_OPDTreatmentMedicineBO> objOPDTreatmentMedicineBOList, string treatmentDiagnosis)
	{
		Document document = new Document(PageSize.A3);
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
            cell.Border = Rectangle.NO_BORDER;
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("ABC Hospital\n\n", FontFactory.GetFont("Arial", 18, Font.BOLD, Color.RED)));
            phrase.Add(new Chunk("123, Bodakdev\n", FontFactory.GetFont("Arial", 9, Font.NORMAL, Color.BLACK)));
            phrase.Add(new Chunk("Ahmedabad 380015\n", FontFactory.GetFont("Arial", 9, Font.NORMAL, Color.BLACK)));
            phrase.Add(new Chunk("INDIA\n", FontFactory.GetFont("Arial", 9, Font.NORMAL, Color.BLACK)));
            phrase.Add(new Chunk("Ph:- 9543289345\n", FontFactory.GetFont("Arial", 9, Font.NORMAL, Color.BLACK)));
            phrase.Add(new Chunk("Website:- http://www.abchospital.com\n", FontFactory.GetFont("Arial", 9, Font.NORMAL, Color.BLACK)));

            cell = new PdfPCell(phrase);
            cell.Border = Rectangle.NO_BORDER;
            table.AddCell(cell);

            color = new Color(System.Drawing.ColorTranslator.FromHtml("#000000"));
            DrawLine(writer, 25f, document.Top - 110f, document.PageSize.Width - 25f, document.Top - 110f, color);
            DrawLine(writer, 25f, document.Top - 110f, document.PageSize.Width - 25f, document.Top - 110f, color);

            phrase = new Phrase();
            phrase.Add(new Chunk("OPD PRESCRIPTION REPORT\n\n", FontFactory.GetFont("Arial", 16, Font.BOLD, Color.BLACK)));

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
            phrase.Add(new Chunk("Appointment Token", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(appointmentToken, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Doctor", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(doctorName, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Appointment Date", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(appointmentDate, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Appointment Time", FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk(appointmentTime, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
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
            paragraph = new Paragraph();
            paragraph.Add(new Chunk("\n"));
            document.Add(paragraph);

            table = new PdfPTable(9);
            widths = new float[] { 1.5f, 4f, 4f, 2.3f, 2.3f, 4f, 2.2f, 3f, 5f };
            table.SetWidths(widths);

            phrase = new Phrase();
            phrase.Add(new Chunk("No.", FontFactory.GetFont("Arial", 11, Font.BOLD, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Medicine Type", FontFactory.GetFont("Arial", 11, Font.BOLD, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Medicine Name", FontFactory.GetFont("Arial", 11, Font.BOLD, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Strength", FontFactory.GetFont("Arial", 11, Font.BOLD, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Quantity", FontFactory.GetFont("Arial", 11, Font.BOLD, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Start Date", FontFactory.GetFont("Arial", 11, Font.BOLD, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("# Refills", FontFactory.GetFont("Arial", 11, Font.BOLD, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Quantity on Refill", FontFactory.GetFont("Arial", 11, Font.BOLD, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            phrase = new Phrase();
            phrase.Add(new Chunk("Instructions", FontFactory.GetFont("Arial", 11, Font.BOLD, Color.BLACK)));
            cell = new PdfPCell(phrase);
            cell.PaddingBottom = 20;
            paragraph = new Paragraph();
            paragraph.Add(phrase);
            paragraph.Alignment = Element.ALIGN_CENTER;
            cell.AddElement(paragraph);
            table.AddCell(cell);

            for(int i = 0; i < objOPDTreatmentMedicineBOList.Count; i++)
            {
                phrase = new Phrase();
                phrase.Add(new Chunk((i+1).ToString(), FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
                cell = new PdfPCell(phrase);
                cell.PaddingBottom = 20;
                paragraph = new Paragraph();
                paragraph.Add(phrase);
                paragraph.Alignment = Element.ALIGN_CENTER;
                cell.AddElement(paragraph);
                table.AddCell(cell);

                phrase = new Phrase();
                phrase.Add(new Chunk(objOPDTreatmentMedicineBOList[i].medicineType, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
                cell = new PdfPCell(phrase);
                cell.PaddingBottom = 20;
                paragraph = new Paragraph();
                paragraph.Add(phrase);
                paragraph.Alignment = Element.ALIGN_CENTER;
                cell.AddElement(paragraph);
                table.AddCell(cell);

                phrase = new Phrase();
                phrase.Add(new Chunk(objOPDTreatmentMedicineBOList[i].medicineName, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
                cell = new PdfPCell(phrase);
                cell.PaddingBottom = 20;
                paragraph = new Paragraph();
                paragraph.Add(phrase);
                paragraph.Alignment = Element.ALIGN_CENTER;
                cell.AddElement(paragraph);
                table.AddCell(cell);

                phrase = new Phrase();
                phrase.Add(new Chunk(objOPDTreatmentMedicineBOList[i].medicineStrength, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
                cell = new PdfPCell(phrase);
                cell.PaddingBottom = 20;
                paragraph = new Paragraph();
                paragraph.Add(phrase);
                paragraph.Alignment = Element.ALIGN_CENTER;
                cell.AddElement(paragraph);
                table.AddCell(cell);

                phrase = new Phrase();
                phrase.Add(new Chunk(objOPDTreatmentMedicineBOList[i].medicineQuantity, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
                cell = new PdfPCell(phrase);
                cell.PaddingBottom = 20;
                paragraph = new Paragraph();
                paragraph.Add(phrase);
                paragraph.Alignment = Element.ALIGN_CENTER;
                cell.AddElement(paragraph);
                table.AddCell(cell);

                phrase = new Phrase();
                phrase.Add(new Chunk(objOPDTreatmentMedicineBOList[i].medicineStartDate, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
                cell = new PdfPCell(phrase);
                cell.PaddingBottom = 20;
                paragraph = new Paragraph();
                paragraph.Add(phrase);
                paragraph.Alignment = Element.ALIGN_CENTER;
                cell.AddElement(paragraph);
                table.AddCell(cell);

                phrase = new Phrase();
                phrase.Add(new Chunk((objOPDTreatmentMedicineBOList[i].numberOfRefills).ToString(), FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
                cell = new PdfPCell(phrase);
                cell.PaddingBottom = 20;
                paragraph = new Paragraph();
                paragraph.Add(phrase);
                paragraph.Alignment = Element.ALIGN_CENTER;
                cell.AddElement(paragraph);
                table.AddCell(cell);

                phrase = new Phrase();
                phrase.Add(new Chunk(objOPDTreatmentMedicineBOList[i].quantityOnRefills, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
                cell = new PdfPCell(phrase);
                cell.PaddingBottom = 20;
                paragraph = new Paragraph();
                paragraph.Add(phrase);
                paragraph.Alignment = Element.ALIGN_CENTER;
                cell.AddElement(paragraph);
                table.AddCell(cell);

                phrase = new Phrase();
                phrase.Add(new Chunk(objOPDTreatmentMedicineBOList[i].medicineInstructions, FontFactory.GetFont("Arial", 11, Font.NORMAL, Color.BLACK)));
                cell = new PdfPCell(phrase);
                cell.PaddingBottom = 20;
                paragraph = new Paragraph();
                paragraph.Add(phrase);
                paragraph.Alignment = Element.ALIGN_CENTER;
                cell.AddElement(paragraph);
                table.AddCell(cell);
            }

            table.HorizontalAlignment = Element.ALIGN_CENTER;

            document.Add(table);

            DrawLine(writer, 25f, document.Top - 750f, document.PageSize.Width - 25f, document.Top - 750f, color);
            DrawLine(writer, 25f, document.Top - 750f, document.PageSize.Width - 25f, document.Top - 750f, color);

            document.Close();
            byte[] bytes = memoryStream.ToArray();
            using (FileStream fs = File.Create(System.Web.HttpContext.Current.Server.MapPath("../Reports/OPDPrescription/" + reportId + ".pdf")))
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