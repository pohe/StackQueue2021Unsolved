﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue2021
{
    public interface IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        int CalculateSUprMonth();
    }
}
