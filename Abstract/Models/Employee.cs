using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Models
{
    class Employee : Person
    {
        private int _salaryOfHour;
        private int _workingHour;
        private int _Age;
        public Employee(string name, string surname, int age, int salaryofhour, int workinghour)
        {
            _name = name;
            _surname = surname;
            _age = age;
            SalaryOfHour = salaryofhour;
            WorkingHour = workinghour;

        }
        public int SalaryOfHour
        {
            get
            { return _salaryOfHour; }
            set
            {
                if (value > 0)
                {
                    _salaryOfHour = value;
                }
            }
        }
        public int WorkingHour
        {
            get
            { return _workingHour; }
            set
            {
                if (value > 240 && value > 0)
                {
                    _workingHour = value;
                }
            }
        }
        public override int _age
        {
            get { return _Age; }
            set
            {
                if (value > 18)
                {
                    _Age = value;
                }
            }
        }

        public void CalculateSalary()
        {

            if (WorkingHour * SalaryOfHour > 250)
            {
                Console.WriteLine("Worker's salary is " + WorkingHour * SalaryOfHour);
            }
        }
    }
}
