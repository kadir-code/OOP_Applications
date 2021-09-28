using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance_ManagementSystem.Models.BaseEntity
{
    public class Entity
    {
        public Guid Id { get => Guid.NewGuid(); }
        public string FullName { get; set; }
        public virtual string ShowInformation()
        {
            return $"Id :{this.Id}\n Full Name :{this.FullName}\n";
        }
    }
}
