using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace game_git_GL
{
    public class Box
    {
        public Box()
        {
            Coord = new Coords(0, 0, 0);


        }
        public void drew()
        {
            box_drew();
        }
        private void box_drew()
        {
            Gl.glTranslated(Coord.x, Coord.y, Coord.z);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glVertex2d(0, 0);
            Gl.glVertex2d(50, 0);
            Gl.glVertex2d(50, 50);
            Gl.glVertex2d(0, 50);
            Gl.glEnd();
        }
        public Coords Coord;



        public struct Coords
        {
            public double x, y,z ;

            public Coords(double X, double Y, double Z)
            {
                x = X;
                y = Y;
                z = Z;
            }
        }

    }

}
