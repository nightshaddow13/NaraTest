using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NaraWebApp.Controllers
{
    public class TaskController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            return "This is the default action";
        }
        public string ManageTask(string task, int ID)
        {
            return $"This is the task manager {task} is important with this {ID}";
        }
    }

}
