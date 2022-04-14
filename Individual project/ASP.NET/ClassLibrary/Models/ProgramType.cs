﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class ProgramType
    {
        private int _id;
        private string _name;

        public int ID { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public ProgramType(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
