using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_2
{

    public struct Triangle
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;
        public Triangle(double side1,double side2,double side3)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(side1);
            ArgumentOutOfRangeException.ThrowIfNegative(side2);
            ArgumentOutOfRangeException.ThrowIfNegative(side3);
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;

        }

        public double GetSquare()
        {
            var p = (_side1 + _side2 + _side3) / 2;
            var S = Math.Sqrt(p*(p-_side1)*(p-_side2)*(p-_side3));
            return S;
        }
        public bool IsRightTriangle()
        {
            var sides = new[] { _side1, _side2, _side3 };
            var maxSide = sides.Max();
            var SumSquereSide = sides.Where(item => item != maxSide).Select(item => item * item).Sum();
            return maxSide * maxSide == SumSquereSide;

        }
    }
}
