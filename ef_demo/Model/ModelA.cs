﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_demo.Model
{
    public class ModelA
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<ModelB> ModelBs { get; } = new List<ModelB>();
    }
}
