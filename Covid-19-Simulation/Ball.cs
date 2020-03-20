using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19_Simulation
{
    class Ball
    {
        public Rectangle rect { get; set; }

        public int TTL { get; set; }
        public int X_Direction { get; set; }
        public int Y_Direction { get; set; }

        public bool normal { get; set; }
        public bool infected { get; set; }
        public bool recovered { get; set; }
        public bool dead { get; set; }

    }


}
