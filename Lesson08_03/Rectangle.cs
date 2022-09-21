using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08_03
{
    public struct Rectangle
    {
        public Point TopLeft;
        public Point BottomRight;

        public Rectangle(Point toplf, Point bottomrh) 
        {
            TopLeft = toplf; BottomRight=bottomrh;
        }

        public bool IsPointInRectangle(Point taskas) 
        {
            if (TopLeft.X < taskas.X && BottomRight.X > taskas.X && BottomRight.Y < taskas.Y && TopLeft.Y > taskas.Y)
            { Console.WriteLine($"Taskas {taskas.X} {taskas.Y} yra kvadrate"); return true;  }
            //if (TopLeft.Y < taskas.Y) { }
            else Console.WriteLine($"Taskas {taskas.X} {taskas.Y} nera kvadrate"); return false;
        }
    }
}
