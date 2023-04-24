using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StudentTask.Models;
using StudentTask.DataStudents;
using StudentTask.ViewModels;
using System.Security.Cryptography.X509Certificates;

namespace StudentTask.Controllers
{
	public class StudentController:Controller
	{
		public ViewResult Index()
		{
			List<Student> student = Data.Student;
			List<Group> group = Data.Group;
			
			StudentViewModel studentViewModel = new StudentViewModel()
			{
				Students = student,
				Groups = group
			};


			return View(studentViewModel);
		}
		public ViewResult Detail(int id)
		{
			Student StundetDetail = Data.Student.Find(val => val.Id == id);
			
			if (StundetDetail == null) {
				ViewResult resulterror = new ViewResult();
				resulterror.ViewName = "errorpage";
				  return resulterror ;
			}
			else
			{
				
					return View(StundetDetail);
			}

			
			
			
		}
	}
}
