using System.Collections.Generic;
using StudentTask.Models;

namespace StudentTask.ViewModels
{
	public class StudentViewModel
	{
		public List<Student> Students { get; set; }
		public List<Group> Groups { get; set; }
	}
}
