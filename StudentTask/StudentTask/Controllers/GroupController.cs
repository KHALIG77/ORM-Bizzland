using Microsoft.AspNetCore.Mvc;
using StudentTask.DataStudents;
using StudentTask.Models;

namespace StudentTask.Controllers
{
	public class GroupController:Controller
	{
		public ViewResult Index()
		{
			return View(Data.Group);
		}
		public ViewResult About()
		{
			return View(Data.about);
		}
		public ViewResult Contact()
		{

			return View(Data.Contact);
		}
	}
}
