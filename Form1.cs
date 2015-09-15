using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;
using Tao.DevIl;

namespace game_git_GL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        anEngin engin;
        private void Form1_Load(object sender, EventArgs e)
        {
            Incelizacia_gl();
        }
        void Incelizacia_gl()
        {
            Glut.glutInit();
            // инициализация режима окна 
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            // устанавливаем цвет очистки окна 
            Gl.glClearColor(255, 255, 255, 1);
            // устанавливаем порт вывода, основываясь на размерах элемента управления AnT 
            Gl.glViewport(0, 0, game_okno.Width, game_okno.Height);
            // устанавливаем проекционную матрицу 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            // очищаем ее 
            Gl.glLoadIdentity();
            Glu.gluOrtho2D(0.0, game_okno.Width, 0.0, game_okno.Height);
            // переходим к объектно-видовой матрице 
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
        }
    }
}
