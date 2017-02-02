
namespace Calc
{
    class CalcModel
    {
        private double Result;
        public CalcModel()
        {
            Result = 0;
        }

        public double Number
        {
            get {
                return Result;
            }
            set {
                Result = value;
            }

        }

        //Result Return
        public double add(double x, double y)
        {
            return x + y;
        }

        //Result Return
        public double subtract(double x, double y)
        {
            return x - y;
        }

        //Result Return
        public double Multiply(double x, double y)
        {
            return x * y;
        }

        //Result Return
        public double Divide(double x, double y)
        {
            return x / y;
        }

    }
}