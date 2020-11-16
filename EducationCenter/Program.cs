using System;
using System.Collections;

namespace EducationCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(01, "Ульяна", "Цверкович");
            student1.SetBirthday(06, 11, 1998);
            student1.Faculty = "Филологический";
            student1.Group = 789;
            student1.Show();
            Console.WriteLine(student1.GetAge());

            Student student2 = new Student(02, "Борис", "Романов");
            student2.SetBirthday(08, 08, 1976);
            student2.Faculty = "Биологический";
            student2.Group = 321;
            student2.Show();

            Teacher teacher1 = new Teacher(3, "Даниил", "Бакулин");
            teacher1.SetBirthday(01, 01, 1949);
            teacher1.SetJob(03, 11, 1987);
            teacher1.Faculty = "Экономический";
            teacher1.Position = "Кандидадт экономических наук";
            teacher1.Show();
            teacher1.Сoefficient = 0.15;
            teacher1.Coin = 1000;
            Console.WriteLine(teacher1.CalculateSalary(150));


            Manager manager = new Manager(12, "Александр", "Батышев", "Экономический");
            manager.SetBirthday(16, 04, 1960);
            manager.SetJob(11, 10, 2005);
            manager.Сoefficient = 0.1;
            manager.Coin = 500;
            manager.Show();
            Console.WriteLine(manager.CalculateSalary(160));
            manager.IfSick = true;
            manager.Sick();
            teacher1.IfVacation = true;
            teacher1.Vacation();

            Teacher teacher2 = new Teacher(4, "Даниил", "Бакулин");
            teacher2.SetBirthday(13, 11, 1971);
            teacher2.SetJob(04, 12, 1993);
            teacher2.Faculty = "Биологический";
            teacher2.Position = "Доцент";
            teacher2.Show();
            teacher2.Сoefficient = 0.10;
            teacher2.Coin = 1600;
            Console.WriteLine(teacher2.CalculateSalary(140));


            ArrayList Employees = new ArrayList(); 
            Employees.Add(manager);
            Employees.Add(teacher1);
            Employees.Add(teacher2);
            ShowArray(Employees);
        }

        public static void ShowArray(ArrayList a)
        {
            foreach (Person o in a)
                o.Show();
        }
    }
}
