using MainApp;

var student1 = new Student("Shersod","Dushanbe");
student1.AddCourseGrade("C#", 80);
student1.AddCourseGrade("C++", 50);
student1.AddCourseGrade("html", 40);

Console.Write("Grades: ");
student1.PrintGrades();
Console.WriteLine();
Console.WriteLine("Average: "+student1.GetAverageGrade());
Console.WriteLine(student1.ToString());
Console.WriteLine();



var teacher1 = new Teacher("Abdulloh", "Asht");
teacher1.AddCourse("C#");
teacher1.AddCourse("C");
teacher1.AddCourse("C++");
Console.WriteLine(teacher1.AddCourse("Cdfh"));
teacher1.PrintCource();
Console.WriteLine();
Console.WriteLine(teacher1.RemoveCourse("C"));
teacher1.PrintCource();
Console.WriteLine();
Console.WriteLine(teacher1.ToString());



