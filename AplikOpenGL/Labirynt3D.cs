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
    public partial class Labirynt3D : Form
    {
        public Labirynt3D()
        {
            InitializeComponent();
        }

        private void Labirynt3D_Load(object sender, EventArgs e)
        {
            //this.glContr.OpenGLDraw += new System.Windows.Forms.PaintEventHandler(this.openGLControl1_OpenGLDraw);			
        }
        double x = 12.5, y = 10.5;
        double r = 0.15;
        int[,] s = {
                       {0,0,0,14},{0,15,15,15},{15,1,15,15},{0,0,15,0}, //kwadrat labiryntu
                       //Poziome ściany
                       {1,1,2,1},{5,1,8,1},{12,1,15,1},
                       {0,2,1,2},{3,2,5,2},{7,2,9,2},{10,2,12,2},{13,2,14,2},
                       {1,3,4,3},{6,3,8,3},{9,3,14,3},
                       {1,4,2,4},{5,4,6,4},{7,4,9,4},
                       {2,5,5,5},{6,5,9,5},{10,5,14,5},
                       {0,6,1,6},{3,6,4,6},{5,6,8,6},{10,6,11,6},{12,6,15,6},
                       {1,7,2,7},{4,7,5,7},{8,7,9,7},{12,7,13,7},
                       {0,8,3,8},{6,8,10,8},{13,8,14,8},
                       {1,9,2,9},{3,9,4,9},{8,9,12,9},
                       {2,10,3,10},{11,10,14,10},
                       {1,11,4,11},{5,11,6,11},{7,11,9,11},{10,11,11,11},
                       {4,12,5,12},{7,12,8,12},{9,12,12,12},{13,12,15,12},
                       {1,13,2,13},{3,13,4,13},{5,13,12,13},{13,13,14,13},
                       {1,14,3,14},{4,14,5,14},{6,14,11,14},{12,14,13,14},
                       //Pionowe ściany
                       {1,4,1,6},{1,9,1,11},{1,12,1,14},
                       {2,1,2,3},{2,5,2,7},{2,8,2,9},{2,11,2,12},
                       {3,0,3,2},{3,3,3,5},{3,6,3,8},{3,9,3,10},{3,12,3,14},
                       {4,1,4,2},{4,3,4,4},{4,7,4,13},
                       {5,2,5,4},{5,5,5,10},{5,13,5,14},
                       {6,1,6,3},{6,4,6,5},{6,7,6,13},{6,14,6,15},
                       {7,6,7,7},{7,9,7,12},
                       {8,0,8,1},{8,7,8,8},{8,9,8,10},
                       {9,1,9,7},{9,10,9,12},
                       {10,1,10,2},{10,4,10,6},{10,7,10,8},{10,9,10,11},
                       {11,0,11,1},{11,3,11,4},{11,6,11,9},
                       {12,1,12,2},{12,4,12,5},{12,7,12,9},{12,10,12,14},
                       {13,3,13,4},{13,6,13,7},{13,8,13,9},{13,11,13,12},{13,13,13,14},
                       {14,2,14,3},{14,4,14,5},{14,7,14,11},{14,14,14,15}
                   };




        private void openGLControl1_OpenGLDraw(object sender, PaintEventArgs e)
        {
            //  Get the OpenGL object, just to clean up the code.
            SharpGL.OpenGL gl = this.glContr.OpenGL;

            gl.Clear(OpenGL.COLOR_BUFFER_BIT | OpenGL.DEPTH_BUFFER_BIT);
            gl.LoadIdentity();					// Reset The View
            gl.Translate(-7.5, -7.5, -20);


            //Rysowanie ścian
            gl.Begin(OpenGL.LINES);

            gl.Color(1.0, 1.0, 1.0);

            for (int i = 0; i < s.GetLength(0); i++)
            {
                gl.Vertex(s[i, 0], s[i, 1]); // poczatek
                gl.Vertex(s[i, 2], s[i, 3]); // koniec
            }

            //Rysowanie punktu

            gl.Begin(OpenGL.QUADS);
            gl.Color(0.5, 0.5, 1.0);

            //AB
            gl.Vertex(x - r, y - r);
            gl.Vertex(x - r, y + r);

            //BC
            gl.Vertex(x - r, y + r);
            gl.Vertex(x + r, y + r);

            //CD
            gl.Vertex(x + r, y + r);
            gl.Vertex(x + r, y - r);

            //AD
            gl.Vertex(x - r, y - r);
            gl.Vertex(x + r, y - r);

            gl.End();

        }
    }
}
