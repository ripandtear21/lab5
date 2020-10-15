using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Move
    {
        PointF p1;
        PointF p2;
        PointF p3;
        PointF p4;
        public PointF[] curvep;
        

        public Move(float lenght = 50)
        {
            p1 = new PointF(150, 150);
            p2 = new PointF(p1.X+lenght,p1.Y);
            p4 = new PointF(p1.X, p1.Y+lenght);
            p3 = new PointF(p1.X + lenght, p1.Y+lenght);
            curvep = new PointF[4] { p1, p2, p3, p4 };

        }
        public PointF[] MoveLeft()
        {
            for(int i = 0; i < curvep.Length; i++)
            {
                curvep[i].X -= 20;
                
            }
            return curvep;
        }
        public PointF[] MoveRight()
        {
            for (int i = 0; i < curvep.Length; i++)
            {
                curvep[i].X += 20;
                
            }
            return curvep;
        }
        public PointF[] MoveUp()
        {
            for (int i = 0; i < curvep.Length; i++)
            {
                curvep[i].Y -= 20;

            }
            return curvep;
        }
        public PointF[] MoveDown()
        {
            for (int i = 0; i < curvep.Length; i++)
            {
                curvep[i].Y += 20;

            }
            return curvep;
        }
    }   
        
}
