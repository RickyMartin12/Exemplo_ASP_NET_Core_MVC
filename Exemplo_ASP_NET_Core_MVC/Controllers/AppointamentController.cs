using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_ASP_NET_Core_MVC.Controllers
{
    public class AppointamentController : Controller
    {

        public IActionResult Index()
        {
            string today = DateTime.Now.ToShortDateString();
            return Ok(today);
            //return View();
        }

        /*IActionResult GetAllEmployees(AppDbContext db)
        {
            return Ok(db.Employees.ToList());
        }*/









    }

}
