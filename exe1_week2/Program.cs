using System;

namespace exe1_week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.setFirstName("Rafał");
            employee1.LastName = "Mrozowski";
            employee1.setSalary(2500.5);
            Console.WriteLine("Employee 1: " + employee1.getFirstName() + " " + employee1.LastName + employee1.getSalaryPerYear());

            employee2.setFirstName("Marek");
            employee2.LastName = "Takijakis";
            employee2.setSalary(3299);
            Console.WriteLine("Employee 1: " + employee2.getFirstName() + " " + employee2.LastName + employee2.getSalaryPerYear());
        }
    }

    class Person
    {
        private string _firstName;
        private string _lastName;
        public string LastName
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
