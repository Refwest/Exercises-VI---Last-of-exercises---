using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_VI
{
    internal class Square
    {
        private double sideLength;
        private double area;

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
            //calcArea();
        }

        public double SideLength
        {
            get
            {
                return sideLength;
            }
        }
        public double Area
        {
            get
            {
                // 2 sposób
                //MyArea1(sideLength);
                //return area;


                //1 sposób
                return MyArea(SideLength);
            }
        }


        //Moje rozwiązanie:
        private static double MyArea(double SideLength)
        {
            double area = SideLength * SideLength;
            return area;
        }

        //or
        //private double MyArea1(double sideLength)
        //{
        //    this.area = sideLength * sideLength;
        //    return area;
        //}

        // Rozwiązanie z kursu:
        //private void calcArea()
        //{
        //    area = sideLength * sideLength;
        //}

    }
}
