using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Student
    {
        public Student(string lastName, DateTime birthday)
        {
            this.lastName = lastName;
            this.birthday = birthday;
        }

        public Student(string lastName, string firstName, string middleName ,DateTime birthday):this(lastName, birthday)
        {
            _firstName=firstName;
            _middleName=middleName;
        }

        public Student(Student student)
        {
            _firstName = student._firstName;
            _middleName = student._middleName;
            lastName = student.lastName;
            birthday=student.birthday;
                        
        }
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        private string _firstName;
        private string _middleName;
        private string lastName;
        private DateTime birthday;

        public void Print()
        {
            Console.WriteLine($"Name: {_firstName}\nLastName: {lastName}\nMiddleName: {_middleName}\nbirthday: {birthday} ");
        }

    }
}
