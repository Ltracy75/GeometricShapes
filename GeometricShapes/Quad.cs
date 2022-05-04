using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
    {
    internal class Quad
        {
        public int l1 { get; set; } = 0;
        public int l2 { get; set; } = 0;
        public int l3 { get; set; } = 0;
        public int l4 { get; set; } = 0;

        public int Parimeter()
            {
            return l1 + l2 + l3 + l4;
            }





        }
    }
