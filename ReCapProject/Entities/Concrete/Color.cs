﻿using ReCapProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Entities.Concrete
{
    public class Color : IEntity
    {
        public int ColorId { get; set; }
        public int ColorName { get; set; }
    }
}
