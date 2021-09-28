using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance_ManagementSystem.Models.Entities
{
    public class Person:Department
    {
        public double Salary { get; set; }

        public override string ShowInformation()
        {
            return base.ShowInformation() +$"Salary :{this.Salary}\n";
        }
    }
}
