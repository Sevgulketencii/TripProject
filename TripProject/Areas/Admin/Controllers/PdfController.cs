using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PdfController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdf()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReport/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);


            document.Open();
            Paragraph paragraph = new Paragraph("Trip project pdf report ");
            document.Add(paragraph);
            document.Close();
            

            return File("/PdfReport/dosya1.pdf","application/pdf","dosya1.pdf");
        }

        public IActionResult StaticCustomerPdf()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReport/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);


            document.Open();
           
            PdfPTable table = new PdfPTable(3);

            table.AddCell("Misafir Adı");
            table.AddCell("Misafir Soyadı");
            table.AddCell("Misafir TC");

            table.AddCell("Sevgul");
            table.AddCell("KETENCI");
            table.AddCell("6015785826");

            table.AddCell("Can");
            table.AddCell("OGE");
            table.AddCell("4564564565");

            table.AddCell("Furkan");
            table.AddCell("KETENCI");
            table.AddCell("35612544547");

            document.Add(table);
            document.Close();


            return File("/PdfReport/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }
    }
}
