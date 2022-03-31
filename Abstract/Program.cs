using Abstract.Models;
using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("Ebulfez","Sadiqov",17,100,80);
            stu.ExamResult();

            Employee emp = new Employee("Ebulfez","Sadiqov",30,100,300);
            emp.CalculateSalary();
        }
    }
}
