﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BRNG.Engine
{
    struct RandomPointGeneratorEngine
    {
        private Random rand;
        public Point GenerateNewPoint()
        {
            rand = new Random();//556 -x; 382-y  size of window
            return new Point() { X = rand.Next(1, 557), Y = rand.Next(1, 382) };
        }
        public char GenerateNewChar()
        {
            
            rand = new Random();
            char generatedChar =(char)rand.Next(65, 90);
            return generatedChar;
        }
    }
}
