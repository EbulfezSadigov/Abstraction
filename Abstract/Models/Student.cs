using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Models
{
    class Student : Person
    {
        private int _iqRank;
        private int _languageRank;
        private int _Age;

        public Student(string name, string surname, int age, int iqrank, int languagerank)
        {
            _name = name;
            _surname = surname;
            _Age = age;
            IQRank = iqrank;
            LanguageRank = languagerank;

        }
        public override int _age
        {
            get { return _Age; }
            set
            {
                if (value > 6 && value < 20)
                {
                    _Age = value;
                }
                else if (value < 6 && value > 20)
                {

                    Console.WriteLine("Yaşınız uygun deyil");
                    _Age = value;
                }
            }
        }
        public int IQRank
        {
            get
            { return _iqRank; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _iqRank = value;
                }
            }
        }
        public int LanguageRank
        {
            get
            { return _languageRank; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _languageRank = value;
                }
            }
        }
        public void ExamResult()
        {
            if (IQRank + LanguageRank > 120)
            {
                Console.WriteLine("Exam was passed");
            }
            else
            {
                Console.WriteLine("Exam was failed");
            }
        }
    }
}
