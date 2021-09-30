using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Car_Example.Entities.Abstraction
{

    public abstract class BaseEntity
    {
        //base entities created
        public int Id { get; set; }


        private DateTime _dateTime = DateTime.Now;
        public DateTime CreateTime { get => _dateTime; set => _dateTime = value; }

    }
}
