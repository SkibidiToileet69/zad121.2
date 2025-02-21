using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ues
{
    internal class Worker
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Worker(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name} - {Salary}";
        }
    }
}
