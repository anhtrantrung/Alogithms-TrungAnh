﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuat_Toan.Bai1Alogithms
{
    public class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Category(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
