using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TripProject.Areas.Admin.Models;

namespace TripProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticExcel()
        {
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("StatikRapor");

            workSheet.Cells[1, 1].Value = "Rota";
            workSheet.Cells[1, 2].Value = "Rehber";
            workSheet.Cells[1, 3].Value = "Kontenjan";

            workSheet.Cells[2, 1].Value = "Gürcistan";
            workSheet.Cells[2, 2].Value = "Ali Demir";
            workSheet.Cells[2, 3].Value = "30";

            workSheet.Cells[3, 1].Value = "Batum";
            workSheet.Cells[3, 2].Value = "Cenk Deniz";
            workSheet.Cells[3, 3].Value = "20";

            workSheet.Cells[4, 1].Value = "Karadeniz";
            workSheet.Cells[4, 2].Value = "Semih Varan";
            workSheet.Cells[4, 3].Value = "40";

            var bytes = excel.GetAsByteArray();
            return File(bytes,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","StatikRapor.xlsx");
        }


        public List<DestinationExcelModel> DestinationList()
        {
            List<DestinationExcelModel> destinationModel = new List<DestinationExcelModel>();
            using (var c = new Context())
            {
                destinationModel = c.DestinationDbSet.Select(x => new DestinationExcelModel
                {
                    City = x.City,
                    Capacity = x.Capacity,
                    DayNight = x.DayNight,
                    Price = x.Price,

                }).ToList();

            }
            return destinationModel;
        }

        public IActionResult DynamicExcel()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("DinamikExcel");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Kapasite";
                workSheet.Cell(1, 3).Value = "Süre";
                workSheet.Cell(1, 4).Value = "Fiyat";

                int rowCount = 2;

                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 2).Value = item.Capacity;
                    workSheet.Cell(rowCount, 3).Value = item.DayNight;
                    workSheet.Cell(rowCount, 3).Value = item.Price;
                    rowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DinamikRapor.xlsx");
                }
            }
        }

    }
}
