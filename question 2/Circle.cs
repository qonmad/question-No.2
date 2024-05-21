namespace question_2
{
    public struct Circle : IFigure

    {
        private readonly double _radius;

        public Circle(double radius)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(radius);
            _radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * _radius * _radius;

        }
    }
}
