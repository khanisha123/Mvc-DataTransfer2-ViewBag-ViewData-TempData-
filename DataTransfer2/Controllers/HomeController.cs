using DataTransfer2.Models;
using DataTransfer2.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTransfer2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            #region ViewBag,ViewData,TempData
            //ViewBag.Name = "Lorem";
            //List<Student> stu = new List<Student>
            //{
            //    new Student{Id=1,Name="Gunel",Age=19},
            //     new Student{Id=2,Name="Tural",Age=20},
            //     new Student{Id=3,Name="Hebib",Age=25},

            //};
            //ViewBag.Student = stu;
            //ViewData["students"] = stu;
            //ViewBag.Name = "Ibrahim";
            //ViewData["LastName"] = "Aliyev";
            //TempData["Age"] = 27;

            //return RedirectToAction("About");
            //return RedirectToAction(nameof(About));
            #endregion


            List<Student> stu = new List<Student>
            {
                new Student{Id=1,Name="Gunel",Age=19},
                 new Student{Id=2,Name="Tural",Age=20},
                 new Student{Id=3,Name="Hebib",Age=25},

            };

            //var student = new Student { Id = 1, Name = "Gunel", Age = 19 };
            //ReturnStudent returnStu = new ReturnStudent();
            //returnStu.Name = student.Name;
            int[] arr = new int[4] { 1, 2, 4, 5 };
            HomeVM homeVM = new HomeVM() { };
            homeVM.Students = stu;
            homeVM.arr = arr;
            return View(homeVM);

        }
        public IActionResult About() {

            //ViewBag.Name = "Ibrahim";
            //ViewData["LastName"] = "Aliyev";
            //TempData["Age"] = 27;
            TempData["Age"] = 25;
            return View();

        }
    }
    public class ReturnStudent {
        public int Name { get; set; }
    }
}
