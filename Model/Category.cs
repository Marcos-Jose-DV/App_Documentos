﻿using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDocuments.Model
{
    public class Category
    {
       
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Component> Components { get; set; }
    }
}
