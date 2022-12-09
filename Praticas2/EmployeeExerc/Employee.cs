using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeExerc
{
    class Employee
    {

        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public double Payment()
        {
            return Hours * ValuePerHour;
        }

    }
}
