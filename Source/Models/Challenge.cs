﻿using System;
using System.Collections.Generic;

namespace Source.Models
{
    public class Challenge
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime CreatedAt { get; set; }

        public IEnumerable<Acceleration> Accelerations { get; set; }
    }
}
