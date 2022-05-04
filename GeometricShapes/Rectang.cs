using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
    {
    internal class rectangleboi
        {
        public int l1 { get; set; } = 0;
        public int l2 { get; set; } = 0;

        public int Area()
            {
            return l1 * l2;
            }
        public int Parim()
            {
            return 2 * l1 * l2;
            }
        }
    }
