using System;
using System.Linq;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swift.Models;

namespace Swift.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext _context;
        public AccountController(DataContext context)
        {
            _context = context;
        }

        [Route("/account/register")]

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterAction(UserAccount userAccount)
        {
            var user = new UserAccount
            {
                Username = userAccount.Username,
                Password = BCrypt.Net.BCrypt.HashPassword(userAccount.Password),
                Email = userAccount.Email,
                Occupation = userAccount.Occupation,
                Income = userAccount.Income,
                Telephone = userAccount.Telephone,
                Address = userAccount.Address,
                Facebook = userAccount.Facebook,
                Ig = userAccount.Ig
            };
            _context.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public string TestFunctionAjax()
        {
            // var x = {key: "test"};
            return "test";
        }

        // ลืมรหัสผ่าน
        [HttpPost]
        public JsonResult ForgetPassword(string email)
        {
            JsonRespons jsonResponse = new JsonRespons();
            UserAccount user = _context.Users.Where(u => u.Email == email).FirstOrDefault();

            if (user == null)
            {
                jsonResponse.Status = "error";
                jsonResponse.Msg = "ไม่มี email นี้ในระบบ";
                return Json(jsonResponse);
            }

            jsonResponse.Status = "success";
            jsonResponse.Msg = "โปรดตรวจสอบลิงค์ ใน email ของคุณ";
            return Json(jsonResponse);

        }

        public JsonResult LoginAction(string username, string password)
        {
            Console.WriteLine("username : " + username);
            Console.WriteLine("password : " + password);

            JsonRespons jsonRespons = new JsonRespons();

            var verifyUser = LoginProcess(username, password);
            if (verifyUser == null)
            {
                jsonRespons.Status = "error";
                jsonRespons.Msg = "username หรือ password ไม่ถูกต้อง";

                return Json(jsonRespons);
            }
            else
            {
                HttpContext.Session.SetString("username", username);
                jsonRespons.Status = "success";
                jsonRespons.Msg = "เข้าสู่ระบบสำเร็จ";

                return Json(jsonRespons);
            }
        }

        private UserAccount LoginProcess(string username, string password)
        {
            var account = _context.Users.SingleOrDefault(a => a.Username.Equals(username));
            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, account.Password))
                {
                    return account;
                }
            }
            return null;
        }

        public JsonResult Logout()
        {
            JsonRespons jsonRespons = new JsonRespons();
            jsonRespons.Status = "success";
            jsonRespons.Msg = "ออกจากระบบสำเร็จ";

            HttpContext.Session.Remove("username");
            return Json(jsonRespons);
        }

        [HttpPost]
        public JsonResult EditUser(int id, string email, string occupation, int income, string telephone, string address, string facebook, string ig)
        {
            JsonRespons jsonRespons = new JsonRespons();
            Console.WriteLine(occupation);
            Console.WriteLine(id);

            UserAccount user = _context.Users.Find(id);

            if (user == null)
            {
                jsonRespons.Status = "error";
                jsonRespons.Msg = $"ไม่มี user ID: {id} ในระบบ";
                return Json(jsonRespons);
            }

            user.Occupation = occupation;
            user.Email = email;
            user.Income = income;
            user.Telephone = telephone;
            user.Address = address;
            user.Facebook = facebook;
            user.Ig = ig;

            _context.SaveChanges();

            jsonRespons.Status = "success";
            jsonRespons.Msg = $"แก้ไขข้อมูล user ID: {id} สำเร็จ";
            return Json(jsonRespons);
        }

        public IActionResult Profile()
        {
            string sessionUsername = HttpContext.Session.GetString("username");

            if (sessionUsername == null)
            {
                return RedirectToAction("Index", "Home");
            }

            UserAccount currentUser = _context.Users.Where(u => u.Username == sessionUsername).FirstOrDefault();
            return View(currentUser);
        }

        public JsonResult ChangePassword(string password, string newPassword, string newPasswordConfirm)
        {

            JsonRespons jsonRespons = new JsonRespons();

            string sessionUsername = HttpContext.Session.GetString("username");
            UserAccount user = _context.Users.Where(u => u.Username == sessionUsername).FirstOrDefault();

            Console.WriteLine(BCrypt.Net.BCrypt.HashPassword(newPassword));
            Console.WriteLine(user.Password);
            Console.WriteLine(BCrypt.Net.BCrypt.Verify(password, user.Password));

            if ((BCrypt.Net.BCrypt.Verify(password, user.Password)) == false)
            {
                jsonRespons.Status = "error";
                jsonRespons.Msg = "รหัสผ่านเก่าไม่ถูกต้อง";
                return Json(jsonRespons);
            }

            if (newPassword != newPasswordConfirm)
            {
                jsonRespons.Status = "error";
                jsonRespons.Msg = "ยืนยันรหัสผ่านใหม่ไม่ตรงกัน";
                return Json(jsonRespons);
            }

            if (password == newPassword)
            {
                jsonRespons.Status = "error";
                jsonRespons.Msg = "รหัสผ่านใหม่ไม่สามารถเหมือนกับรหัสผ่านเดิมได้";
                return Json(jsonRespons);
            }

            user.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
            _context.SaveChanges();
            jsonRespons.Status = "success";
            jsonRespons.Msg = "เปลี่ยนรหัสผ่านสำเร็จ กรุณาเข้าสู่ระบบอีกครั้ง";
            Logout();
            return Json(jsonRespons);
        }
    }
}