using System;

namespace exe1_week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.SetFirstName("Rafał");
            employee1.LastName = "Mrozowski";
            employee1.SetSalary(2500.5);
            employee1.Describe();

            employee2.SetFirstName("Marek");
            employee2.LastName = "Takijakis";
            employee2.SetSalary(3299);
            employee2.Describe();
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

        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }

        public string GetFirstName()
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

        public void SetSalary(double salary)
        {
            _salary = salary;
        }
        public double GetSalary()
        {
            return _salary;
        }

        public double GetSalaryPerYear()
        {
            return 12 * _salary;
        }

        public void Describe()
        {
            Console.WriteLine(this.GetFirstName() + " " + this.LastName + " " + this.GetSalary() + " " + this.GetSalaryPerYear());
        }
    }
}
