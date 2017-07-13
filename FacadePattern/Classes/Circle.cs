﻿using FacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Classes
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle::Draw();");
        }
    }
}
