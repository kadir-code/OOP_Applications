using Library_Books_Repository.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Books_Repository.Entities.Concrete
{
    public class Genre:BaseEntity
    {
        public string Name { get; set; }

    }
}
