using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap bit;
        Graphics graph;
        Pen pen;
        Move move;
       
        
        private void Mover(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode.ToString())
            {
                case "Left":
                    {
                        graph.Clear(Color.White);
                        graph.DrawPolygon(pen, move.MoveLeft());
                        image.Image = bit;
                        break;
                    }
                case "Right":
                    {
                        graph.Clear(Color.White);
                        graph.DrawPolygon(pen, move.MoveRight());
                        image.Image = bit;
                        break;
                    }
                case "Up":
                    {
                        graph.Clear(Color.White);
                        graph.DrawPolygon(pen, move.MoveUp());
                        image.Image = bit;
                        break;
                    }
                case "Down":
                    {
                        graph.Clear(Color.White);
                        graph.DrawPolygon(pen, move.MoveDown());
                        image.Image = bit;
                        break;
                    }

            }


        }
        public Form1()
        {
            
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Mover);
            
        }

        private void image_Click(object sender, EventArgs e)
        {
             bit = new Bitmap(image.Width,image.Height);
             graph = Graphics.FromImage(bit);
             pen = new Pen(Color.Black,5);
            move = new Move(float.Parse(lengths.Text)) ;


            graph.DrawPolygon(pen,move.curvep);
            image.Image = bit;
            lengths.Enabled = false;
        }

        private void lengths_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
