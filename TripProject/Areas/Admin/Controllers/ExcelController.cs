using BusinessLayer.Abstract;
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
        private readonly IExcelService _excelService;
        
        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticExcel()
        {
            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BusinessExcel.xlsx");
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
