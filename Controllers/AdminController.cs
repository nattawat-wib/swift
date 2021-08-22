using System;
using System.IO;
using System.Linq;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swift.Models;

namespace Swift.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataContext _context;
        public AdminController(DataContext context)
        {
            _context = context;
        }

        [Route("/admin")]
        public IActionResult Index()
        {
            string sessionUsername = HttpContext.Session.GetString("username");

            if (sessionUsername == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var users = _context.Users.ToList();
            return View(users);            
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            JsonRespons jsonRespons = new JsonRespons();

            UserAccount user = _context.Users.Find(id);
            if (user == null)
            {
                jsonRespons.Status = "error";
                jsonRespons.Msg = $"ไม่มีบัญชี ID: {id} อยู่ในระบบ !!!!!";

                return Json(jsonRespons);
            }

            _context.Users.Remove(user);
            _context.SaveChanges();

            jsonRespons.Status = "success";
            jsonRespons.Msg = $"ลบบัญชี ID : {id} เรียบร้อยแล้ว";

            return Json(jsonRespons);
        }

        // public IActionResult ExportToExcel()
        // {
        //     var users = _context.Users.ToList();

        //     string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        //     string fileName = "users.xlsx";

        //     using (var workbook = new XLWorkbook())
        //     {
        //         IXLWorksheet worksheet =
        //         workbook.Worksheets.Add("Users");
        //         worksheet.Cell(1, 1).Value = "Id";
        //         worksheet.Cell(1, 2).Value = "Username";
        //         for (int index = 1; index <= users.Count; index++)
        //         {
        //             worksheet.Cell(index + 1, 1).Value =
        //             users[index - 1].UserId;
        //             worksheet.Cell(index + 1, 2).Value =
        //             users[index - 1].Username;
        //         }
        //         using (var stream = new MemoryStream())
        //         {
        //             workbook.SaveAs(stream);
        //             var content = stream.ToArray();
        //             return File(content, contentType, fileName);
        //         }
        //     }
        // }
    }
}