using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_MVC_CORE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_MVC_CORE.Controllers
{
    public class NewRecordController : Controller
    {
        private readonly ConnectionStringClass _connection;
        public NewRecordController(ConnectionStringClass connection)
        {
            _connection = connection;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmpClass emp)
        {
            _connection.Add(emp);
            _connection.SaveChanges();
            ViewBag.message = "The Record for"+emp.EmpName+"is saved successfully..........!";
            return View();
        }
        //before creating views on must build the application
    }
}