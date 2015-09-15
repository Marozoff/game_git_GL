using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_git_GL
{
    abstract class Anamalis
    {
        public Anamalis()
        { }
        public struct Coords
        {
            public double x, y;

            public Coords(double X, double Y)
            {
                x = X;
                y = Y;

            }
        }
        public void drew()
        {

        }
    }
}
