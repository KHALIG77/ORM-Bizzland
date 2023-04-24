
using StudentTask.Models;
using System.Collections.Generic;


namespace StudentTask.DataStudents
{
	public static class Data
	{
	   public static List<Student> Student = new List<Student>()
			{
				new Student{Id=1,FullName="Xaliq Memmedov",Point=100},
				new Student { Id = 2, FullName = "Ibrahim Qasimzade", Point = 100 }
			};
		public static List<Group> Group = new List<Group>()
		{
			new Group { Id = 1,Name="P328"},
			new Group { Id = 2,Name="P326"}

		};
		public static Contact Contact = new Contact()
		{
			Number = 0555055555,
			Location ="8 Noyabr kucesi"
		};
		public static About about = new About()
		{
			Info = "Code Academy 2016-ci ilden fealiyyetine baslayib",
		};

		
	}
}
