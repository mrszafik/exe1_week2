using System;

namespace exe1_week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Person
    {
        private string _firstName;
        private string _lastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public Person(){ }

        public void setFirstName(string firstName)
        {
            _firstName = firstName;
        }

        public string getFirstName()
        {
            return _firstName;
        }

        //public void setLastName(string lastName)
        //{
        //    _lastName = lastName;
        //}

        //public string getLastName()
        //{
        //    return _lastName;
        //}

    }

    class Employee : Person
    {
        private double _salary;
        public Employee() { }

        public void setSalary(double salary)
        {
            _salary = salary;
        }
        public double getSalary()
        {
            return _salary;
        }

        public double getSalaryPerYear()
        {
            return 12 * _salary;
        }
    }
}
