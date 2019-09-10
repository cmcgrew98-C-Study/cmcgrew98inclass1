using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass1
{
    class Employee
    {
        //***************************
        // Variables / Backing fields
        //***************************
        private string _firstName;
        private string _lastName;
        private decimal _weeklySalary;

        //****************************
        // Properties
        //****************************
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        //***************************
        // Methods
        //***************************
        public string FirstAndLastName()
        {
            return _firstName + " " + _lastName;
        }

        public override string ToString()
        {
            // Fancy formatter.
            return $"{_firstName} {_lastName} {_weeklySalary.ToString("C")}";
        }

        //***************************
        // Constructor
        //***************************
        public Employee(
            string FirstName,
            string LastName,
            decimal WeeklySalary
        )
        {
            this._firstName = FirstName;
            this._lastName = LastName;
            this._weeklySalary = WeeklySalary;
        }

        public Employee()
        {
            // Do Nothing. Just added so we would have a default again.
        }
    }
}
