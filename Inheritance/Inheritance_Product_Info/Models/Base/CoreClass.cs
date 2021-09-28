﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Product.Models.Base
{
    public class CoreClass
    {
        public int Id { get; set; }
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate {
            get =>_createDate;
            set => _createDate = value;
        }

    }
}
