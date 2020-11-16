using System;

namespace EducationCenter
{
    class Employee : Person, IEmployee
    {
        private int standing; 
        private DateTime job; 
        public decimal Coin { get; set; }
        public double Сoefficient { get; set; }
        private decimal Salary;

        public Employee()
        { }
        public Employee(long IDnumber, string name, string surname) : base(IDnumber, name, surname)
        {
        }

        public void SetJob(int day, int month, int year)
        {
            job = new DateTime(year, month, day);
        }
        public DateTime GetJob()
        {
            return job;
        }

        public int GetStanding()
        {
            standing = DateTime.Now.Year - job.Year;
            if (DateTime.Now.Month < job.Month || (DateTime.Now.Month == job.Month && DateTime.Now.Day < job.Day))
            {
                standing--;
            }
            return standing;
        }

        public decimal CalculateSalary(int time)
        {

            return Salary = Coin * (decimal)(time * (GetStanding() * Сoefficient));
        }


        public bool IfVacation
        {
            get;
            set;
        }
        public void Vacation()
        {
            Console.WriteLine("{1} {2} отпуск: {0}", IfVacation, name, surname );
        }

        public bool IfSick
        {
            get;
            set;
        }
        public void Sick()
        {
            Console.WriteLine("{1} {2} ,больничный: {0}", IfSick, name, surname);
        }
    }
}
