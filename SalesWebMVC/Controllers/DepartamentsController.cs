using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> ListDepa = new List<Departament>();
            ListDepa.Add(new Departament { Id = 1, Name = "Eletronics" });
            ListDepa.Add(new Departament { Id = 2, Name = "Fashion" });

            return View(ListDepa);
        }
    }
}
