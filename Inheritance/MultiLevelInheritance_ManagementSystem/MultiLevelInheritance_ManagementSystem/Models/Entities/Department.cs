using MultiLevelInheritance_ManagementSystem.Models.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance_ManagementSystem.Models.Entities
{
    public class Department:Entity
    {
        public string DepartmentOfWork { get; set; }
        public override string ShowInformation()
        {
            return base.ShowInformation()+$"Department :{this.DepartmentOfWork}\n";
        }
    }
}
