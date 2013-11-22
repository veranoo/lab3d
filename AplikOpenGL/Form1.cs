using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SharpGL;

namespace AplikOpenGL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.glContr.OpenGLDraw += new System.Windows.Forms.PaintEventHandler(this.openGLControl1_OpenGLDraw);			
        }
        double x = 0, y = 5;
        int[,] s = { {0,5,5,5}, {-1,4,4,4}, {-1,3,1,3}, {1,2,2,2}, {0,1,1,1}, {0,0,5,0}, {0,0,0,3},
                     {2,1,2,4}, {3,0,3,3}, {4,1,4,4}, {5,0,5,5}
                   };



        private void openGLControl1_OpenGLDraw(object sender, PaintEventArgs e)
        {
            //  Get the OpenGL object, just to clean up the code.
            SharpGL.OpenGL gl = this.glContr.OpenGL;

            gl.Clear(OpenGL.COLOR_BUFFER_BIT | OpenGL.DEPTH_BUFFER_BIT);
            gl.LoadIdentity();					// Reset The View
            gl.Translate(-1.5, -2.5, -10);


            //Rysowanie ścian
            gl.Begin(OpenGL.LINES);

            gl.Color(1.0, 1.0, 1.0);

            for (int i = 0; i < s.GetLength(0); i++)
            {
                gl.Vertex(s[i, 0], s[i, 1]); // poczatek
                gl.Vertex(s[i, 2], s[i, 3]); // koniec
            }


            gl.End();



        }
    }
}
