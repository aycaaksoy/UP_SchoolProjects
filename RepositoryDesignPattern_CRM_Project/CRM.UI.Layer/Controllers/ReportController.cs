using ClosedXML.Excel;
using CRM.DataAccess.Layer.Concrete;
using CRM.UI.Layer.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CRM.UI.Layer.Controllers
{
    public class ReportController : Controller
    {   public IActionResult ReportList()
        {
            return View();  
        }
        // static excel list
        public IActionResult ExcelStatic()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");
            worksheet.Cells[1, 1].Value = "Employee ID";
            worksheet.Cells[1, 2].Value = "Employee Name";
            worksheet.Cells[1, 3].Value = "Employee Surname";

            worksheet.Cells[2, 1].Value = "0001";
            worksheet.Cells[2, 2].Value = "Atilla";
            worksheet.Cells[2, 3].Value = "Aksoy";


            worksheet.Cells[3, 1].Value = "0002";
            worksheet.Cells[3, 2].Value = "Arzu";
            worksheet.Cells[3, 3].Value = "Aksoy";


            var bytes = excelPackage.GetAsByteArray();
            return File(bytes,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","employees.xlsx");
        }

        public List<CustomerView> CustomerList()
        {
            List<CustomerView> customerViewModels = new List<CustomerView>();
            using (var context = new Context())
            {
                customerViewModels = context.Customers.Select(x => new CustomerView
                {
                    Email = x.CustomerEmail,
                    Name = x.CustomerName,
                    Surname = x.CustomerSurname,
                    Phone = x.CustomerPhone
                }).ToList();
                return customerViewModels;
            }
        }
        public IActionResult DynamicExcel()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Customer List");
                workSheet.Cell(1, 1).Value = "Email ";
                workSheet.Cell(1, 2).Value = "Name ";
                workSheet.Cell(1, 3).Value = "Surname ";

                int rowCount = 2;
                foreach(var item in CustomerList()) 
                {
                    workSheet.Cell(rowCount, 1).Value = item.Email;
                    workSheet.Cell(rowCount, 2).Value = item.Name;
                    workSheet.Cell(rowCount, 3).Value = item.Surname;
                    rowCount++;
                }
                using(var stream=new MemoryStream())
                {
                    workBook.SaveAs(stream);    
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","customers_list.xlsx");
                }
            }
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/PdfReports/"+"Customer_list.pdf");
            var stream=new FileStream(path,FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();    
            Paragraph paragraph = new Paragraph("Static writing...");
            document.Add(paragraph);    
            document.Close();
            return File("/PdfReports/Customer_list.pdf","application/pdf","Customer_list.pdf");
        }
    }
}

