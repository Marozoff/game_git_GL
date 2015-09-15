using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace game_git_GL
{
    public class anEngin
    {
        public anEngin()
        {
            invors = new Thread(inform);
            box = new Box();
        }
        Box box;
        public void image()
        { drew(); }
        private void drew()
        {
            box.drew();
        }
        Thread invors; 
        private void inform()
        {
            box.Coord.x += 0.0005;
        }
    }
}
